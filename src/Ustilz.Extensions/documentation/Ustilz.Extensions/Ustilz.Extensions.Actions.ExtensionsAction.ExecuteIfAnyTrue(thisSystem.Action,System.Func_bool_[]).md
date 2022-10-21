#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.ExecuteIfAnyTrue(this Action, Func<bool>[]) Method

Executes the specified action if one of the given Boolean values is true.

```csharp
public static void ExecuteIfAnyTrue(this System.Action? trueAction, params System.Func<bool>[] values);
```
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue(thisSystem.Action,System.Func_bool_[]).trueAction'></a>

`trueAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute if one of the values is true.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue(thisSystem.Action,System.Func_bool_[]).values'></a>

`values` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The Boolean values to check.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
True action can not be null, if any value is true.