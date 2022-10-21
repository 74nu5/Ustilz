#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction')

## LoggerAction.LogDelegate(string, LogLevel, EventId, Exception, string) Delegate

Délégué représentant l'action à effectuer lors du log.

```csharp
public delegate void LoggerAction.LogDelegate(string categoryName, Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, System.Exception exception, string message);
```
#### Parameters

<a name='Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).categoryName'></a>

`categoryName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Nom de la catégorie du log.

<a name='Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).logLevel'></a>

`logLevel` [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel')

Niveau de log.

<a name='Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).eventId'></a>

`eventId` [Microsoft.Extensions.Logging.EventId](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.EventId 'Microsoft.Extensions.Logging.EventId')

Identifiant de l'évènement.

<a name='Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

Exception levée, null s'il n'y en a pas.

<a name='Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).message'></a>

`message` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Message à loguer.