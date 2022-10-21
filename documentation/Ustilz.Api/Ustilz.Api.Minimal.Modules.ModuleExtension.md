#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.Minimal.Modules](Ustilz.Api.Minimal.Modules.md 'Ustilz.Api.Minimal.Modules')

## ModuleExtension Class

Provides extension methods to work with <seealso cref="T:Ustilz.Api.Minimal.Modules.IModule"/>.

```csharp
public static class ModuleExtension
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ModuleExtension

| Methods | |
| :--- | :--- |
| [DiscoverModules(Assembly)](Ustilz.Api.Minimal.Modules.ModuleExtension.DiscoverModules(System.Reflection.Assembly).md 'Ustilz.Api.Minimal.Modules.ModuleExtension.DiscoverModules(System.Reflection.Assembly)') | Returns the collection of modules declared in this project. |
| [GetRegisteredModules(IServiceProvider)](Ustilz.Api.Minimal.Modules.ModuleExtension.GetRegisteredModules(System.IServiceProvider).md 'Ustilz.Api.Minimal.Modules.ModuleExtension.GetRegisteredModules(System.IServiceProvider)') | Returns all modules instances. |
| [MapModulesEndpoints(this IEndpointRouteBuilder)](Ustilz.Api.Minimal.Modules.ModuleExtension.MapModulesEndpoints(thisMicrosoft.AspNetCore.Routing.IEndpointRouteBuilder).md 'Ustilz.Api.Minimal.Modules.ModuleExtension.MapModulesEndpoints(this Microsoft.AspNetCore.Routing.IEndpointRouteBuilder)') | Adds route endpoints for all modules. |
| [RegisterModulesDependencies(this IServiceCollection)](Ustilz.Api.Minimal.Modules.ModuleExtension.RegisterModulesDependencies(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).md 'Ustilz.Api.Minimal.Modules.ModuleExtension.RegisterModulesDependencies(this Microsoft.Extensions.DependencyInjection.IServiceCollection)') | Registers all modules dependencies. |
| [RegisterModulesServices(this IServiceCollection)](Ustilz.Api.Minimal.Modules.ModuleExtension.RegisterModulesServices(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).md 'Ustilz.Api.Minimal.Modules.ModuleExtension.RegisterModulesServices(this Microsoft.Extensions.DependencyInjection.IServiceCollection)') | Registers all modules of this project that implements <seealso cref="T:Ustilz.Api.Minimal.Modules.IModule"/>. |
