#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.ExecuteIfFalse<T>(this Action<T>, T, Action<T>, Func<bool>[]) Method

Executes the specified action if the given Boolean values are false,  
otherwise it executes the specified true action, if one is specified.

```csharp
public static void ExecuteIfFalse<T>(this System.Action<T>? falseAction, T parameter, System.Action<T>? trueAction=null, params System.Func<bool>[] values);
```
#### Type parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).T'></a>

`T`

The type of the parameter.
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).falseAction'></a>

`falseAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).T 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse<T>(this System.Action<T>, T, System.Action<T>, System.Func<bool>[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action to execute if the given values are false.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).parameter'></a>

`parameter` [T](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).T 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse<T>(this System.Action<T>, T, System.Action<T>, System.Func<bool>[]).T')

The parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).trueAction'></a>

`trueAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).T 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse<T>(this System.Action<T>, T, System.Action<T>, System.Func<bool>[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action to execute if any of the given values is true.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfFalse_T_(thisSystem.Action_T_,T,System.Action_T_,System.Func_bool_[]).values'></a>

`values` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The Boolean values to check.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
FalseAction can not be null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Values can not be null.