# Nexus

Nexus is a multichannel notification system designed to evolve into a full messaging and auditing infrastructure for distributed systems, built with C# and .NET following SOLID principles.
It is designed to provide a centralized service to handle user messaging, while remaining easy to expand (e.g., adding WhatsApp notifications) through interface-driven architecture.

### Why Nexus?
In a production environment, if every service handles its own notification logic, updating email/SMS providers requires editing code across multiple repositories. This leads to code duplication, high maintenance costs, and architectural debt. Nexus centralizes notification logic into a single decoupled service to streamline maintenance and scalability.

## Features
- **Decoupled Dispatchers:** Email & SMS notification services implemented through a unified interface contract (`INotificationService`).

## Roadmap
- Unit testing with xUnit
- Database persistence for error logging and audit trails
- Support for additional channels (e.g., WhatsApp, Push Notifications)
- Retry mechanism with asynchronous logic (`async`/`await`)

## How to Run

### Prerequisites
- .NET 10 SDK (or higher)
- Git

### Instructions
1. Clone the repository:
```bash
   git clone https://github.com/Thiago-Teixeir4/nexus-notification-service.git
   ```
2. Navigate to the project directory:
```bash
  cd nexus-notification-service
```
3. Build and run the project
```bash
dotnet run
```
