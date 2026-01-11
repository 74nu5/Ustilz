# Ustilz - C# Utility Library

## Project Overview

Ustilz is a comprehensive C# utility library providing reusable components across multiple packages. The library targets .NET 8, 9, and 10, and is published as NuGet packages.

**Repository:** https://github.com/avondero/Ustilz
**Build Status:** Azure DevOps + GitHub Actions CI/CD
**License:** [Check repository]

## Repository Structure

```
Ustilz/
├── src/                    # Source code for all packages
├── test/                   # Unit tests
├── samples/                # Sample implementations
├── benchmarks/             # Performance benchmarks
├── docs/                   # Documentation (Markdown files)
└── Ustilz.sln             # Solution file
```

## Main Packages

### Core Utilities

1. **Ustilz.Extensions** - Core extension methods for .NET types (strings, collections, actions, etc.)
2. **Ustilz.Utils** - Validation utilities and helper classes
3. **Ustilz.Time** - Time manipulation, testable clock, duration utilities
4. **Ustilz.Models** - Shared model types (ServiceResult, PageableResult)

### Data & Serialization

5. **Ustilz.Data** - Data access layer base classes with Entity Framework integration
6. **Ustilz.Json** - JSON serialization/deserialization utilities
7. **Ustilz.Xml** - XML serialization utilities
8. **Ustilz.Parsers** - CSV parsing with attribute-based configuration
9. **Ustilz.Sql** - Fluent SQL query builder

### Web Development

10. **Ustilz.Api** - API response patterns for REST APIs
11. **Ustilz.Api.Data** - Base CRUD controllers
12. **Ustilz.AspNetCore** - ASP.NET Core middleware and utilities
13. **Ustilz.AspNetCore.Mvc** - MVC-specific utilities
14. **Ustilz.Http** - Simplified HTTP client wrapper

### UI & Components

15. **Ustilz.UI** - UI color utilities
16. **Ustilz.Razor** - Razor component base classes and utilities

### Specialized

17. **Ustilz.Logging** - Custom logging providers and console utilities
18. **Ustilz.Network** - Network utilities (Wake-on-LAN)
19. **Ustilz.StateMachine** - Generic state machine implementation
20. **Ustilz.Programs** - Console and batch program builders
21. **Ustilz.Attributes** - Custom validation and metadata attributes
22. **Ustilz.Extensions.Configuration** - Configuration builder extensions
23. **Ustilz.Medias** - Media file processing utilities
24. **Ustilz.Wtf** - Experimental/fun utilities

## Key Features by Category

### String Extensions (`Ustilz.Extensions`)
- Format manipulation (PascalCase splitting, diacritics removal)
- Hash generation
- ANSI color support for console output
- Secure string conversion
- Enum parsing

### Collection Extensions (`Ustilz.Extensions`)
- Pagination (`Page`)
- Advanced LINQ operations (`Bifurcate`, `Pairwise`, `WithIndex`)
- Safe iteration (`ForEach`, `NotAny`)
- Data table conversion

### Action Extensions (`Ustilz.Extensions`)
- Safe execution with exception handling
- Conditional execution (`ExecuteIfTrue`, `ExecuteIfFalse`)
- Multiple condition execution

### Data Access (`Ustilz.Data`)
- Base repository pattern implementation
- Entity base classes (ADataObject, ATraceableDataObject)
- Queryable pagination
- EF Core DbContext base class

### API Response Patterns (`Ustilz.Api`)
- Standardized response wrapper (ApiResponseBody)
- HTTP status code result types (200, 201, 204, 400, 404, 409)
- Error handling
- Minimal API module support

### Time Utilities (`Ustilz.Time`)
- Testable Clock class for DateTime mocking
- Duration enumeration and extensions
- Human-readable date formatting

### HTTP Client (`Ustilz.Http`)
- Simplified HTTP service with typed responses
- Built-in performance tracking
- GET/POST helpers

### CSV Parsing (`Ustilz.Parsers`)
- Attribute-based column mapping
- Support for DateTime, Number, Percentage columns
- Dynamic columns
- Caching and logging

### State Machine (`Ustilz.StateMachine`)
- Generic state manager with transitions
- Async state changes
- Automatic transition support

### SQL Query Builder (`Ustilz.Sql`)
- Fluent interface for SELECT queries
- Support for JOINs, WHERE clauses, conditions
- Type-safe query construction

