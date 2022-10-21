#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Strings](Ustilz.Extensions.Strings.md 'Ustilz.Extensions.Strings').[ExtensionsString](Ustilz.Extensions.Strings.ExtensionsString.md 'Ustilz.Extensions.Strings.ExtensionsString')

## ExtensionsString.GenerateHash(string, string, HashType) Method

The generate hash.

```csharp
public static string GenerateHash(string password, string? salt=null, Ustilz.Extensions.Strings.ExtensionsString.HashType provider=Ustilz.Extensions.Strings.ExtensionsString.HashType.MD5);
```
#### Parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.GenerateHash(string,string,Ustilz.Extensions.Strings.ExtensionsString.HashType).password'></a>

`password` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The password.

<a name='Ustilz.Extensions.Strings.ExtensionsString.GenerateHash(string,string,Ustilz.Extensions.Strings.ExtensionsString.HashType).salt'></a>

`salt` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The salt.

<a name='Ustilz.Extensions.Strings.ExtensionsString.GenerateHash(string,string,Ustilz.Extensions.Strings.ExtensionsString.HashType).provider'></a>

`provider` [HashType](Ustilz.Extensions.Strings.ExtensionsString.HashType.md 'Ustilz.Extensions.Strings.ExtensionsString.HashType')

The provider.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
Throws an exception when the hash type is unknown.