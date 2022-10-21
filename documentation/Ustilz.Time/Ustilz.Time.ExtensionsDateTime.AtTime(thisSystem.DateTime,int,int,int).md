### [Ustilz.Time](Ustilz.Time.md 'Ustilz.Time').[ExtensionsDateTime](Ustilz.Time.ExtensionsDateTime.md 'Ustilz.Time.ExtensionsDateTime')

## ExtensionsDateTime.AtTime(this DateTime, int, int, int) Method

Défini l'heure, les minutes et les secondes pour une date donnée.

```csharp
public static System.DateTime AtTime(this System.DateTime date, int hours, int minutes, int seconds);
```
#### Parameters

<a name='Ustilz.Time.ExtensionsDateTime.AtTime(thisSystem.DateTime,int,int,int).date'></a>

`date` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

Date à modifier.

<a name='Ustilz.Time.ExtensionsDateTime.AtTime(thisSystem.DateTime,int,int,int).hours'></a>

`hours` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Heure à définir.

<a name='Ustilz.Time.ExtensionsDateTime.AtTime(thisSystem.DateTime,int,int,int).minutes'></a>

`minutes` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Minutes à définir.

<a name='Ustilz.Time.ExtensionsDateTime.AtTime(thisSystem.DateTime,int,int,int).seconds'></a>

`seconds` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Secondes à définir.

#### Returns
[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')  
Retourne la date avec l'heure définie.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
year is less than 1 or greater than 9999. -or- month is less than 1 or greater than 12. -or- day is less than 1 or greater than the  
number of days in month. -or- hour is less than 0 or greater than 23. -or- minute is less than 0 or greater than 59. -or- second is less than 0 or greater than 59.