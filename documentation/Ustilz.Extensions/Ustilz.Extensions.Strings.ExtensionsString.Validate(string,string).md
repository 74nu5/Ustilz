#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions.Strings](Ustilz.Extensions.Strings.md 'Ustilz.Extensions.Strings').[ExtensionsString](Ustilz.Extensions.Strings.ExtensionsString.md 'Ustilz.Extensions.Strings.ExtensionsString')

## ExtensionsString.Validate(string, string) Method

Validate password is equal to hashValue(Generated from Compute hash).

```csharp
public static bool Validate(string hashValue, string password);
```
#### Parameters

<a name='Ustilz.Extensions.Strings.ExtensionsString.Validate(string,string).hashValue'></a>

`hashValue` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Computed hash value of actual password 'MD5$Salt$Hash'.

<a name='Ustilz.Extensions.Strings.ExtensionsString.Validate(string,string).password'></a>

`password` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Password to validate against hash value.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
True if password is equal to the hash value.