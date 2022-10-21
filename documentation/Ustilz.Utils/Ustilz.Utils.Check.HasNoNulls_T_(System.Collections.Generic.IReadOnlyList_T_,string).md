### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Check](Ustilz.Utils.Check.md 'Ustilz.Utils.Check')

## Check.HasNoNulls<T>(IReadOnlyList<T>, string) Method

The has no nulls.

```csharp
public static System.Collections.Generic.IReadOnlyList<T?> HasNoNulls<T>(System.Collections.Generic.IReadOnlyList<T?> collection, string parameterName)
    where T : class;
```
#### Type parameters

<a name='Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).T'></a>

`T`

Type de la valeur à tester.
#### Parameters

<a name='Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).collection'></a>

`collection` [System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[T](Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).T 'Ustilz.Utils.Check.HasNoNulls<T>(System.Collections.Generic.IReadOnlyList<T>, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')

The value.

<a name='Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The parameter name.

#### Returns
[System.Collections.Generic.IReadOnlyList&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')[T](Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).T 'Ustilz.Utils.Check.HasNoNulls<T>(System.Collections.Generic.IReadOnlyList<T>, string).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyList-1 'System.Collections.Generic.IReadOnlyList`1')  
The IReadOnlyList.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[collection](Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).collection 'Ustilz.Utils.Check.HasNoNulls<T>(System.Collections.Generic.IReadOnlyList<T>, string).collection') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[parameterName](Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).md#Ustilz.Utils.Check.HasNoNulls_T_(System.Collections.Generic.IReadOnlyList_T_,string).parameterName 'Ustilz.Utils.Check.HasNoNulls<T>(System.Collections.Generic.IReadOnlyList<T>, string).parameterName') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Collection has null.