#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.TestPerf<T,TResult>(this Func<T,TResult>, long, T) Method

Méthode de test de performance.

```csharp
public static TResult TestPerf<T,TResult>(this System.Func<T,TResult> function, out long timestamp, T param);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).T'></a>

`T`

Le type du paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).TResult'></a>

`TResult`

Le type du retour de la fonction.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).function'></a>

`function` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[T](Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).T 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T,TResult>(this System.Func<T,TResult>, long, T).T')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T,TResult>(this System.Func<T,TResult>, long, T).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2 'System.Func`2')

La fonction à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).timestamp'></a>

`timestamp` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Retourne le temps d'exécution de la méthode en millisecondes.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).param'></a>

`param` [T](Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).T 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T,TResult>(this System.Func<T,TResult>, long, T).T')

Le paramètre de la fonction.

#### Returns
[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T,TResult_(thisSystem.Func_T,TResult_,long,T).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T,TResult>(this System.Func<T,TResult>, long, T).TResult')  
La valeur de retour.