#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Int32](Ustilz.Extensions.Int32.md 'Ustilz.Extensions.Int32').[ExtensionsInt32](Ustilz.Extensions.Int32.ExtensionsInt32.md 'Ustilz.Extensions.Int32.ExtensionsInt32')

## ExtensionsInt32.PercentOf(this int, double) Method

Gets the percentage of the number.

```csharp
public static double PercentOf(this int number, double total);
```
#### Parameters

<a name='Ustilz.Extensions.Int32.ExtensionsInt32.PercentOf(thisint,double).number'></a>

`number` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

The number.

<a name='Ustilz.Extensions.Int32.ExtensionsInt32.PercentOf(thisint,double).total'></a>

`total` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The total value.

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
Returns the percentage of the number.

#### Exceptions

[System.DivideByZeroException](https://docs.microsoft.com/en-us/dotnet/api/System.DivideByZeroException 'System.DivideByZeroException')  
The number must be greater than zero.