# DDoS Resilience Assessment

_Assessed 2026-08-10 against the codebase in `FightingFlowDotNetSol` (Blazor Server, deployed to Azure App Service)._

## Short answer

**No** — as it stands, the app has no application-layer defenses against even a modest flood, and no infra-layer mitigation beyond Azure's automatic basic network protection.

## Findings

### 1. No rate limiting anywhere
No `Microsoft.AspNetCore.RateLimiting`, no throttling middleware, nothing. Every route accepts unlimited requests per client.

### 2. Every page is effectively public
There isn't a single `[Authorize]` or `[AllowAnonymous]` attribute anywhere in the codebase — meaning nothing is actually gated. Pages that do real backend work on every load are wide open:
- `Home.razor` and `ComboListViewer.razor` (`/{Game}/{Name}`) hit **Firestore** on `OnInitializedAsync` for anyone who loads them.
- `ComboEditor.razor` even has an **unauthenticated write path** (`FirestoreGetter.SaveCombo`).
- `POST auth/signup` is public and calls Firebase to create a user — someone could script a loop hitting this and spam/flood the Firebase project (real billing/quota implications, not just app slowness).

### 3. Blazor Server circuits are unbounded
Blazor Server keeps a live, stateful SignalR "circuit" per open tab, consuming server memory/CPU for as long as it's connected. `AddInteractiveServerComponents()` is called with zero options — no cap on buffered render batches, no limit on how many circuits stay alive, no connection cap. Mass-opening tabs/connections is a classic way to exhaust a Blazor Server app, and nothing here stops it.

### 4. No Kestrel-level limits
No `ConfigureKestrel` call anywhere — no max concurrent connections, no request body size cap, no timeouts. Running on bare framework defaults.

### 5. No CDN or WAF in front of it
The GitHub Actions workflow (`.github/workflows/main_fightingflow.yml`) deploys straight to Azure App Service. No Azure Front Door, no Cloudflare, no Azure DDoS Protection Standard. The app gets whatever Azure's automatic "Basic" DDoS protection provides — network-layer only (SYN floods etc.) — and does **nothing** against application-layer abuse like hammering `/` or `auth/signup` with normal-looking HTTP requests.

## Practical risk

The realistic risk isn't a huge botnet takedown — it's that a single person with a simple script could hit `/{Game}/{Name}` or `auth/signup` repeatedly and:
- drive up Firestore/Firebase read/write costs, and/or
- open enough SignalR circuits to slow or crash the App Service instance,

with no rate limiter or auth gate in the way to slow them down.

## Hardening plan, in priority order

1. **Rate limiting** — add `Microsoft.AspNetCore.RateLimiting` (built into ASP.NET Core, no extra package needed), and put a strict limiter on `auth/signup` specifically since it's the most expensive+abusable public endpoint.
2. **Kestrel limits** — `builder.WebHost.ConfigureKestrel(...)` to cap `MaxConcurrentConnections` and request sizes/timeouts.
3. **Blazor Server circuit options** — configure `AddHubOptions` (or the equivalent circuit options for the new hosting model) to cap buffered render batches and disconnected-circuit retention, so idle/abandoned circuits get reclaimed instead of piling up.
4. **Auth gates** — decide which pages actually need to be public vs. behind login, and add explicit `[Authorize]`/policy checks rather than relying on implicit-public-by-default.
5. **Infra layer (biggest bang for buck if budget allows)** — put Cloudflare (free tier) or Azure Front Door in front of the App Service. This is the layer that actually stops real DDoS traffic before it ever reaches the app or the Firestore bill.
