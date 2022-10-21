#### [Ustilz.Logging](index.md 'index')
### [Ustilz.Logging.Action](Ustilz.Logging.Action.md 'Ustilz.Logging.Action').[LoggerAction](Ustilz.Logging.Action.LoggerAction.md 'Ustilz.Logging.Action.LoggerAction')

## LoggerAction.BeginScope<TState>(TState) Method

Begins a logical operation scope.

```csharp
public System.IDisposable? BeginScope<TState>(TState state);
```
#### Type parameters

<a name='Ustilz.Logging.Action.LoggerAction.BeginScope_TState_(TState).TState'></a>

`TState`

The type of the state to begin scope for.
#### Parameters

<a name='Ustilz.Logging.Action.LoggerAction.BeginScope_TState_(TState).state'></a>

`state` [TState](Ustilz.Logging.Action.LoggerAction.BeginScope_TState_(TState).md#Ustilz.Logging.Action.LoggerAction.BeginScope_TState_(TState).TState 'Ustilz.Logging.Action.LoggerAction.BeginScope<TState>(TState).TState')

The identifier for the scope.

Implements [BeginScope&lt;TState&gt;(TState)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Logging.ILogger.BeginScope--1#Microsoft_Extensions_Logging_ILogger_BeginScope__1___0_ 'Microsoft.Extensions.Logging.ILogger.BeginScope``1(``0)')

#### Returns
[System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable')  
An [System.IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable 'System.IDisposable') that ends the logical operation scope on dispose.