## Development Standards

### Code Style
- **Target Framework:** .NET 8, 9, 10
- **Language:** C# 14 (modern syntax with extension methods)
- **Nullable Reference Types:** Enabled

### Patterns Used
- Repository Pattern (Data access)
- Builder Pattern (Programs, SQL queries)
- State Machine Pattern
- Result Pattern (ServiceResult, ExecutionResult)
- Extension Methods (throughout)

### Testing
- Unit tests in `test/` directory
- Benchmark tests in `benchmarks/` directory

## Documentation Structure

Documentation is organized in the `/docs` directory with the following structure:

```
docs/
├── extensions/          # Ustilz.Extensions documentation
├── data/                # Ustilz.Data documentation
├── api/                 # Ustilz.Api documentation
├── json/                # Ustilz.Json documentation
├── time/                # Ustilz.Time documentation
├── http/                # Ustilz.Http documentation
├── parsers/             # Ustilz.Parsers documentation
├── sql/                 # Ustilz.Sql documentation
├── state-machine/       # Ustilz.StateMachine documentation
├── logging/             # Ustilz.Logging documentation
├── network/             # Ustilz.Network documentation
├── ui/                  # Ustilz.UI documentation
├── razor/               # Ustilz.Razor documentation
└── ...                  # Other packages
```

Each documentation file uses YAML frontmatter with:
- `title`: Component or feature name
- `category`: Package category
- `tags`: Relevant tags for searchability
- `component`: Component name (if applicable)
- `apiVersion`: API version

## Common Use Cases

### 1. String Manipulation
```csharp
using Ustilz.Extensions;
string name = "johnDoe".SplitPascalCase();
string initials = "John Doe".GenerateInitials();
```

### 2. Safe Collection Operations
```csharp
using Ustilz.Extensions;
var pagedItems = collection.Page(pageNumber: 1, pageSize: 10);
collection.ForEach(item => Console.WriteLine(item));
```

### 3. Data Access Layer
```csharp
using Ustilz.Data;
public class UserRepository : ABaseAccessLayer<User>
{
    public UserRepository(DbContext context) : base(context) { }
}
```

### 4. API Responses
```csharp
using Ustilz.Api;
return ApiResponseBody<User>.Ok(user);
return ApiResponseBody<User>.NotFound("User not found");
```

### 5. Testable Time
```csharp
using Ustilz.Time;
Clock.SetFunctionNow(() => new DateTime(2025, 1, 1));
var now = Clock.Now; // Returns mocked date
```

### 6. CSV Parsing
```csharp
using Ustilz.Parsers;
public class Person
{
    [CsvColumn("Name")]
    public string Name { get; set; }

    [CsvColumnDateTime("BirthDate", "yyyy-MM-dd")]
    public DateTime BirthDate { get; set; }
}
```

### 7. State Machine
```csharp
using Ustilz.StateMachine;
var sm = new StatesManager<MyState, MyObject>();
await sm.ChangeStateAsync(obj, MyState.Active);
```

## Building and Testing

### Build
```bash
dotnet build Ustilz.sln
```

### Run Tests
```bash
dotnet test
```

### Run Benchmarks
```bash
cd benchmarks/Ustilz.Benchmark.Parsers
dotnet run -c Release
```

## NuGet Packages

Main packages published:
- Ustilz.Extensions
- Ustilz.Data
- Ustilz.Json
- Ustilz.Utils
- Ustilz.Xml
- Ustilz.Logging
- Ustilz.Time

## Contributing

When working on this codebase:

1. **Extension Methods:** Use modern C# 14 extension syntax
2. **Null Safety:** Enable nullable reference types
3. **Testing:** Add unit tests for new features
4. **Documentation:** Update `/docs` with new components
5. **Benchmarks:** Add performance benchmarks for critical paths

## Git Workflow

- **Main Branch:** `develop` (use for PRs)
- **Current Branch:** `master`
- **Status:** Clean working directory

## CI/CD

- Azure DevOps pipeline
- GitHub Actions workflow
- Automatic NuGet package publishing

## Code Quality

- Codacy integration for code quality checks
- Build status badges in README
- NuGet download tracking

## Additional Resources

- [GitHub Repository](https://github.com/avondero/Ustilz)
- [NuGet Packages](https://www.nuget.org/packages?q=Ustilz)
- Azure DevOps Build Pipeline
