#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this Func<T1,T2,T3,TResult>, long, T1, T2, T3) Method

Méthode de test de performance.

```csharp
public static TResult TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult> function, out long timestamp, T1 param1, T2 param2, T3 param3);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T1'></a>

`T1`

Le type du premier paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T2'></a>

`T2`

Le type du second paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T3'></a>

`T3`

Le type du troisième paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).TResult'></a>

`TResult`

Le type du retour de la fonction.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).function'></a>

`function` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T1](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T1 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T2](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T2 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[T3](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T3 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4 'System.Func`4')

La fonction à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).timestamp'></a>

`timestamp` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Retourne le temps d'exécution de la méthode en millisecondes.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).param1'></a>

`param1` [T1](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T1 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).T1')

Le premier paramètre de la fonction.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).param2'></a>

`param2` [T2](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T2 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).T2')

Le second paramètre de la fonction.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).param3'></a>

`param3` [T3](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).T3 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).T3')

Le troisième paramètre de la fonction.

#### Returns
[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,TResult_(thisSystem.Func_T1,T2,T3,TResult_,long,T1,T2,T3).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,TResult>(this System.Func<T1,T2,T3,TResult>, long, T1, T2, T3).TResult')  
La valeur de retour.