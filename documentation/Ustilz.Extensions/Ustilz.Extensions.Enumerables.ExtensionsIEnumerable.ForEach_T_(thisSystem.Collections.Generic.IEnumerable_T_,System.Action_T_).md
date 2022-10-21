#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.ForEach<T>(this IEnumerable<T>, Action<T>) Method

Enumerate each element in the enumeration and execute specified action.

```csharp
public static void ForEach<T>(this System.Collections.Generic.IEnumerable<T> enumerable, System.Action<T> action);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T'></a>

`T`

Type of enumeration.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumerable collection.

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach_T_(thisSystem.Collections.Generic.IEnumerable_T_,System.Action_T_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.ForEach<T>(this System.Collections.Generic.IEnumerable<T>, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

Action to perform.