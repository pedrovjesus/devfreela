# DevFreela

DevFreela is a study project built with **ASP.NET Core**, following modern architectural patterns and good development practices.
The system simulates a freelancing platform where clients can register projects and freelancers can interact by adding comments and tracking progress.

---

## 🧠 Core Principles

DevFreela is structured around solid architectural foundations:

* **DDD (Domain-Driven Design)** to organize business rules and domain logic
* **SOLID principles** for clean and maintainable code
* **Clean Architecture** to keep layers independent and decoupled
* **CQRS pattern** (expanding gradually)
---

## ⚙️ Technologies & Tools

| Technology / Tool            | Purpose                            |
| ---------------------------- | ---------------------------------- |
| **ASP.NET Core Web API**     | Application backend                |
| **Docker / Docker Compose**  | Local infrastructure and isolation |
| **Apache Kafka** *(planned)* | Event streaming and communication  |

---

## 🧱 Project Structure

```
DevFreela/
 ├── devfreela.Api                 → Controllers, HTTP pipeline, Swagger
 ├── devfreela.Application         → Services, DTOs, Use cases, Interfaces
 ├── devfreela.Core                → Entities, Value Objects, Domain logic
 └── devfreela.Infrastructure      → (Future) persistence, messaging integrations
```

---

## ▶️ Running the Application

### 1. Clone the repository

```sh
git clone https://github.com/pedrovjesus/devfreela.git
cd devfreela
```

### 2. Start Docker (Kafka infrastructure will be added here soon)

```sh
docker compose up -d
```

### 3. Run the project

```sh
dotnet run --project devfreela.Api
```

## 📌 Features (current stage)

* Project creation and management
* Ability to update or delete a project
* Comments linked to projects
* Project workflow (start / finish)

More features will continue to evolve over time.

