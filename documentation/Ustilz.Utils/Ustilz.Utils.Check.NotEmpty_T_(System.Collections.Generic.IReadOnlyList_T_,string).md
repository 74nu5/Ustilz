### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Check](Ustilz.Utils.Check.md 'Ustilz.Utils.Check')

## Check.NotEmpty<T>(IReadOnlyList<T>, string) Method

The not empty.

```csharp
public static System.Collections.Generic.IReadOnlyList<T?> NotEmpty<T>(System.Collections.Generic.IReadOnlyList<T?> value, string parameterName);
```
#### Type parameters

<a name='Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).T'></a>

`T`

Type de la valeur à tester.
#### Parameters

<a name='Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).value'></a>

`value` [System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[T](Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).T 'Ustilz.Utils.Check.NotEmpty<T>(System.Collections.Generic.IReadOnlyList<T>, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')

The value.

<a name='Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The parameter name.

#### Returns
[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[T](Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).T 'Ustilz.Utils.Check.NotEmpty<T>(System.Collections.Generic.IReadOnlyList<T>, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')  
The IReadOnlyList.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[value](Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).value 'Ustilz.Utils.Check.NotEmpty<T>(System.Collections.Generic.IReadOnlyList<T>, string).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[parameterName](Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.NotEmpty_T_(System.Collections.Generic.IReadOnlyList_T_,string).parameterName 'Ustilz.Utils.Check.NotEmpty<T>(System.Collections.Generic.IReadOnlyList<T>, string).parameterName') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Collection is empty.