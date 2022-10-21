#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Strings](Ustilz.Extensions.Strings.md 'Ustilz.Extensions.Strings').[ExtensionsString](Ustilz.Extensions.Strings.ExtensionsString.md 'Ustilz.Extensions.Strings.ExtensionsString')

## ExtensionsString.GenerateSalt(int) Method

Random salt to comsume in hash generation.

```csharp
public static string GenerateSalt(int length=4);
```
#### Parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.GenerateSalt(int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Length of salt value should be even, hex string will be twice of the length.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Hex string representation of salt value.