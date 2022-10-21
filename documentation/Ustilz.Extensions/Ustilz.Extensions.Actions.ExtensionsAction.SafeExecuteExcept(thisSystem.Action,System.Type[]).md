#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.SafeExecuteExcept(this Action, Type[]) Method

Executes the given action inside of a try catch block and catches all exception expect the given ones.

```csharp
public static bool SafeExecuteExcept(this System.Action action, params System.Type[] exceptionsToThrow);
```
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecuteExcept(thisSystem.Action,System.Type[]).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecuteExcept(thisSystem.Action,System.Type[]).exceptionsToThrow'></a>

`exceptionsToThrow` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The exceptions to throw.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if the action was executed without an exception, otherwise false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Action can not be null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
ExceptionsToThrow can not be null.