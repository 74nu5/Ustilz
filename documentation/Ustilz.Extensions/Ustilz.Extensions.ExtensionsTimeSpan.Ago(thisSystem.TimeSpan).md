#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsTimeSpan](Ustilz.Extensions.ExtensionsTimeSpan.md 'Ustilz.Extensions.ExtensionsTimeSpan')

## ExtensionsTimeSpan.Ago(this TimeSpan) Method

Renvoie un DateTime dont la valeur est définie sur Now moins la valeur TimeSpan fournie.

```csharp
public static System.DateTime Ago(this System.TimeSpan value);
```
#### Parameters

<a name='Ustilz.Extensions.ExtensionsTimeSpan.Ago(thisSystem.TimeSpan).value'></a>

`value` [System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')

Durée fournie.

#### Returns
[System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime')  
The [System.DateTime](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime 'System.DateTime').

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
The result is less than [System.DateTime.MinValue](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.MinValue 'System.DateTime.MinValue') or greater than [System.DateTime.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.DateTime.MaxValue 'System.DateTime.MaxValue').