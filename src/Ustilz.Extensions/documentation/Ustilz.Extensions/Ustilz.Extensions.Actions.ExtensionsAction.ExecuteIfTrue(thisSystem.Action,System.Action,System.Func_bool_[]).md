#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.ExecuteIfTrue(this Action, Action, Func<bool>[]) Method

Executes the specified action if the given Boolean values are true,  
otherwise it executes the specified false action, if one is specified.

```csharp
public static void ExecuteIfTrue(this System.Action trueAction, System.Action? falseAction=null, params System.Func<bool>[] values);
```
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue(thisSystem.Action,System.Action,System.Func_bool_[]).trueAction'></a>

`trueAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute if the given values are true.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue(thisSystem.Action,System.Action,System.Func_bool_[]).falseAction'></a>

`falseAction` [System.Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action 'System.Action')

The action to execute if any of the given values is false.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue(thisSystem.Action,System.Action,System.Func_bool_[]).values'></a>

`values` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The Boolean values to check.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
TrueAction can not be null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Values can not be null.