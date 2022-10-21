#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.TestPerf<TResult>(this Func<TResult>, long) Method

Méthode de test de performance.

```csharp
public static TResult TestPerf<TResult>(this System.Func<TResult> function, out long timestamp);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).TResult'></a>

`TResult`

Le type du résultat.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).function'></a>

`function` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<TResult>(this System.Func<TResult>, long).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1 'System.Func`1')

La fonction à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).timestamp'></a>

`timestamp` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Retourne le temps d'exécution de la méthode en millisecondes.

#### Returns
[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_TResult_(thisSystem.Func_TResult_,long).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<TResult>(this System.Func<TResult>, long).TResult')  
La valeur de retour.