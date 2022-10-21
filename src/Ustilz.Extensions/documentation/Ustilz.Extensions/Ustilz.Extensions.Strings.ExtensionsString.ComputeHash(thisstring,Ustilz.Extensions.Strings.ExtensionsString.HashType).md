#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Strings](Ustilz.Extensions.Strings.md 'Ustilz.Extensions.Strings').[ExtensionsString](Ustilz.Extensions.Strings.ExtensionsString.md 'Ustilz.Extensions.Strings.ExtensionsString')

## ExtensionsString.ComputeHash(this string, HashType) Method

Computes the hash of the string using a specified hash algorithm.

```csharp
public static string ComputeHash(this string input, Ustilz.Extensions.Strings.ExtensionsString.HashType hashType);
```
#### Parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.ComputeHash(thisstring,Ustilz.Extensions.Strings.ExtensionsString.HashType).input'></a>

`input` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The string to hash.

<a name='Ustilz.Extensions.Strings.ExtensionsString.ComputeHash(thisstring,Ustilz.Extensions.Strings.ExtensionsString.HashType).hashType'></a>

`hashType` [HashType](Ustilz.Extensions.Strings.ExtensionsString.HashType.md 'Ustilz.Extensions.Strings.ExtensionsString.HashType')

The hash algorithm to use.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The resulting hash or an empty string on error.