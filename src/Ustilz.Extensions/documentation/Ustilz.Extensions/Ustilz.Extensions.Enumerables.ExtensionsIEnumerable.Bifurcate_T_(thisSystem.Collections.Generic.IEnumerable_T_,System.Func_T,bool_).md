#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.Bifurcate<T>(this IEnumerable<T>, Func<T,bool>) Method

Méthode qui split une liste à partir d'un prédicat.

```csharp
public static (System.Collections.Generic.IEnumerable<T> FilteredTrue,System.Collections.Generic.IEnumerable<T> FilteredFalse) Bifurcate<T>(this System.Collections.Generic.IEnumerable<T> items, System.Func<T,bool> filter);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T'></a>

`T`

Type de la liste.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).items'></a>

`items` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Liste à spliter.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).filter'></a>

`filter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Prédicat à appliquer.

#### Returns
[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Bifurcate<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')  
Retourne un tuple contenant les deux listes.