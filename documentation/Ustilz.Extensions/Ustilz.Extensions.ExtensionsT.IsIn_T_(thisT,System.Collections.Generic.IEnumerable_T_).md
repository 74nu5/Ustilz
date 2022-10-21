#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsT](Ustilz.Extensions.ExtensionsT.md 'Ustilz.Extensions.ExtensionsT')

## ExtensionsT.IsIn<T>(this T, IEnumerable<T>) Method

Vérifie si la valeur est présente dans le IEnumerable donné.

```csharp
public static bool IsIn<T>(this T value, System.Collections.Generic.IEnumerable<T?> values);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).T'></a>

`T`

Le type de la valeur.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).value'></a>

`value` [T](Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).md#Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).T 'Ustilz.Extensions.ExtensionsT.IsIn<T>(this T, System.Collections.Generic.IEnumerable<T>).T')

La valeur à rechercher.

<a name='Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).values'></a>

`values` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).md#Ustilz.Extensions.ExtensionsT.IsIn_T_(thisT,System.Collections.Generic.IEnumerable_T_).T 'Ustilz.Extensions.ExtensionsT.IsIn<T>(this T, System.Collections.Generic.IEnumerable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Un IEnumerable contenant les valeurs.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Retourne true si la valeur est présente dans le IEnumerable, false sinon.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Les valeurs ne peuvent pas être nulles.