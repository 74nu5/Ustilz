#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsEnum](Ustilz.Extensions.ExtensionsEnum.md 'Ustilz.Extensions.ExtensionsEnum')

## ExtensionsEnum.GetDescriptionDictionary<T>() Method

To the description dictionary.

```csharp
public static System.Collections.Generic.Dictionary<string,string?> GetDescriptionDictionary<T>()
    where T : System.Enum;
```
#### Type parameters

<a name='Ustilz.Extensions.ExtensionsEnum.GetDescriptionDictionary_T_().T'></a>

`T`

Type de l'énumération.

#### Returns
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')  
Retourne un dictionnaire { key = name, value = description } pour une enum.