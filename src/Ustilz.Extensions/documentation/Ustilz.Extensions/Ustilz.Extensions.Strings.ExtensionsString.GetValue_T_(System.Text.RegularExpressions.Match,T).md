#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Strings](Ustilz.Extensions.Strings.md 'Ustilz.Extensions.Strings').[ExtensionsString](Ustilz.Extensions.Strings.ExtensionsString.md 'Ustilz.Extensions.Strings.ExtensionsString')

## ExtensionsString.GetValue<T>(Match, T) Method

The get value.

```csharp
private static string GetValue<T>(System.Text.RegularExpressions.Match match, T data);
```
#### Type parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.GetValue_T_(System.Text.RegularExpressions.Match,T).T'></a>

`T`

Type à inspecter.
#### Parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.GetValue_T_(System.Text.RegularExpressions.Match,T).match'></a>

`match` [System.Text.RegularExpressions.Match](https://docs.microsoft.com/en-us/dotnet/api/System.Text.RegularExpressions.Match 'System.Text.RegularExpressions.Match')

The match.

<a name='Ustilz.Extensions.Strings.ExtensionsString.GetValue_T_(System.Text.RegularExpressions.Match,T).data'></a>

`data` [T](Ustilz.Extensions.Strings.ExtensionsString.GetValue_T_(System.Text.RegularExpressions.Match,T).md#Ustilz.Extensions.Strings.ExtensionsString.GetValue_T_(System.Text.RegularExpressions.Match,T).T 'Ustilz.Extensions.Strings.ExtensionsString.GetValue<T>(System.Text.RegularExpressions.Match, T).T')

The data.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Lève une exception lorsque la propriété et/ou la valeur n'est pas trouvé.