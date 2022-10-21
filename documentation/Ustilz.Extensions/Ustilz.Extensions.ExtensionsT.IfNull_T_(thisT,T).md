#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsT](Ustilz.Extensions.ExtensionsT.md 'Ustilz.Extensions.ExtensionsT')

## ExtensionsT.IfNull<T>(this T, T) Method

Méthode de test du nullité d'une valeur, si la valeur est nulle la méthode renvoie la valeur par défaut renseignée.

```csharp
public static T IfNull<T>(this T? source, T defaultValue)
    where T : class;
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).T'></a>

`T`

Type de l'objet.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).source'></a>

`source` [T](Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).md#Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).T 'Ustilz.Extensions.ExtensionsT.IfNull<T>(this T, T).T')

La valeur à tester.

<a name='Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).defaultValue'></a>

`defaultValue` [T](Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).md#Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).T 'Ustilz.Extensions.ExtensionsT.IfNull<T>(this T, T).T')

La valeur par défaut.

#### Returns
[T](Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).md#Ustilz.Extensions.ExtensionsT.IfNull_T_(thisT,T).T 'Ustilz.Extensions.ExtensionsT.IfNull<T>(this T, T).T')  
Retourne l'objet passé en entrée, la valeur par défaut si celle-ci est nulle.