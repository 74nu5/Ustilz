#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.Minimal.Modules](Ustilz.Api.Minimal.Modules.md 'Ustilz.Api.Minimal.Modules').[ModuleExtension](Ustilz.Api.Minimal.Modules.ModuleExtension.md 'Ustilz.Api.Minimal.Modules.ModuleExtension')

## ModuleExtension.RegisterModulesServices(this IServiceCollection) Method

Registers all modules of this project that implements <seealso cref="T:Ustilz.Api.Minimal.Modules.IModule"/>.

```csharp
public static Microsoft.Extensions.DependencyInjection.IServiceCollection RegisterModulesServices(this Microsoft.Extensions.DependencyInjection.IServiceCollection services);
```
#### Parameters

<a name='Ustilz.Api.Minimal.Modules.ModuleExtension.RegisterModulesServices(thisMicrosoft.Extensions.DependencyInjection.IServiceCollection).services'></a>

`services` [Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')

The service collection

#### Returns
[Microsoft.Extensions.DependencyInjection.IServiceCollection](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.DependencyInjection.IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection')  
Returns the service collection