#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.SafeExecute<TException1,TException2,TException3>(this Action) Method

Executes the given action inside of a try catch block. Catches exceptions of the given types.

```csharp
public static bool SafeExecute<TException1,TException2,TException3>(this System.Action action)
    where TException1 : System.Exception
    where TException2 : System.Exception
    where TException3 : System.Exception;
```
#### Type parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute_TException1,TException2,TException3_(thisSystem.Action).TException1'></a>

`TException1`

The first exception type to catch.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute_TException1,TException2,TException3_(thisSystem.Action).TException2'></a>

`TException2`

The second exception type to catch.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute_TException1,TException2,TException3_(thisSystem.Action).TException3'></a>

`TException3`

The third exception type to catch.
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.SafeExecute_TException1,TException2,TException3_(thisSystem.Action).action'></a>

`action` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if the action was executed without an exception, otherwise false.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Action can not be null.