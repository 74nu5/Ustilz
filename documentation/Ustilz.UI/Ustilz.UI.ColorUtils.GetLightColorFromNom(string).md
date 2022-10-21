### [Ustilz.UI](Ustilz.UI.md 'Ustilz.UI').[ColorUtils](Ustilz.UI.ColorUtils.md 'Ustilz.UI.ColorUtils')

## ColorUtils.GetLightColorFromNom(string) Method

The get color from nom.

```csharp
public static string GetLightColorFromNom(string nom);
```
#### Parameters

<a name='Ustilz.UI.ColorUtils.GetLightColorFromNom(string).nom'></a>

`nom` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The nom.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[nom](Ustilz.UI.ColorUtils.GetLightColorFromNom(string).md#Ustilz.UI.ColorUtils.GetLightColorFromNom(string).nom 'Ustilz.UI.ColorUtils.GetLightColorFromNom(string).nom') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
value does not comply with the input pattern specified by style.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
style is not a [System.Globalization.NumberStyles](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles 'System.Globalization.NumberStyles') value. -or- style includes the  
[System.Globalization.NumberStyles.AllowHexSpecifier](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles.AllowHexSpecifier 'System.Globalization.NumberStyles.AllowHexSpecifier') or [System.Globalization.NumberStyles.HexNumber](https://docs.microsoft.com/en-us/dotnet/api/System.Globalization.NumberStyles.HexNumber 'System.Globalization.NumberStyles.HexNumber') flag along with another value.