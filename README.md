# ToyShelf: Consignment-Based Toy Distribution System

## Overview
ToyShelf is an innovative IoT-based consignment distribution system designed for toy collectors and retailers. Going beyond traditional management, ToyShelf features an **interactive showcase system** where physical IoT triggers (weight sensors and barcode scanners) seamlessly render 3D product models, delivering an engaging, user-centered experience.

The backend is built with robust enterprise-level standards, handling complex consignment business logic, strict inventory tracking, and automated financial settlements.

## Key Features

*   **Consignment Business Logic:** Comprehensive workflow for toy consignment, from intake to final distribution.
*   **Automated Financial Settlements:** Secure logic for generating monthly settlements (`GenerateMonthlySettlementAsync`), complete with data-locking mechanisms to ensure financial records remain immutable.
*   **Modern Invoicing:** Automated generation of stylized, modern invoice templates.
*   **Strict Data Integrity:** Utilizing Repository patterns and Unit of Work to manage transactional database operations safely.

## Tech Stack & Architecture
*   **Framework:** .NET / C# / ASP.NET Core
*   **Database:** PostgreSQL with Entity Framework Core
*   **Architecture:** Clean Architecture
*   **Design Patterns:** Repository Pattern, Unit of Work
*   **API:** RESTful API

## 📂 Project Structure

The solution follows strictly **Clean Architecture** principles to ensure separation of concerns, testability, and maintainability.

```text
ToyShelf/
├── docker-compose/            # Docker composition for easy deployment and local testing
├── ToyShelf.API/              # Presentation layer (REST API)
│   ├── Configuration/         # App settings and DI configurations
│   ├── Controllers/           # API Endpoints handling HTTP requests
│   ├── Hubs/                  # Real-time communication for IoT interactive displays
│   ├── Middleware/            # Custom middleware for exception handling & pipelines
│   └── Dockerfile             # Containerization setup
├── ToyShelf.Application/      # Core business logic and use cases
│   ├── Auth/ & Security/      # Authentication and authorization logic
│   ├── IServices/ & Services/ # Application service implementations
│   ├── Models/                # Data Transfer Objects (DTOs)
│   ├── Payment/               # Financial settlement and transaction handling
│   ├── QRCode/                # Barcode and QR code processing
│   └── Translation/           # Localization support
├── ToyShelf.Domain/           # Enterprise domain rules
│   ├── Entities/              # Core domain models
│   └── IRepositories/         # Data access interfaces
└── ToyShelf.Infrastructure/   # External concerns and data access implementation
    ├── Context/               # EF Core DbContext (ToyShelfDbContext)
    ├── Migrations/            # Database schema migrations
    ├── Repositories/          # EF Core repository implementations
    └── Email/                 # External email service integration
