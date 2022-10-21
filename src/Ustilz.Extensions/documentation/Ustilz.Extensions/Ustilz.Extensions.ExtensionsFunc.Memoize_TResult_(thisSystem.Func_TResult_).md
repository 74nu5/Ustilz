#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.Memoize<TResult>(this Func<TResult>) Method

Méthode de mémoïsation d'une fonction.

```csharp
public static System.Func<TResult> Memoize<TResult>(this System.Func<TResult> func);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.Memoize_TResult_(thisSystem.Func_TResult_).TResult'></a>

`TResult`

Type du retour.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.Memoize_TResult_(thisSystem.Func_TResult_).func'></a>

`func` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](Ustilz.Extensions.ExtensionsFunc.Memoize_TResult_(thisSystem.Func_TResult_).md#Ustilz.Extensions.ExtensionsFunc.Memoize_TResult_(thisSystem.Func_TResult_).TResult 'Ustilz.Extensions.ExtensionsFunc.Memoize<TResult>(this System.Func<TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

Fonction à mémoïser.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](Ustilz.Extensions.ExtensionsFunc.Memoize_TResult_(thisSystem.Func_TResult_).md#Ustilz.Extensions.ExtensionsFunc.Memoize_TResult_(thisSystem.Func_TResult_).TResult 'Ustilz.Extensions.ExtensionsFunc.Memoize<TResult>(this System.Func<TResult>).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')  
Retourne une fonction [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2').