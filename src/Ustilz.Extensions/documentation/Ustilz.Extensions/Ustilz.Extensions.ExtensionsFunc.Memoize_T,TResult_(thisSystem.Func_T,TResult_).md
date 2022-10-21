#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.Memoize<T,TResult>(this Func<T,TResult>) Method

Méthode de mémoïsation d'une fonction.

```csharp
public static System.Func<T,TResult> Memoize<T,TResult>(this System.Func<T,TResult> func)
    where T : notnull;
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).T'></a>

`T`

Type du paramètres d'entrée.

<a name='Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).TResult'></a>

`TResult`

Type du retour.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).md#Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).T 'Ustilz.Extensions.ExtensionsFunc.Memoize<T,TResult>(this System.Func<T,TResult>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).md#Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).TResult 'Ustilz.Extensions.ExtensionsFunc.Memoize<T,TResult>(this System.Func<T,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

Fonction à mémoïser.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).md#Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).T 'Ustilz.Extensions.ExtensionsFunc.Memoize<T,TResult>(this System.Func<T,TResult>).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).md#Ustilz.Extensions.ExtensionsFunc.Memoize_T,TResult_(thisSystem.Func_T,TResult_).TResult 'Ustilz.Extensions.ExtensionsFunc.Memoize<T,TResult>(this System.Func<T,TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')  
Retourne une fonction [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2').