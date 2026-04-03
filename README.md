# XLDent Dentist App

Website, agent that complements XLDent

## Projects

| Project | Description |
|---------|-------------|
| `Api` | ASP.NET Core REST API + SignalR hub. JWT auth, PostgreSQL via EF Core. |
| `UI` | Blazor WebAssembly front-end. |
| `Agent` | Windows/Linux background service installed at each dental office. Connects to the API hub via SignalR and proxies queries to the local XLDent database. |
| `XLDENTProxy` | Local data access layer for the XLDent database. |
| `Shared` | DTOs, contracts, and constants shared across projects. |
