### [Ustilz.Time](Ustilz.Time.md 'Ustilz.Time').[ExtensionsDateTime](Ustilz.Time.ExtensionsDateTime.md 'Ustilz.Time.ExtensionsDateTime')

## ExtensionsDateTime.AgeFrom(this DateTime, Nullable<DateTime>) Method

Calcule la différence entre l'année de la date et l'heure actuelles.

```csharp
public static (int YearAge,int MonthAge,int DayAge) AgeFrom(this System.DateTime startDay, System.Nullable<System.DateTime> day=null);
```
#### Parameters

<a name='Ustilz.Time.ExtensionsDateTime.AgeFrom(thisSystem.DateTime,System.Nullable_System.DateTime_).startDay'></a>

`startDay` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

Date à laquelle l'age est calculé.

<a name='Ustilz.Time.ExtensionsDateTime.AgeFrom(thisSystem.DateTime,System.Nullable_System.DateTime_).day'></a>

`day` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

Date depuis l'age est calculé.

#### Returns
[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')  
La différence entre l'année de la date courante et celle de la date.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Birthday date must be earlier than current date.

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
month is less than 1 or greater than 12. -or- year is less than 1 or greater than 9999.

[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')  
value equals [System.Int32.MinValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MinValue 'System.Int32.MinValue').