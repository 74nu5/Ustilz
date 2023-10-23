#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this Action<T1,T2>, T1, T2, Action<T1,T2>, Func<bool>[]) Method

Executes the specified action if one of the given Boolean values is true, otherwise it executes the specified false action, if one is specified.

```csharp
public static void ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>? trueAction, T1 parameter1, T2 parameter2, System.Action<T1,T2>? falseAction=null, params System.Func<bool>[] values);
```
#### Type parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T1'></a>

`T1`

The type of the first parameter.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T2'></a>

`T2`

The type of the second parameter.
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).trueAction'></a>

`trueAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T1](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T1 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>, T1, T2, System.Action<T1,T2>, System.Func<bool>[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T2](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T2 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>, T1, T2, System.Action<T1,T2>, System.Func<bool>[]).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

The action to execute if one of the values is true.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).parameter1'></a>

`parameter1` [T1](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T1 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>, T1, T2, System.Action<T1,T2>, System.Func<bool>[]).T1')

The first parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).parameter2'></a>

`parameter2` [T2](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T2 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>, T1, T2, System.Action<T1,T2>, System.Func<bool>[]).T2')

The second parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).falseAction'></a>

`falseAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T1](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T1 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>, T1, T2, System.Action<T1,T2>, System.Func<bool>[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')[T2](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).T2 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue<T1,T2>(this System.Action<T1,T2>, T1, T2, System.Action<T1,T2>, System.Func<bool>[]).T2')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2 'System.Action`2')

The action to execute if any of the given values is false.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfAnyTrue_T1,T2_(thisSystem.Action_T1,T2_,T1,T2,System.Action_T1,T2_,System.Func_bool_[]).values'></a>

`values` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The Boolean values to check.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
True action can not be null, if any value is true.