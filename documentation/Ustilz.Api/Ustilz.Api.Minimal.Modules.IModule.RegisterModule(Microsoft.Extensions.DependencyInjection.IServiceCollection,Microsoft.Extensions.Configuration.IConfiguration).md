#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.Minimal.Modules](Ustilz.Api.Minimal.Modules.md 'Ustilz.Api.Minimal.Modules').[IModule](Ustilz.Api.Minimal.Modules.IModule.md 'Ustilz.Api.Minimal.Modules.IModule')

## IModule.RegisterModule(IServiceCollection, IConfiguration) Method

Registers the module depedencies.

```csharp
void RegisterModule(Microsoft.Extensions.DependencyInjection.IServiceCollection services, Microsoft.Extensions.Configuration.IConfiguration configuration);
```
#### Parameters

<a name='Ustilz.Api.Minimal.Modules.IModule.RegisterModule(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection.

<a name='Ustilz.Api.Minimal.Modules.IModule.RegisterModule(Microsoft.Extensions.DependencyInjection.IServiceCollection,Microsoft.Extensions.Configuration.IConfiguration).configuration'></a>

`configuration` [Microsoft.Extensions.Configuration.IConfiguration](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfiguration 'Microsoft.Extensions.Configuration.IConfiguration')

The configuration service manager.