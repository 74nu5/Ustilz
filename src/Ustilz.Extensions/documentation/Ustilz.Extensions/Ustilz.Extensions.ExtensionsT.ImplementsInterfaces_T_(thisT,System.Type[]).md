#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsT](Ustilz.Extensions.ExtensionsT.md 'Ustilz.Extensions.ExtensionsT')

## ExtensionsT.ImplementsInterfaces<T>(this T, Type[]) Method

Détermine si un objet de classe implémente un type d'interface et renvoie une liste des types qu'il implémente réellement. Si aucun type correspondant n'est trouvé, une  
liste vide sera renvoyée.

```csharp
public static System.Collections.Generic.List<System.Type?> ImplementsInterfaces<T>(this T obj, params System.Type[] interfaces);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsT.ImplementsInterfaces_T_(thisT,System.Type[]).T'></a>

`T`

Type de l'objet à tester.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsT.ImplementsInterfaces_T_(thisT,System.Type[]).obj'></a>

`obj` [T](Ustilz.Extensions.ExtensionsT.ImplementsInterfaces_T_(thisT,System.Type[]).md#Ustilz.Extensions.ExtensionsT.ImplementsInterfaces_T_(thisT,System.Type[]).T 'Ustilz.Extensions.ExtensionsT.ImplementsInterfaces<T>(this T, System.Type[]).T')

Objet à tester.

<a name='Ustilz.Extensions.ExtensionsT.ImplementsInterfaces_T_(thisT,System.Type[]).interfaces'></a>

`interfaces` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Liste des interfaces à tester.

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
Retourne la liste des interfaces implémenter par l'objet.