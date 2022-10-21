### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Check](Ustilz.Utils.Check.md 'Ustilz.Utils.Check')

## Check.NotEmpty(string, string) Method

The not empty.

```csharp
public static string NotEmpty(string value, string parameterName);
```
#### Parameters

<a name='Ustilz.Utils.Check.NotEmpty(string,string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The value.

<a name='Ustilz.Utils.Check.NotEmpty(string,string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The parameter name.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[value](Ustilz.Utils.Check.NotEmpty(string,string).md#Ustilz.Utils.Check.NotEmpty(string,string).value 'Ustilz.Utils.Check.NotEmpty(string, string).value') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Value is empty.