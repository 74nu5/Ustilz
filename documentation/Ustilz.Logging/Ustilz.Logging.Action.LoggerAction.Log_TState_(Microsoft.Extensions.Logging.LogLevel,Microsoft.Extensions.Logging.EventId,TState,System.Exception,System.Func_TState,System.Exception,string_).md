#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction')

## LoggerAction.Log<TState>(LogLevel, EventId, TState, Exception, Func<TState,Exception,string>) Method

Writes a log entry.

```csharp
public void Log<TState>(Microsoft.Extensions.Logging.LogLevel logLevel, Microsoft.Extensions.Logging.EventId eventId, TState state, System.Exception exception, System.Func<TState,System.Exception,string> formatter);
```
#### Type parameters

<a name='Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).TState'></a>

`TState`

The type of the object to be written.
#### Parameters

<a name='Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).logLevel'></a>

`logLevel` [Microsoft.Extensions.Logging.LogLevel](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.LogLevel 'Microsoft.Extensions.Logging.LogLevel')

Entry will be written on this level.

<a name='Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).eventId'></a>

`eventId` [Microsoft.Extensions.Logging.EventId](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.EventId 'Microsoft.Extensions.Logging.EventId')

Id of the event.

<a name='Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).state'></a>

`state` [TState](Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).md#Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).TState 'Ustilz.Logging.Action.LoggerAction.Log<TState>(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, TState, System.Exception, System.Func<TState,System.Exception,string>).TState')

The entry to be written. Can be also an object.

<a name='Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).exception'></a>

`exception` [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')

The exception related to this entry.

<a name='Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).formatter'></a>

`formatter` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[TState](Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).md#Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).TState 'Ustilz.Logging.Action.LoggerAction.Log<TState>(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, TState, System.Exception, System.Func<TState,System.Exception,string>).TState')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3 'System.Func`3')

Function to create a [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String') message of the [state](Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).md#Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).state 'Ustilz.Logging.Action.LoggerAction.Log<TState>(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, TState, System.Exception, System.Func<TState,System.Exception,string>).state') and [exception](Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).md#Ustilz.Logging.Action.LoggerAction.Log_TState_(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,TState,System.Exception,System.Func_TState,System.Exception,string_).exception 'Ustilz.Logging.Action.LoggerAction.Log<TState>(Microsoft.Extensions.Logging.LogLevel, Microsoft.Extensions.Logging.EventId, TState, System.Exception, System.Func<TState,System.Exception,string>).exception').

Implements [Log&lt;TState&gt;(LogLevel, EventId, TState, Exception, Func&lt;TState,Exception,string&gt;)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger.Log--1#Microsoft_Extensions_Logging_ILogger_Log__1_Microsoft_Extensions_Logging_LogLevel,Microsoft_Extensions_Logging_EventId,__0,System_Exception,System_Func{__0,System_Exception,System_String}_ 'Microsoft.Extensions.Logging.ILogger.Log``1(Microsoft.Extensions.Logging.LogLevel,Microsoft.Extensions.Logging.EventId,``0,System.Exception,System.Func{``0,System.Exception,System.String})')