# Fighting Flow

Fighting Flow is a Blazor Server app for browsing fighting-game rosters and building/managing combos for your fighters. Pick a game, pick a fighter, and view or edit their move list and combos. Users sign in with Google (Firebase Auth) to save and edit their own combos and profile.

## Tech stack

- **.NET 10** / ASP.NET Core Blazor Server (`FightingFlowDotNet.csproj`)
- **Blazorise** (Bootstrap 5 provider) for UI components
- **Firebase Authentication** (Google sign-in popup, via the Firebase JS SDK + `FirebaseAuthentication.net` / `FirebaseAdmin` for server-side token verification)
- **Google Cloud Firestore** for fighter/combo data (`Google.Cloud.Firestore`)
- Deployed to **Azure App Service** via GitHub Actions (`.github/workflows/main_fightingflow.yml`)

## Project layout

```
FightingFlowDotNet/
  Clients/            Firebase, Firestore, and Supabase client/service wrappers
  Components/
    Layout/            App shell/nav
    Pages/             Routable pages (Home, Login, Profile, ComboEditor, ComboListViewer, Resources)
    Reusable/          Shared UI components
  Models/              Domain models (Fighter, Combo, Move, User, ...)
  wwwroot/js/          Firebase client-side JS interop (firebaseAuth.js)
```

## Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- A Firebase project with **Authentication → Google** sign-in enabled
- A Firestore database in that same Google Cloud project
- A Supabase project (URL + key)
- A GCP service account with Firestore access (for the server-side Admin SDK)

## Configuration

The app does **not** read secrets from `appsettings.json`. Locally it loads an untracked `customsettings.json` (only in `ASPNETCORE_ENVIRONMENT=Development`); in Azure it reads the equivalent values from **App Service → Configuration → Application settings** (environment variables), using the standard ASP.NET Core `Section__Key` convention.

Create `FightingFlowDotNet/customsettings.json` (gitignored) for local development:

```json
{
  "Firebase": {
    "apiKey": "",
    "authDomain": "",
    "projectId": "",
    "databaseId": "(default)",
    "storageBucket": "",
    "messagingSenderId": "",
    "appId": "",
    "measurementId": ""
  },
  "GoogleCloud": {
    "ServiceAccountJson": { "...full GCP service account JSON..." }
  },
  "Supabase": {
    "Url": "",
    "key": ""
  },
  "Blazorise": {
    "ProductKey": ""
  }
}
```

| Setting | Purpose |
|---|---|
| `Firebase:ApiKey`, `AuthDomain`, `ProjectId`, `StorageBucket`, `MessagingSenderId`, `AppId` | Firebase web config passed to the JS SDK for Google sign-in (`signInWithPopup`) |
| `Firebase:DatabaseId` | Firestore database ID used by the server-side client |
| `GoogleCloud:ServiceAccountJson` | GCP service account credentials for the Firebase Admin SDK / Firestore server access |
| `Supabase:Url` / `Supabase:key` | Supabase project connection |
| `Blazorise:ProductKey` | Blazorise license key (dev only) |
| `BLAZORKEY` | Blazorise license key in Production — read directly via `Environment.GetEnvironmentVariable`, **not** nested under a section |

### Deploying to Azure

In **App Service → Configuration → Application settings**, add each key above using `__` (double underscore) to separate nested sections, e.g. `Firebase__ApiKey`, `Firebase__MessagingSenderId`, `GoogleCloud__ServiceAccountJson` (as a single-line JSON string). `BLAZORKEY` is set as a plain, top-level variable.

Also make sure the App Service hostname (or custom domain) is added under **Firebase Console → Authentication → Settings → Authorized domains** — `signInWithPopup` fails with `auth/unauthorized-domain` otherwise. `localhost` is authorized by Firebase by default, which is why local dev doesn't need this step.

## Running locally

```bash
cd FightingFlowDotNet
dotnet run
```

Then open the URL printed in the console (Blazor Server, so no separate frontend build step is required).

## Building

```bash
dotnet build
```

A `Dockerfile` is also provided under `FightingFlowDotNet/` for container builds, though the current Azure deployment (via GitHub Actions) publishes and deploys directly without Docker.
