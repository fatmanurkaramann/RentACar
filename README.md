# Rent A Car Project

Rent A Car is a scalable vehicle rental system built with .NET, following Domain-Driven Design and Clean Architecture principles.  
It supports managing vehicles, bookings, and users efficiently.

## Technologies
- .NET 9
- C#  
- REST API

## Architecture Overview
The project is organized into multiple layers following Clean Architecture:
Domain Layer: Contains business logic, entities, value objects, aggregates, and domain services.
Application Layer: Orchestrates use cases, application services, and DTOs.
Infrastructure Layer: Implements database access, external integrations, and repositories.
API Layer: Exposes REST endpoints (if applicable).

## Key Concepts
Entities: Represent core business objects with unique identities.
Value Objects: Immutable types that describe attributes without identity.
Aggregates: Cluster entities and value objects to maintain consistency.
Repositories: Abstract data access for aggregates.
Soft Delete & Audit: Track creation, update, and deletion metadata for entities.
