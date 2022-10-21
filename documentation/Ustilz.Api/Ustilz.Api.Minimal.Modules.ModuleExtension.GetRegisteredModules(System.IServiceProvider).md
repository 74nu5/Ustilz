#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.Minimal.Modules](Ustilz.Api.Minimal.Modules.md 'Ustilz.Api.Minimal.Modules').[ModuleExtension](Ustilz.Api.Minimal.Modules.ModuleExtension.md 'Ustilz.Api.Minimal.Modules.ModuleExtension')

## ModuleExtension.GetRegisteredModules(IServiceProvider) Method

Returns all modules instances.

```csharp
private static System.Collections.Generic.IEnumerable<Ustilz.Api.Minimal.Modules.IModule> GetRegisteredModules(System.IServiceProvider provider);
```
#### Parameters

<a name='Ustilz.Api.Minimal.Modules.ModuleExtension.GetRegisteredModules(System.IServiceProvider).provider'></a>

`provider` [System.IServiceProvider](https://docs.microsoft.com/en-us/dotnet/api/System.IServiceProvider 'System.IServiceProvider')

The service provider.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[IModule](Ustilz.Api.Minimal.Modules.IModule.md 'Ustilz.Api.Minimal.Modules.IModule')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Return a collection of <seealso cref="T:Ustilz.Api.Minimal.Modules.IModule"/> instances.