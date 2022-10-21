#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.Minimal.Modules](Ustilz.Api.Minimal.Modules.md 'Ustilz.Api.Minimal.Modules')

## IModule Interface

Defines methods to be implemented by a module.

```csharp
public interface IModule
```

| Methods | |
| :--- | :--- |
| [ConfigureModule(IServiceProvider)](Ustilz.Api.Minimal.Modules.IModule.ConfigureModule(System.IServiceProvider).md 'Ustilz.Api.Minimal.Modules.IModule.ConfigureModule(System.IServiceProvider)') | Configure module dependencies once service provider has been built. |
| [MapEndpoints(IEndpointRouteBuilder)](Ustilz.Api.Minimal.Modules.IModule.MapEndpoints(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder).md 'Ustilz.Api.Minimal.Modules.IModule.MapEndpoints(Microsoft.AspNetCore.Routing.IEndpointRouteBuilder)') | Maps incoming requests to the specified services types declared by the module. |
| [RegisterModule(IServiceCollection, IConfiguration)](Ustilz.Api.Minimal.Modules.IModule.RegisterModule(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).md 'Ustilz.Api.Minimal.Modules.IModule.RegisterModule(Microsoft.Extensions.DependencyInjection.IServiceCollection, Microsoft.Extensions.Configuration.IConfiguration)') | Registers the module depedencies. |
