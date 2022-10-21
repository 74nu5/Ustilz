#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.WithIndex<T>(this IEnumerable<T>) Method

Méthode récupération d'une énumération avec index.

```csharp
public static System.Collections.Generic.IEnumerable<(T Item,int Index)> WithIndex<T>(this System.Collections.Generic.IEnumerable<T> enumerable);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

Type de la liste.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex<T>(this System.Collections.Generic.IEnumerable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumérable à traiter.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.WithIndex<T>(this System.Collections.Generic.IEnumerable<T>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Retourne un énumarable contenant des [System.Tuple](https://docs.microsoft.com/en-us/dotnet/api/System.Tuple 'System.Tuple'), représentant un couple (item, index0).