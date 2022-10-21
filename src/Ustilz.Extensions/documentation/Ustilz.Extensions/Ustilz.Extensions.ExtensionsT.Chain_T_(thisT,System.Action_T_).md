#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsT](Ustilz.Extensions.ExtensionsT.md 'Ustilz.Extensions.ExtensionsT')

## ExtensionsT.Chain<T>(this T, Action<T>) Method

Executes the action specified, which the given object as parameter.

```csharp
public static T Chain<T>(this T chainObject, System.Action<T?> action);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).T'></a>

`T`

The type of the object.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).chainObject'></a>

`chainObject` [T](Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).md#Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).T 'Ustilz.Extensions.ExtensionsT.Chain<T>(this T, System.Action<T>).T')

The object to act on.

<a name='Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).md#Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).T 'Ustilz.Extensions.ExtensionsT.Chain<T>(this T, System.Action<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

The action.

#### Returns
[T](Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).md#Ustilz.Extensions.ExtensionsT.Chain_T_(thisT,System.Action_T_).T 'Ustilz.Extensions.ExtensionsT.Chain<T>(this T, System.Action<T>).T')  
Returns the given object.

#### Exceptions

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
A delegate callback throws an exception.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The action can not be null.

### Remarks
Use this method to chain method calls on the same object.