#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4) Method

Méthode de test de performance.

```csharp
public static TResult TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult> function, out long timestamp, T1 param1, T2 param2, T3 param3, T4 param4);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T1'></a>

`T1`

Le type du premier paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T2'></a>

`T2`

Le type du second paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T3'></a>

`T3`

Le type du troisième paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T4'></a>

`T4`

Le type du quatrième paramètre.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).TResult'></a>

`TResult`

Le type du retour de la fonction.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).function'></a>

`function` [System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T1](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T1 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T2](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T2 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T3](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T3 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[T4](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T4 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')

La fonction à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).timestamp'></a>

`timestamp` [System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')

Retourne le temps d'exécution de la méthode en millisecondes.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).param1'></a>

`param1` [T1](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T1 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T1')

Le premier paramètre de la fonction.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).param2'></a>

`param2` [T2](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T2 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T2')

Le second paramètre de la fonction.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).param3'></a>

`param3` [T3](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T3 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T3')

Le troisième paramètre de la fonction.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).param4'></a>

`param4` [T4](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).T4 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).T4')

Le quatrième paramètre de la fonction.

#### Returns
[TResult](Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T1,T2,T3,T4,TResult_(thisSystem.Func_T1,T2,T3,T4,TResult_,long,T1,T2,T3,T4).TResult 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T1,T2,T3,T4,TResult>(this System.Func<T1,T2,T3,T4,TResult>, long, T1, T2, T3, T4).TResult')  
La valeur de retour.