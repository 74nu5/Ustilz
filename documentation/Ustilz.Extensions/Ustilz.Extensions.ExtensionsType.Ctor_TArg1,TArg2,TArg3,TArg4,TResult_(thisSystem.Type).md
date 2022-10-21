#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsType](Ustilz.Extensions.ExtensionsType.md 'Ustilz.Extensions.ExtensionsType')

## ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this Type) Method

The ctor.

```csharp
public static System.Func<TArg1,TArg2,TArg3,TArg4,TResult> Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type type);
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg1'></a>

`TArg1`

Type du premier argument.

<a name='Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg2'></a>

`TArg2`

Type du deuxième argument.

<a name='Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg3'></a>

`TArg3`

Type du troisième argument.

<a name='Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg4'></a>

`TArg4`

Type du quatrième argument.

<a name='Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TResult'></a>

`TResult`

Type du résultat.
#### Parameters

<a name='Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).type'></a>

`type` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The type.

#### Returns
[System.Func&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TArg1](Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).md#Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg1 'Ustilz.Extensions.ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type).TArg1')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TArg2](Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).md#Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg2 'Ustilz.Extensions.ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type).TArg2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TArg3](Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).md#Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg3 'Ustilz.Extensions.ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type).TArg3')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TArg4](Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).md#Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TArg4 'Ustilz.Extensions.ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type).TArg4')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')[TResult](Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).md#Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).TResult 'Ustilz.Extensions.ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type).TResult')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5')  
The [System.Func&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Func-5 'System.Func`5').

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Lève une exception lorsque le constructeur n'existe pas.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
constructor is null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[type](Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).md#Ustilz.Extensions.ExtensionsType.Ctor_TArg1,TArg2,TArg3,TArg4,TResult_(thisSystem.Type).type 'Ustilz.Extensions.ExtensionsType.Ctor<TArg1,TArg2,TArg3,TArg4,TResult>(this System.Type).type') is null.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
TDelegate is not a delegate type. -or- body.Type represents a type that is not assignable to the return type of TDelegate. -or- parameters does  
not contain the same number of elements as the list of parameters for TDelegate. -or- The [System.Linq.Expressions.Expression.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Linq.Expressions.Expression.Type 'System.Linq.Expressions.Expression.Type') property of an element of  
parameters is not assignable from the type of the corresponding parameter type of TDelegate.