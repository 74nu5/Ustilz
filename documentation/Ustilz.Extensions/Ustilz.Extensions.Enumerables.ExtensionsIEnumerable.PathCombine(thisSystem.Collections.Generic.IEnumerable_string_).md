#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Enumerables](Ustilz.Extensions.Enumerables.md 'Ustilz.Extensions.Enumerables').[ExtensionsIEnumerable](Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.md 'Ustilz.Extensions.Enumerables.ExtensionsIEnumerable')

## ExtensionsIEnumerable.PathCombine(this IEnumerable<string>) Method

Returns a path combined out of the items in the given IEnumerable.

```csharp
public static string PathCombine(this System.Collections.Generic.IEnumerable<string> enumerable);
```
#### Parameters

<a name='Ustilz.Extensions.Enumerables.ExtensionsIEnumerable.PathCombine(thisSystem.Collections.Generic.IEnumerable_string_).enumerable'></a>

`enumerable` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

The IEnumerable to act on.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The combined path.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The enumerable can not be null.