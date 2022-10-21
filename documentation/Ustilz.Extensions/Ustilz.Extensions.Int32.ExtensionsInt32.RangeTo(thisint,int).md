#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Int32](Ustilz.Extensions.Int32.md 'Ustilz.Extensions.Int32').[ExtensionsInt32](Ustilz.Extensions.Int32.ExtensionsInt32.md 'Ustilz.Extensions.Int32.ExtensionsInt32')

## ExtensionsInt32.RangeTo(this int, int) Method

Returns a list containing all values of the given range.

```csharp
public static System.Collections.Generic.IEnumerable<int> RangeTo(this int startValue, int endValue);
```
#### Parameters

<a name='Ustilz.Extensions.Int32.ExtensionsInt32.RangeTo(thisint,int).startValue'></a>

`startValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The start of the range.

<a name='Ustilz.Extensions.Int32.ExtensionsInt32.RangeTo(thisint,int).endValue'></a>

`endValue` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The end of the range.

#### Returns
[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')  
Returns a list containing the specified range.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
The start value can not be greater than the end value.