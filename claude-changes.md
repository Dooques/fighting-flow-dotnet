# Fighting Flow — Claude Change Log

Tracks changes made with Claude Code in this repo: what's planned before it's executed, and what actually happened.

Newest entries at the top. Statuses: `Planned`, `In progress`, `Done`, `Abandoned`.

## 2026-08-22 — Favicon switched to the Fighting Flow logo
**Status:** Done

Changed the `<link rel="icon">` in `App.razor` from the standalone `favicon.png` to `images/fighting_flow_logo.png` (the circular "F" mark) — `images/fighting_flow_title_logo.png` also exists but is a wide wordmark, illegible at favicon size, so wasn't used. `favicon.png` itself left in place, just no longer referenced.

**Files:** FightingFlowDotNet/Components/App.razor

**Outcome:** Verified with `dotnet build -o <scratch dir>`: 0 errors, same pre-existing warnings only.

## 2026-08-22 — Leave-editor warning on the fighter header click
**Status:** Done

**Plan:**
- The fighter name/portrait header row in `ComboEditor.razor` navigates straight back to the combo viewer on click (`NavigateToComboViewer`) with no confirmation, unlike the app-bar's home/game-switch navigation which already warns via `FlowAppBar`'s "Leave the editor?" modal.
- Add the same confirm-leave modal (same title/body copy, `glass-modal` styling) directly in `ComboEditor.razor`, and route the header's `@onclick` through a `RequestLeaveEditor` → confirm/cancel flow instead of navigating immediately.

**Files:** FightingFlowDotNet/Components/Pages/ComboEditor.razor

**Outcome:** Implemented as planned — same copy/styling as `FlowAppBar`'s confirm-leave modal (wording adjusted to "back to the combo list" since this one always returns to the combo viewer, not conditionally home). Verified with `dotnet build -o <scratch dir>`: 0 errors, same pre-existing warnings only. Browser-level verification not yet done.

## 2026-08-22 — Dark background/light text for editor text fields
**Status:** Done

**Plan:**
- `ComboMetaFields.razor` (Description `MemoInput`, Damage `TextInput`) are the only text fields on the Combo Editor screen — Blazorise/Bootstrap defaults them to a light background with dark text, which reads poorly against the dark glass `combo-editor-panel`.
- Wrap the fields in a `combo-meta-fields` class and add CSS targeting `.form-control` within it: dark translucent background, light text, light placeholder, and a focus state that stays dark (no default light Bootstrap focus glow).
- Not touching the Login/Profile field styling — scope is the editor screen only, per the ask.

**Files:** FightingFlowDotNet/Components/Reusable/Editor/ComboMetaFields.razor, FightingFlowDotNet/wwwroot/app.css

**Outcome:** Implemented as planned. Verified with `dotnet build -o <scratch dir>`: 0 errors, same pre-existing warnings only. Note: the fighter-portrait `<img>` in `ComboEditor.razor` was edited outside this session (75x75, `object-fit: contain`, no border-radius/object-position) since the last read — left as-is per instructions, not reverted. Follow-up in the same session: bumped the Description `MemoInput` to `Rows="2"` and added `resize: none; overflow: hidden;` on `.combo-meta-fields textarea.form-control` to drop the resize handle and scrollbar. Browser-level verification of the new field styling not yet done.

## 2026-08-22 — Sign-in-required dialog instead of a disabled Save button
**Status:** Done

**Plan:**
- Revise the previous "Block combo save for unauthenticated users" UX: keep the Save button always enabled/clickable (remove `Disabled="@(!CanSave)"`), rather than disabling it when logged out.
- In `ComboEditorButtons.RequestSave()`, branch on `CanSave`: show the existing save-confirmation modal when true, or a new "sign in required" modal when false, with a button that navigates to `/login`.
- Remove the persistent "Log in to save this combo" banner from `ComboEditor.razor` — the on-click dialog now carries that messaging, so the banner would be redundant.
- Server-side enforcement in `ComboEditor.SaveCombo()` (added in the prior change) stays as-is — this change is UI-only.

**Files:** FightingFlowDotNet/Components/Reusable/Editor/ComboEditorButtons.razor, FightingFlowDotNet/Components/Pages/ComboEditor.razor

**Outcome:** Implemented as planned. `ComboEditorButtons.RequestSave()` now shows a new `_signInRequiredModal` ("Sign in required" / "You need to be signed in to save a combo.") when `CanSave` is false, with Cancel + a "Log In" button (`GoToLogin`) that hides the modal and navigates to `/login` via an injected `NavigationManager`; otherwise it opens the existing save-confirmation modal as before. Removed the `Disabled` attribute from the Save button and the persistent warning banner from `ComboEditor.razor`. `SaveCombo()`'s server-side auth re-check is untouched. Verified with `dotnet build -o <scratch dir>`: 0 errors, same pre-existing warnings only. Browser-level verification not yet done.

## 2026-08-22 — Block combo save for unauthenticated users
**Status:** Done

