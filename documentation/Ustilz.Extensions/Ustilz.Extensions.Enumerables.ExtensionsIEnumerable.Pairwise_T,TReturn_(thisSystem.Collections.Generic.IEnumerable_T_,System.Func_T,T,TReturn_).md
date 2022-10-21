#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.Pairwise<T,TReturn>(this IEnumerable<T>, Func<T,T,TReturn>) Method

Méthode de traitement des éléments d'une liste deux à deux.

```csharp
public static System.Collections.Generic.IEnumerable<TReturn> Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T> source, System.Func<T,T,TReturn> selector);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).T'></a>

`T`

Type des éléments de la liste.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).TReturn'></a>

`TReturn`

Type du retour du calcul des éléments deux à deux.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).source'></a>

`source` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,T,TReturn>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Liste source.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).selector'></a>

`selector` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,T,TReturn>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,T,TReturn>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TReturn](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).TReturn 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,T,TReturn>).TReturn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Méthode de calcul des éléments deux à deux.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TReturn](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise_T,TReturn_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,T,TReturn_).TReturn 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Pairwise<T,TReturn>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,T,TReturn>).TReturn')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Retourne une liste contenant les résultat des calcul des éléments deux à deux.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Lève une exception si un des arguments est null.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Lève une exception si la liste est vide.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Lève une exception si la liste contient moins de deux éléménts.