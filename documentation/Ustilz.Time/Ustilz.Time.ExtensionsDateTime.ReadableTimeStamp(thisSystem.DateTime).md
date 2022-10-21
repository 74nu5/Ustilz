### [Ustilz.Time](Ustilz.Time.md 'Ustilz.Time').[ExtensionsDateTime](Ustilz.Time.ExtensionsDateTime.md 'Ustilz.Time.ExtensionsDateTime')

## ExtensionsDateTime.ReadableTimeStamp(this DateTime) Method

The readable time stamp.

```csharp
public static string ReadableTimeStamp(this System.DateTime currentDate);
```
#### Parameters

<a name='Ustilz.Time.ExtensionsDateTime.ReadableTimeStamp(thisSystem.DateTime).currentDate'></a>

`currentDate` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

The current date.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')  
value is greater than [System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue') or less than [System.Int32.MinValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MinValue 'System.Int32.MinValue').