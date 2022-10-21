#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.NotAny<T>(this IEnumerable<T>) Method

Determines whether the given IEnumerable contains no items, or not.

```csharp
public static bool NotAny<T>(this System.Collections.Generic.IEnumerable<T?> enumerable);
```
#### Type parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_).T'></a>

`T`

The type of the items in the IEnumerable.
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[T](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_).md#Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny_T_(thisSystem.Collections.Generic.IEnumerable_T_).T 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.NotAny<T>(this System.Collections.Generic.IEnumerable<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The IEnumerable to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if the IEnumerable doesn't contain any items, otherwise false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The enumerable can not be null.