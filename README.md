# CQRS Template - .NET 8 Vertical Slice Architecture

A fully modern CQRS template built on .NET 8 with:

* Vertical Slice Architecture
* MediatR
* FluentValidation
* Clean folder structure
* Minimal API setup

---

## Features

* Command & Query separation (CQRS)
* Feature-based folders
* MediatR request/response pipeline
* FluentValidation for input validation
* Entity Framework Core (SQLite ready)
* Fully open-source boilerplate

---

## Project Structure

```
CQRS.Template/
├── CQRS.Template.API/              → Web API (entry point)
├── CQRS.Template.Application/      → CQRS Handlers, Commands, Queries, Validators
├── CQRS.Template.Domain/           → Entities
├── CQRS.Template.Infrastructure/   → Persistence (EF Core, DBContext)
```

---

## Getting Started

### 1️⃣ Clone the repo

```bash
git clone https://github.com/shiraz050/dotnet8-cqrs-mediatr-template.git
cd dotnet8-cqrs-mediatr-template
```

### 2️⃣ Build & Run API

```bash
dotnet build
cd CQRS.Template.API
dotnet run
```

### 3️⃣ Test the API

* Open Swagger: `https://localhost:PORT/swagger`
* POST: `/api/users`

Example request body:

```json
{
  "name": "User User",
  "email": "User@example.com"
}
```

---

## Next Steps

* Add EF Core Persistence
* Add Queries
* Expand Features
* Add Unit Tests
* Deployable to Cloud

---

## License

MIT License © 2024 Shiraz Ahmed
