#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerActionProvider](Ustilz.Logging.Action.LoggerActionProvider.md 'Ustilz.Logging.Action.LoggerActionProvider')

## LoggerActionProvider.CreateLogger(string) Method

Méthode de création du logger.

```csharp
public Microsoft.Extensions.Logging.ILogger CreateLogger(string categoryName);
```
#### Parameters

<a name='Ustilz.Logging.Action.LoggerActionProvider.CreateLogger(string).categoryName'></a>

`categoryName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Nom de la catégorie du logger.

Implements [CreateLogger(string)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILoggerProvider.CreateLogger#Microsoft_Extensions_Logging_ILoggerProvider_CreateLogger_System_String_ 'Microsoft.Extensions.Logging.ILoggerProvider.CreateLogger(System.String)')

#### Returns
[Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')  
Retourne le logger.

#### Exceptions

[System.OverflowException](https://docs.microsoft.com/en-us/dotnet/api/System.OverflowException 'System.OverflowException')  
The dictionary already contains the maximum number of elements ([System.Int32.MaxValue](https://docs.microsoft.com/en-us/dotnet/api/System.Int32.MaxValue 'System.Int32.MaxValue')).

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
key or valueFactory is null.