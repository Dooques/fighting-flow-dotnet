# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project

Fighting Flow is a Blazor Server app (.NET 10, ASP.NET Core Interactive Server render mode) for browsing fighting-game rosters and building/managing combos. Users sign in with Google via Firebase Auth; fighter/combo data lives in Google Cloud Firestore; Supabase is used for additional storage. Deployed to Azure App Service via GitHub Actions (`.github/workflows/main_fightingflow.yml`).

Single-project solution: `FightingFlowDotNetSol.sln` → `FightingFlowDotNet/FightingFlowDotNet.csproj`. There is no test project in this solution.

## Commands

```bash
cd FightingFlowDotNet
dotnet run              # run locally (Blazor Server — no separate frontend build)
dotnet build             # build (run from repo root or FightingFlowDotNet/)
```

Use the `windows-dev-server` skill to start/stop/check the dev server rather than running it ad hoc — `dotnet run`/`dotnet watch` left in the foreground here are unreliable to manage from this shell, and plain `pkill` does not reliably stop them on Windows.

### Local configuration

The app does **not** read secrets from `appsettings.json`. In `Development`, `Program.cs` additionally loads `FightingFlowDotNet/customsettings.json` (gitignored, required — the app won't start without it). It needs `Firebase` (web config + `DatabaseId`), `GoogleCloud:ServiceAccountJson` (GCP service account for Firebase Admin/Firestore), `Supabase:Url`/`key`, and `Blazorise:ProductKey`. See README.md for the full shape and the Azure `Section__Key` env-var equivalents (production instead reads `BLAZORKEY` as a bare top-level env var, not nested under `Blazorise`).

## Architecture

- **`Program.cs`** wires everything: cookie auth (`AddAuthentication().AddCookie()`, not a scheme with real password checks), rate limiting (`AddRateLimiter` — fixed-window limiters `"signup"` and `"auth"`, plus a global per-IP limiter that exempts Blazor/static asset paths), and Kestrel connection/body-size/timeout limits. Three minimal-API endpoints (`/auth/signin`, `/auth/signout`, `/auth/signup`) sit alongside the Razor component pipeline — signin verifies a Firebase ID token server-side (`FirebaseAuthVerifier`) and issues the app's own auth cookie; the Blazor circuit relies on that cookie via `AddCascadingAuthenticationState()`.
- **Auth flow is split JS/server**: Google sign-in itself happens client-side via the Firebase JS SDK (`wwwroot/js/firebaseAuth.js`, `signInWithPopup`), which hands the resulting ID token to `POST /auth/signin` for server-side verification and cookie issuance. `FirebaseAuthVerifier` (Clients/) does the token verification; `Clients/Helper/GoogleCredentialFactory` builds the `GoogleCredential` used both for the Firebase Admin SDK and for the Firestore client — from `GoogleCloud:ServiceAccountJson` in config, not a credentials file.
- **Data access is unabstracted Firestore**: `Clients/FirestoreGetter` is the only data-access class, injected directly into pages (no repository/service interface layer). Firestore layout: `characters/{fighterId}` documents (→ `Fighter`), with a `combos` subcollection per fighter (→ `Combo`, mapped via `[FirestoreData]`/`[FirestoreProperty]` attributes). `Clients/UserData` and the `users` collection hold profile data separately from Firebase Auth identity.
- **Cross-page game selection state**: `Models/State/GameSelectedState` is a scoped DI service (not a static/singleton) holding the currently selected `GameType` and background image, with a plain C# event (`OnChange`) for pub/sub. `MainLayout.razor` subscribes to it to drive the page background (implements `IDisposable` to unsubscribe) and `Home.razor` sets it on game selection. Per-game fighter/move/combo reference data (not user data) lives as static C# collections in `Resources/` (`Tekken8.cs`, `StreetFighter6.cs`, `MortalKombat1.cs`, `CommonMoves.cs`), keyed off `Models/Enums/GameType`.
- **Components layout**: `Components/Pages/` are routed pages (`Home`, `Login`, `Profile`, `ComboEditor`, `ComboListViewer`, `Resources`); `Components/Layout/` is the app shell/nav (`MainLayout`, `FlowAppBar`, `ReconnectModal`); `Components/Reusable/` holds shared UI, with `Reusable/Editor/` specifically for the combo-building UI (`MoveSelector`, `MoveButton`, `ComboEditorButtons`, `ComboMetaFields`). `Components/Helpers/` has small non-component helpers (`ListPopulator`, `MoveStyle`) used by the Razor views.
- **UI kit**: Blazorise (Bootstrap 5 provider, FontAwesome icons), configured with `Immediate = true` in `Program.cs`.

## Working in this repo

- A Cursor skill at `.cursor/skills/fighting-flow-checkpoint/SKILL.md` maintains a repo-root `codex.md` handoff document (current branch, active feature, in-progress implementation notes, next actions) written by prior agent sessions. Read `codex.md` before changing code if it's present, treat it as the working handoff, and don't discard uncommitted changes it describes unless the user explicitly asks — the same practice applies here even outside Cursor.
- A project skill at `.claude/skills/fighting-flow-claude-log/SKILL.md` maintains `claude-changes.md`, a running log of changes made with Claude Code: the plan before executing a non-trivial change, then the outcome after. It's distinct from `codex.md` — don't merge the two.
- `DDOS_ASSESSMENT.md` is a point-in-time hardening assessment (2026-08-10). Some of its recommendations (rate limiting, Kestrel limits) are already implemented in `Program.cs` — check current code rather than assuming the doc's findings still all apply.
