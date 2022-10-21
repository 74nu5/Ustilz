#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.Bifurcate<T>(this IEnumerable<T>, IList<bool>) Method

Méthode qui split une liste à partir d'un tableau de booléen.

```csharp
public static (System.Collections.Generic.IEnumerable<T> FilteredTrue,System.Collections.Generic.IEnumerable<T> FilteredFalse) Bifurcate<T>(this System.Collections.Generic.IEnumerable<T> items, System.Collections.Generic.IList<bool> filter);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).T'></a>

`T`

Type de la liste.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Liste à spliter.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).filter'></a>

`filter` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

Filtre à appliquer.

#### Returns
[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Collections.Generic.IList_bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')  
Retourne un tuple contenant les deux listes.