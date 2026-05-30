# KinoDom 🎬

A full-stack online cinema platform built with **ASP.NET Core 10** and **Blazor WebAssembly**. Users can browse movies, write reviews, rate films, and manage personal watchlists. Administrators control the entire content catalog.

---

## Tech Stack

| Layer | Technology |
|---|---|
| Backend | ASP.NET Core 10 Web API |
| Frontend | Blazor WebAssembly + MudBlazor |
| Database | PostgreSQL |
| ORM | Entity Framework Core 10 + Npgsql |
| Auth | JWT Bearer (Microsoft.AspNetCore.Authentication.JwtBearer) |
| API Docs | Swagger / OpenAPI (Swashbuckle) |
| CI/CD | GitHub Actions |

---

## Project Structure

```
KinoDom/
├── src/
│   ├── KinoDom.API/                  # ASP.NET Core Web API
│   │   ├── Configurations/           # EF Core entity configurations
│   │   ├── Controllers/              # REST API controllers (WIP)
│   │   ├── Data/
│   │   │   ├── Models/               # Domain entities
│   │   │   ├── DTOs/                 # Data transfer objects
│   │   │   └── ApplicationDbContext.cs
│   │   ├── Enums/                    # UserRole enum
│   │   ├── Mappers/                  # Entity ↔ DTO mapping extensions
│   │   ├── Repositories/
│   │   │   ├── Interfaces/           # IRepository contracts
│   │   │   └── Implementations/      # EF Core implementations
│   │   └── Services/                 # Business logic layer (WIP)
│   └── KinoDom.Blazor.UI/            # Blazor WASM frontend
├── docs/
│   └── erd.png                       # Entity relationship diagram
├── .github/
│   └── workflows/                    # CI/CD pipelines
└── KinoDom.slnx
```

---

## Domain Models

| Entity | Description |
|---|---|
| `User` | Platform account with role (Guest / User / Admin) |
| `Movie` | Film with title, description, year, poster, trailer, average rating |
| `Genre` | Movie genre category |
| `MovieGenre` | Many-to-many join between Movie and Genre |
| `Rating` | User score (1–10) for a movie |
| `Review` | User text review for a movie |
| `WishList` | User's "want to watch" list |
| `WatchedList` | User's watched history |

All entities inherit from `BaseEntity` which provides `Id` (Guid), `IsActive` (bool), and `CreatedAt` (DateTime).

---

## User Roles

| Role | Permissions |
|---|---|
| **Guest** | Browse catalog, view movie details |
| **User** | Rate movies, write reviews, manage wishlist and watched history |
| **Admin** | Full content management — movies, genres, users, moderation |

---

## Getting Started

**Requirements**
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/) (for PostgreSQL)

**Run locally**

```bash
# Clone the repository
git clone https://github.com/muhammadolimi/KinoDom.git
cd KinoDom

# Start the database
docker-compose up -d

# Run the backend
cd src/KinoDom.API
dotnet run

# Run the frontend (separate terminal)
cd src/KinoDom.Blazor.UI
dotnet run
```

Swagger UI is available at `https://localhost:{port}/swagger` when running in Development mode.

---

## Architecture

The backend follows a clean layered architecture:

```
Controllers  →  Services  →  Repositories  →  ApplicationDbContext  →  PostgreSQL
                    ↑              ↑
                  DTOs         EF Models
                Mappers       Configurations
```

- **Configurations** — EF Core `IEntityTypeConfiguration<T>` per entity, handling keys, constraints, indexes, and relationships
- **Repositories** — async data access via `IRepository` interfaces; each has `GetAllAsync`, `GetByIdAsync`, `CreateAsync`, `UpdateAsync`, `DeleteAsync`
- **Mappers** — static extension methods for converting between entities and DTOs (`ToDto`, `ToEntity`)
- **Services** — business logic layer (in progress)
- **Controllers** — REST endpoints with `[Authorize]` role-based access (in progress)

---

## Current Status

- [x] Domain models
- [x] EF Core entity configurations
- [x] ApplicationDbContext
- [x] DTOs (Create / Update / Read) for all entities
- [x] Mappers for all entities
- [x] Repository interfaces and implementations for all entities
- [x] Dependency injection registration
- [ ] Service layer
- [ ] JWT authentication
- [ ] REST controllers
- [ ] Swagger with Bearer token support
- [ ] Blazor frontend pages

---

## Contributing

This project is developed as a team learning project for full-stack .NET development. The codebase follows consistent patterns documented in `docs/` — read the architecture guides before contributing.
