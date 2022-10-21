#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsT](Ustilz.Extensions.ExtensionsT.md 'Ustilz.Extensions.ExtensionsT')

## ExtensionsT.IsNotNull<T>(this T) Method

Détermine si l'objet n'est pas nul.

```csharp
public static bool IsNotNull<T>(this T? source)
    where T : class;
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsT.IsNotNull_T_(thisT).T'></a>

`T`

Type de l'objet.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsT.IsNotNull_T_(thisT).source'></a>

`source` [T](Ustilz.Extensions.ExtensionsT.IsNotNull_T_(thisT).md#Ustilz.Extensions.ExtensionsT.IsNotNull_T_(thisT).T 'Ustilz.Extensions.ExtensionsT.IsNotNull<T>(this T).T')

L'objet à tester.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Retourne true si l'objet n'est pas null, false sinon.