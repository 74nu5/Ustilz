#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action')

## LoggerAction Class

Classe du logger d'action.

```csharp
public sealed class LoggerAction :
Microsoft.Extensions.Logging.ILogger
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; LoggerAction

Implements [Microsoft.Extensions.Logging.ILogger](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger 'Microsoft.Extensions.Logging.ILogger')

| Constructors | |
| :--- | :--- |
| [LoggerAction(string, LogDelegate)](Ustilz.Logging.Action.LoggerAction.LoggerAction(string,Ustilz.Logging.Action.LoggerAction.LogDelegate).md 'Ustilz.Logging.Action.LoggerAction.LoggerAction(string, Ustilz.Logging.Action.LoggerAction.LogDelegate)') | Initialise une nouvelle instance de la classe [LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction'). |

| Methods | |
| :--- | :--- |
| [BeginScope&lt;TState&gt;(TState)](Ustilz.Logging.Action.LoggerAction.BeginScope_TState_(TState).md 'Ustilz.Logging.Action.LoggerAction.BeginScope<TState>(TState)') | Begins a logical operation scope. |
| [IsEnabled(LogLevel)](Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).md 'Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel)') | Checks if the given [logLevel](Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).md#Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).logLevel 'Ustilz.Logging.Action.LoggerAction.IsEnabled(Microsoft.Extensions.Logging.LogLevel).logLevel') is enabled. |
| [Log&lt;TState&gt;(LogLevel, EventId, TState, Exception, Func&lt;TState,Exception,string&gt;)](Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).md 'Ustilz.Logging.Action.LoggerAction.Log<TState>(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, TState, System.Exception, System.Func<TState,System.Exception,string>)') | Writes a log entry. |
