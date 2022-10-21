#### [Ustilz.Extensions](index.md 'index')
### [Ustilz.Extensions](Ustilz.Extensions.md 'Ustilz.Extensions').[ExtensionsEnum](Ustilz.Extensions.ExtensionsEnum.md 'Ustilz.Extensions.ExtensionsEnum')

## ExtensionsEnum.IsIn(this Enum, Enum[]) Method

Returns true if enum matches any of the given values.

```csharp
public static bool IsIn(this System.Enum value, params System.Enum[] values);
```
#### Parameters

<a name='Ustilz.Extensions.ExtensionsEnum.IsIn(thisSystem.Enum,System.Enum[]).value'></a>

`value` [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum')

Value to match.

<a name='Ustilz.Extensions.ExtensionsEnum.IsIn(thisSystem.Enum,System.Enum[]).values'></a>

`values` [System.Enum](https://docs.microsoft.com/en-us/dotnet/api/System.Enum 'System.Enum')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

Values to match against.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Return true if matched.