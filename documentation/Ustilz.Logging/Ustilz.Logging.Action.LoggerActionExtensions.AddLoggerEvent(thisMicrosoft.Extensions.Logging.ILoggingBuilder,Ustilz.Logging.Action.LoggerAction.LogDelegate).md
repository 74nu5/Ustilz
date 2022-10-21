#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerActionExtensions](Ustilz.Logging.Action.LoggerActionExtensions.md 'Ustilz.Logging.Action.LoggerActionExtensions')

## LoggerActionExtensions.AddLoggerEvent(this ILoggingBuilder, LogDelegate) Method

Méthode d'ajout du logger d'action au services du builder.

```csharp
public static Microsoft.Extensions.Logging.ILoggingBuilder AddLoggerEvent(this Microsoft.Extensions.Logging.ILoggingBuilder builder, Ustilz.Logging.Action.LoggerAction.LogDelegate action);
```
#### Parameters

<a name='Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(thisMicrosoft.Extensions.Logging.ILoggingBuilder,Ustilz.Logging.Action.LoggerAction.LogDelegate).builder'></a>

`builder` [Microsoft.Extensions.Logging.ILoggingBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILoggingBuilder 'Microsoft.Extensions.Logging.ILoggingBuilder')

Builder de log de l'application.

<a name='Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(thisMicrosoft.Extensions.Logging.ILoggingBuilder,Ustilz.Logging.Action.LoggerAction.LogDelegate).action'></a>

`action` [LogDelegate(string, LogLevel, EventId, Exception, string)](Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).md 'Ustilz.Logging.Action.LoggerAction.LogDelegate(string, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, string)')

Action à effectuer.

#### Returns
[Microsoft.Extensions.Logging.ILoggingBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILoggingBuilder 'Microsoft.Extensions.Logging.ILoggingBuilder')  
Retourne le builder de logger.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[builder](Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(thisMicrosoft.Extensions.Logging.ILoggingBuilder,Ustilz.Logging.Action.LoggerAction.LogDelegate).md#Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(thisMicrosoft.Extensions.Logging.ILoggingBuilder,Ustilz.Logging.Action.LoggerAction.LogDelegate).builder 'Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(this Microsoft.Extensions.Logging.ILoggingBuilder, Ustilz.Logging.Action.LoggerAction.LogDelegate).builder') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[action](Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(thisMicrosoft.Extensions.Logging.ILoggingBuilder,Ustilz.Logging.Action.LoggerAction.LogDelegate).md#Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(thisMicrosoft.Extensions.Logging.ILoggingBuilder,Ustilz.Logging.Action.LoggerAction.LogDelegate).action 'Ustilz.Logging.Action.LoggerActionExtensions.AddLoggerEvent(this Microsoft.Extensions.Logging.ILoggingBuilder, Ustilz.Logging.Action.LoggerAction.LogDelegate).action') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').