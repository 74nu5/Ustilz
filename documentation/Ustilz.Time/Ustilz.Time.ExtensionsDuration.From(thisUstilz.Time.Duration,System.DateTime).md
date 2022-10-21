### [Ustilz.Time](Ustilz.Time.md 'Ustilz.Time').[ExtensionsDuration](Ustilz.Time.ExtensionsDuration.md 'Ustilz.Time.ExtensionsDuration')

## ExtensionsDuration.From(this Duration, DateTime) Method

Méthode calcul de projection d'une date.

```csharp
public static System.DateTime From(this Ustilz.Time.Duration duration, System.DateTime dateTime);
```
#### Parameters

<a name='Ustilz.Time.ExtensionsDuration.From(thisUstilz.Time.Duration,System.DateTime).duration'></a>

`duration` [Duration](Ustilz.Time.Duration.md 'Ustilz.Time.Duration')

Durée de la projection.

<a name='Ustilz.Time.ExtensionsDuration.From(thisUstilz.Time.Duration,System.DateTime).dateTime'></a>

`dateTime` [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')

Date à partir de laquelle la projection est faite.

#### Returns
[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')  
Retourne la date projétée.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The resulting [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime') is less than [System.DateTime.MinValue](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.MinValue 'System.DateTime.MinValue') or greater than  
[System.DateTime.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.MaxValue 'System.DateTime.MaxValue').