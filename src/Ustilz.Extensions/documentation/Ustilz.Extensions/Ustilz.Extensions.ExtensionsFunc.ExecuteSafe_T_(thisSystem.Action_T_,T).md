#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.ExecuteSafe<T>(this Action<T>, T) Method

Exécute l'action donnée avec la valeur comme paramètre et gère toutes les exceptions pendant l'exécution.

```csharp
public static Ustilz.Extensions.Models.IExecutionResult<T> ExecuteSafe<T>(this System.Action<T> action, T parameter)
    where T : new();
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).T'></a>

`T`

Le type du paramètre.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).T 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T>(this System.Action<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

L'action à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).parameter'></a>

`parameter` [T](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).T 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T>(this System.Action<T>, T).T')

Paramètre de l'action, celui-ci est retourné après l'exécution dans la propriété [Result](Ustilz.Extensions.Models.ExecutionResult_T_.Result.md 'Ustilz.Extensions.Models.ExecutionResult<T>.Result').

#### Returns
[Ustilz.Extensions.Models.IExecutionResult&lt;](Ustilz.Extensions.Models.IExecutionResult_T_.md 'Ustilz.Extensions.Models.IExecutionResult<T>')[T](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T_(thisSystem.Action_T_,T).T 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T>(this System.Action<T>, T).T')[&gt;](Ustilz.Extensions.Models.IExecutionResult_T_.md 'Ustilz.Extensions.Models.IExecutionResult<T>')  
Renvoie la valeur donnée en tant que résultat ou exception si une est survenue.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
L'action ne peut pas être nulle.

[System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception')  
A delegate callback throws an exception.