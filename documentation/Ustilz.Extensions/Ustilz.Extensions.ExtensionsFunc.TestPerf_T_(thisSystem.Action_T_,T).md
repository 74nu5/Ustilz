#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsFunc](Ustilz.Extensions.ExtensionsFunc.md 'Ustilz.Extensions.ExtensionsFunc')

## ExtensionsFunc.TestPerf<T>(this Action<T>, T) Method

Méthode de test de performance.

```csharp
public static long TestPerf<T>(this System.Action<T> action, T param);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).T'></a>

`T`

Le type du paramètre.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).action'></a>

`action` [System.Action&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')[T](Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).T 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T>(this System.Action<T>, T).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1 'System.Action`1')

L'action à exécuter.

<a name='Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).param'></a>

`param` [T](Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).md#Ustilz.Extensions.ExtensionsFunc.TestPerf_T_(thisSystem.Action_T_,T).T 'Ustilz.Extensions.ExtensionsFunc.TestPerf<T>(this System.Action<T>, T).T')

Le paramètre de l'action.

#### Returns
[System.Int64](https://docs.microsoft.com/en-us/dotnet/api/System.Int64 'System.Int64')  
Retourne le temps d'exécution de la méthode en millisecondes.