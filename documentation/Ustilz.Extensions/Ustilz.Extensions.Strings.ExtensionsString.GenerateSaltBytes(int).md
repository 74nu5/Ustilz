#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Strings](Ustilz.Extensions.Strings.md 'Ustilz.Extensions.Strings').[ExtensionsString](Ustilz.Extensions.Strings.ExtensionsString.md 'Ustilz.Extensions.Strings.ExtensionsString')

## ExtensionsString.GenerateSaltBytes(int) Method

Random salt to comsume in hash generation.

```csharp
public static byte[] GenerateSaltBytes(int length=16);
```
#### Parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.GenerateSaltBytes(int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

Length of salt value should be even, hex string will be twice of the length.

#### Returns
[System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
Bytes representation of salt value.