**Plan:**
- This is the unauthenticated-write-path finding from `DDOS_ASSESSMENT.md` (#2) for `ComboEditor.razor` → `FirestoreGetter.SaveCombo`. Fix both ends:
  - Server-side (real enforcement): in `ComboEditor.razor`'s `SaveCombo()`, check `AuthStateTask`'s `User.Identity.IsAuthenticated` before calling `FirestoreGetter.SaveCombo`; bail out with an error message if not authenticated. This is what actually stops the write.
  - Client-side (UX): compute `_isAuthenticated` once (from the same cascading `AuthStateTask`), pass it down to `ComboEditorButtons` to disable the Save button, and show an inline message explaining why when logged out.
- Not touching the Delete/Clear/Break buttons or the route itself — scope is Save only, per the ask.

**Files:** FightingFlowDotNet/Components/Pages/ComboEditor.razor, FightingFlowDotNet/Components/Reusable/Editor/ComboEditorButtons.razor

**Outcome:** Implemented as planned. `ComboEditor.OnInitializedAsync` computes `_isAuthenticated` from the cascading `AuthStateTask`; `SaveCombo()` re-checks it before calling `FirestoreGetter.SaveCombo` and bails with `_saveError = "You need to be logged in."` if not (real enforcement — the earlier client-side gate is UX only). Save button gets `Disabled="@(!CanSave)")` and `RequestSave()` also short-circuits on `!CanSave` as defense-in-depth. Added a `glass-alert` banner with a link to `/login` when logged out. Verified with `dotnet build -o <scratch dir>`: 0 errors, same 4 pre-existing unrelated warnings (no new ones). Browser-level visual/functional verification not yet done — haven't confirmed the disabled state or the save-blocked error path against a real logged-out session.

## 2026-08-22 — Confirm-logout modal on the Profile page
**Status:** Done

**Plan:**
- Add a "warning" confirmation modal before Logout actually runs, matching the existing `glass-modal` confirm pattern used elsewhere for state-changing actions (delete combo, clear moves, leave editor): Cancel + a colored confirm button.
- Logout button now calls `RequestLogout` (shows the modal) instead of `Logout` directly; the modal's confirm button calls `ConfirmLogout`, which hides the modal and then runs the existing `Logout()` sign-out logic unchanged.

**Files:** FightingFlowDotNet/Components/Pages/Profile.razor

**Outcome:** Implemented as planned. Verified with `dotnet build -o <scratch dir>`: 0 errors (pre-existing unrelated warnings only). Browser-level visual verification not yet done.

## 2026-08-22 — Wrap profile and resources pages in a glass container
**Status:** Done

**Plan:**
- Apply the same `glass-card` treatment used on the Login page to the Profile and Resources pages' content (wrap in Blazorise `<Card>`/`<CardBody>`).
- Rename the `login-glass-panel` CSS rule (max-width/centering/padding) to the generic `glass-panel` so Login, Profile, and Resources share it instead of duplicating the rule; update Login.razor's class reference accordingly.
- Set text (headings, "Under construction..." placeholders, error message, Logout button) to `TextColor="TextColor.Light"` for contrast, matching Login. Watch for the `<Text>`-as-first-element-after-`{` Razor gotcha already hit on the Login page (fully-qualify as `<Blazorise.Text>` where needed).

**Files:** FightingFlowDotNet/Components/Pages/Profile.razor, FightingFlowDotNet/Components/Pages/Resources.razor, FightingFlowDotNet/Components/Pages/Login.razor, FightingFlowDotNet/wwwroot/app.css

**Outcome:** Implemented as planned; also fully-qualified `Under construction...`/error `<Text>` as `<Blazorise.Text>` in both pages preemptively (not just where the gotcha strictly triggers) for consistency. Verified with `dotnet build -o <scratch dir>` (isolated from the locked `bin/` of the running dev server): 0 warnings, 0 errors. Browser-level visual verification not yet done for any of the three glass-wrapped pages (Login, Profile, Resources).

## 2026-08-22 — Wrap login page in a glass container
**Status:** Done

**Plan:**
- Wrap the Login page's content in the existing `glass-card` styling (same `background: rgba(20,20,20,0.35); backdrop-filter: blur(12px);` glass treatment already used by `CharacterCardDetailed`, the combo editor panel, etc.) by switching the outer `<Div>` to a Blazorise `<Card>`/`<CardBody>`.
- Add a small `login-glass-panel` CSS rule (max-width + centering + padding) in `app.css` since the login form is narrower content than the card-grid uses it elsewhere.
- (Added mid-task, same session) Set all headings/labels/buttons/error text to `TextColor="TextColor.Light"` for contrast against the dark glass background, matching the convention used elsewhere (`CharacterCardDetailed`, `ComboEditor`, etc.). Moved the "Sign In With Google" button onto the same row as the Sign In / Show Sign Up buttons instead of its own line below.

**Files:** FightingFlowDotNet/Components/Pages/Login.razor, FightingFlowDotNet/wwwroot/app.css

**Outcome:** `dotnet build FightingFlowDotNet/FightingFlowDotNet.csproj --no-restore -p:UseAppHost=false` succeeded with 0 warnings/errors. Hit and fixed a known Razor gotcha in this codebase: a `<Text>` (Blazorise) element as the first tag right after `{` in an `@if` block gets misparsed as Razor's reserved `<text>` pseudo-element once it has attributes (RZ1023) — fixed the same way `CharacterCardDetailed.razor` already does, by fully qualifying as `<Blazorise.Text>`. Browser-level visual verification not yet done.

<!-- Example entry:
## 2026-08-22 — Short description of the change
**Status:** Planned

**Plan:**
- Step 1
- Step 2

**Files:** path/one.cs, path/two.razor

**Outcome:** (filled in once executed — what actually changed, build/test results, anything that deviated from the plan)
-->
