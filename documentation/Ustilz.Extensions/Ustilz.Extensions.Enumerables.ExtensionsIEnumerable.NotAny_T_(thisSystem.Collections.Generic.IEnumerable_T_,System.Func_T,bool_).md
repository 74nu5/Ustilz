#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.NotAny<T>(this IEnumerable<T>, Func<T,bool>) Method

Determines whether the given IEnumerable contains no items matching the given predicate, or not.

```csharp
public static bool NotAny<T>(this System.Collections.Generic.IEnumerable<T> enumerable, System.Func<T,bool> predicate);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T'></a>

`T`

The type of the items in the IEnumerable.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The IEnumerable to check.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).predicate'></a>

`predicate` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Func_T,bool_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny<T>(this System.Collections.Generic.IEnumerable<T>, System.Func<T,bool>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

The predicate.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if the IEnumerable doesn't contain any items, otherwise false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The enumerable can not be null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The predicate can not be null.