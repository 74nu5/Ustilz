#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsT](Ustilz.Extensions.ExtensionsT.md 'Ustilz.Extensions.ExtensionsT')

## ExtensionsT.IsIn<T>(this T, T[]) Method

Vérifie si la valeur est présente dans le tableau donné.

```csharp
public static bool IsIn<T>(this T value, params T[] values);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).T'></a>

`T`

Le type de la valeur.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).value'></a>

`value` [T](Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).md#Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).T 'Ustilz.Extensions.ExtensionsT.IsIn<T>(this T, T[]).T')

La valeur à rechercher.

<a name='Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).values'></a>

`values` [T](Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).md#Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,T[]).T 'Ustilz.Extensions.ExtensionsT.IsIn<T>(this T, T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Un tableau contenant les valeurs.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Renvoie true si la valeur est présente dans le tableau, false sinon.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Les valeurs ne peuvent pas être nulles.