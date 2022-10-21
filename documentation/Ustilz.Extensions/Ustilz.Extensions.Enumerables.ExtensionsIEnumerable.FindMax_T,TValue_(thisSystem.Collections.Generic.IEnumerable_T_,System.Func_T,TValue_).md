#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.FindMax<T,TValue>(this IEnumerable<T>, Func<T,TValue>) Method

Méthode de récupération de l'élément de la liste pour lequel le sélecteur renvoie la valeur maximale.

```csharp
public static T? FindMax<T,TValue>(this System.Collections.Generic.IEnumerable<T> list, System.Func<T,TValue> selector)
    where TValue : System.IComparable<TValue>;
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).T'></a>

`T`

Type des éléments de la liste.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).TValue'></a>

`TValue`

Type de la valeur à comparer. Celui-ci doit implémenter [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1').
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).list'></a>

`list` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax<T,TValue>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,TValue>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Liste dans laquelle la recherche est effectuée.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).selector'></a>

`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax<T,TValue>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,TValue>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TValue](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).TValue 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax<T,TValue>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,TValue>).TValue')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Selecteur de comparaison.

#### Returns
[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax_T,TValue_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,TValue_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.FindMax<T,TValue>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,TValue>).T')  
Retourne de l'élément de la liste pour lequel le sélecteur renvoie la valeur maximale.