#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Actions](Ustilz.Extensions.Actions.md 'Ustilz.Extensions.Actions').[ExtensionsAction](Ustilz.Extensions.Actions.ExtensionsAction.md 'Ustilz.Extensions.Actions.ExtensionsAction')

## ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this Action<T1,T2,T3,T4>, T1, T2, T3, T4, Func<bool>[]) Method

Executes the specified action if the given Boolean values are true.

```csharp
public static void ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4> trueAction, T1 parameter1, T2 parameter2, T3 parameter3, T4 parameter4, params System.Func<bool>[] values);
```
#### Type parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T1'></a>

`T1`

The type of the first parameter.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T2'></a>

`T2`

The type of the second parameter.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T3'></a>

`T3`

The type of the third parameter.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T4'></a>

`T4`

The type of the fourth parameter.
#### Parameters

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).trueAction'></a>

`trueAction` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4 'System.Action`4')[T1](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T1 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4 'System.Action`4')[T2](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T2 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4 'System.Action`4')[T3](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T3 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4 'System.Action`4')[T4](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T4 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T4')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4 'System.Action`4')

The action to execute if the given values are true.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).parameter1'></a>

`parameter1` [T1](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T1 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T1')

The first parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).parameter2'></a>

`parameter2` [T2](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T2 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T2')

The second parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).parameter3'></a>

`parameter3` [T3](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T3 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T3')

The third parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).parameter4'></a>

`parameter4` [T4](Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).md#Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).T4 'Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue<T1,T2,T3,T4>(this System.Action<T1,T2,T3,T4>, T1, T2, T3, T4, System.Func<bool>[]).T4')

The fourth parameter to pass to the action with gets executed.

<a name='Ustilz.Extensions.Actions.ExtensionsAction.ExecuteIfTrue_T1,T2,T3,T4_(thisSystem.Action_T1,T2,T3,T4_,T1,T2,T3,T4,System.Func_bool_[]).values'></a>

`values` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The Boolean values to check.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
TrueAction can not be null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Values can not be null.