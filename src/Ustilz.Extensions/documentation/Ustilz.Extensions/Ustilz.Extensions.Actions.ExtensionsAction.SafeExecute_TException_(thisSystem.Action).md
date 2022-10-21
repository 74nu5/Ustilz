#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.SafeExecute<TException>(this Action) Method

Executes the given action inside of a try catch block. Catches exceptions of the given type.

```csharp
public static bool SafeExecute<TException>(this System.Action action)
    where TException : System.Exception;
```
#### Type parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute_TException_(thisSystem.Action).TException'></a>

`TException`

The type of the exception.
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute_TException_(thisSystem.Action).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if the action was executed without an exception, otherwise false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Action can not be null.