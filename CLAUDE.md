# CLAUDE.md

## Project Overview

StaffingCenter is a .NET staffing/resource management application built with Blazor and SQL Server. It manages employees, work centers, allocations, projects, demands, skills, and related workforce planning data.

## Solution Structure

- **StaffingCenter.sln** - Visual Studio 2019 solution (Format Version 12.00)
- **TemplateBlazorMono/** - Blazor web application (main UI project, `StaffingCenter.csproj`)
- **SharedClasses/** - .NET 5.0 class library containing:
  - `Models/` - EF Core entity models and `StaffingCenterSENGSContext` DbContext
  - `DTO/` - Data Transfer Objects for API/service layer
  - `Enums/` - Enumerations (`EmployeeRolEnum`, `ProgramTypeEnum`)
  - `Helpers/` - Utility classes (`ProductParameters`, `ResultHelperBase`)
  - `MapperProfile.cs` - AutoMapper configuration mapping entities to DTOs
- **StaffingCenter.SSIS/** - SQL Server Integration Services project for reporting (`GeneralReport.dtsx`)

## Tech Stack

- **Framework:** .NET 5.0
- **Frontend:** Blazor
- **ORM:** Entity Framework Core 5.0.15
- **Database:** SQL Server (database: `StaffingCenterSENGS`)
- **Mapping:** AutoMapper 11.0.1
- **ETL/Reporting:** SSIS (SQL Server Integration Services)
- **IDE:** Visual Studio 2019 (v16)

## Build

```bash
dotnet build StaffingCenter.sln
```

Build configurations: `Debug`, `Development`, `Release`

## Database

The EF Core models are scaffolded from a SQL Server database. To re-scaffold:

```bash
Scaffold-DbContext "<connection-string>" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Model
```

Key entities: `Employee`, `AllocationProject`, `WorkCenter`, `Customer`, `Demand`, `Actual`, `Skill`, `Allocation`, `Holiday`, `CustomRatio`, `Manager`, `User`, `Role`

## Code Conventions

- Entity models live in `SharedClasses/Models/`
- Every entity has a corresponding DTO in `SharedClasses/DTO/`
- AutoMapper mappings are registered in `SharedClasses/MapperProfile.cs` with `ReverseMap()` for bidirectional mapping
- Namespace pattern: `SharedClasses.Models`, `SharedClasses.DTO`, `SharedClasses.Enums`, `SharedClasses.Helpers`
