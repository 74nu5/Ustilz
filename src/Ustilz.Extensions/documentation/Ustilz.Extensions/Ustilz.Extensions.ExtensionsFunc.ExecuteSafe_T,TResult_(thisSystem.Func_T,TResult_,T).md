#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.ExecuteSafe<T,TResult>(this Func<T,TResult>, T) Method

Exécute la fonction donnée avec la valeur comme paramètre et gère toutes les exceptions pendant l'exécution.

```csharp
public static Ustilz.Extensions.Models.IExecutionResult<TResult> ExecuteSafe<T,TResult>(this System.Func<T,TResult> func, T parameter)
    where TResult : new();
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).T'></a>

`T`

Le type du paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).TResult'></a>

`TResult`

Le type du résultat.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).T 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T,TResult>(this System.Func<T,TResult>, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).TResult 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T,TResult>(this System.Func<T,TResult>, T).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

La fonction à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).parameter'></a>

`parameter` [T](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).T 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T,TResult>(this System.Func<T,TResult>, T).T')

Le paramètre de la fonction.

#### Returns
[Ustilz.Extensions.Models.IExecutionResult&lt;](Ustilz.Extensions.Models.IExecutionResult_T_.md 'Ustilz.Extensions.Models.IExecutionResult<T>')[TResult](Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).md#Ustilz.Extensions.ExtensionsFunc.ExecuteSafe_T,TResult_(thisSystem.Func_T,TResult_,T).TResult 'Ustilz.Extensions.ExtensionsFunc.ExecuteSafe<T,TResult>(this System.Func<T,TResult>, T).TResult')[&gt;](Ustilz.Extensions.Models.IExecutionResult_T_.md 'Ustilz.Extensions.Models.IExecutionResult<T>')  
Renvoie le résultat de la fonction ou une exception si une est survenue.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
La fonction ne peut pas être nulle.