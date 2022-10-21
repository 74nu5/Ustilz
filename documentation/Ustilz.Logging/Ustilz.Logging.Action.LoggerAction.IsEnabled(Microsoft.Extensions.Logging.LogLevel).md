#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction')

## LoggerAction.IsEnabled(LogLevel) Method

Checks if the given [logLevel](Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).md#Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).logLevel 'Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).logLevel') is enabled.

```csharp
public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel);
```
#### Parameters

<a name='Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).logLevel'></a>

`logLevel` [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel')

Level to be checked.

Implements [IsEnabled(LogLevel)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger.IsEnabled#Microsoft_Extensions_Logging_ILogger_IsEnabled_Microsoft_Extensions_Logging_LogLevel_ 'Microsoft.Extensions.Logging.ILogger.IsEnabled(Microsoft.Extensions.Logging.LogLevel)')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
`true` if enabled.