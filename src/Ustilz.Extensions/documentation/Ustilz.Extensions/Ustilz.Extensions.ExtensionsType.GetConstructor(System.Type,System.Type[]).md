#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsType](Ustilz.Extensions.ExtensionsType.md 'Ustilz.Extensions.ExtensionsType')

## ExtensionsType.GetConstructor(Type, Type[]) Method

The get constructor.

```csharp
private static System.Reflection.ConstructorInfo GetConstructor(System.Type type, params System.Type[] argumentTypes);
```
#### Parameters

<a name='Ustilz.Extensions.ExtensionsType.GetConstructor(System.Type,System.Type[]).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

<a name='Ustilz.Extensions.ExtensionsType.GetConstructor(System.Type,System.Type[]).argumentTypes'></a>

`argumentTypes` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The argument types.

#### Returns
[System.Reflection.ConstructorInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ConstructorInfo 'System.Reflection.ConstructorInfo')  
The [System.Reflection.ConstructorInfo](https://docs.microsoft.com/en-us/dotnet/api/System.Reflection.ConstructorInfo 'System.Reflection.ConstructorInfo').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Lève une exception lorsque le constructeur n'existe pas.