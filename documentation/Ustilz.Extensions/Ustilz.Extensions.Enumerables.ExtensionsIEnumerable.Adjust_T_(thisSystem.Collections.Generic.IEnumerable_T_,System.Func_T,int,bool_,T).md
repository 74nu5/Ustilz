#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.Adjust<T>(this IEnumerable<T>, Func<T,int,bool>, T) Method

Méthode permettant d'ajuster des éléments d'un [System.Collections.Generic.IEnumerable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1').

```csharp
public static System.Collections.Generic.IEnumerable<T> Adjust<T>(this System.Collections.Generic.IEnumerable<T> enumerable, System.Func<T,int,bool> shouldReplace, T replacement);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).T'></a>

`T`

Type d'élément de l'énumérable.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,int,bool>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumérable à ajuster.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).shouldReplace'></a>

`shouldReplace` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,int,bool>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Condition de d'ajustement.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).replacement'></a>

`replacement` [T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,int,bool>, T).T')

Valeur de remplacement.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,int,bool_,T).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.Adjust<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,int,bool>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Retourne la liste initiale avec les ajustements.