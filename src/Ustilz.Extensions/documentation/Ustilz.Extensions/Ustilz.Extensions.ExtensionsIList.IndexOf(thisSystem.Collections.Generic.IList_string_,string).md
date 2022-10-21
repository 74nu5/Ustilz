#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsIList](Ustilz.Extensions.ExtensionsIList.md 'Ustilz.Extensions.ExtensionsIList')

## ExtensionsIList.IndexOf(this IList<string>, string) Method

The index of.

```csharp
internal static int IndexOf(this System.Collections.Generic.IList<string> tab, string value);
```
#### Parameters

<a name='Ustilz.Extensions.ExtensionsIList.IndexOf(thisSystem.Collections.Generic.IList_string_,string).tab'></a>

`tab` [System.Collections.Generic.IList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1')

The tab.

<a name='Ustilz.Extensions.ExtensionsIList.IndexOf(thisSystem.Collections.Generic.IList_string_,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

#### Returns
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
The [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
index is not a valid index in the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1').

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The property is set and the [System.Collections.Generic.IList&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1 'System.Collections.Generic.IList`1') is read-only.