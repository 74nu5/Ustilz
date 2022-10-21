#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.SafeExecute(this Action, Type[]) Method

Executes the given action inside of a try catch block. Catches all exception types contained in the given list of  
exception types.

```csharp
public static bool SafeExecute(this System.Action action, params System.Type[] exceptionsToCatch);
```
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute(thisSystem.Action,System.Type[]).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute(thisSystem.Action,System.Type[]).exceptionsToCatch'></a>

`exceptionsToCatch` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

A list of exception types to catch.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if the action was executed without an exception, otherwise false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Action can not be null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
ExceptionsToCatch can not be null.