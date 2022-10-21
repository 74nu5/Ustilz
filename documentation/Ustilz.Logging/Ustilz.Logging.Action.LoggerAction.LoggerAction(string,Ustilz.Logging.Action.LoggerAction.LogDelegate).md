#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction')

## LoggerAction(string, LogDelegate) Constructor

Initialise une nouvelle instance de la classe [LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction').

```csharp
internal LoggerAction(string categoryName, Ustilz.Logging.Action.LoggerAction.LogDelegate action);
```
#### Parameters

<a name='Ustilz.Logging.Action.LoggerAction.LoggerAction(string,Ustilz.Logging.Action.LoggerAction.LogDelegate).categoryName'></a>

`categoryName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Catégorie du log.

<a name='Ustilz.Logging.Action.LoggerAction.LoggerAction(string,Ustilz.Logging.Action.LoggerAction.LogDelegate).action'></a>

`action` [LogDelegate(string, LogLevel, EventId, Exception, string)](Ustilz.Logging.Action.LoggerAction.LogDelegate(string,Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,System.Exception,string).md 'Ustilz.Logging.Action.LoggerAction.LogDelegate(string, Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, System.Exception, string)')

Action à effectuer lors du log.