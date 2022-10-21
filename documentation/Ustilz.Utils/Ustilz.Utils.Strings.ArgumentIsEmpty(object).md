### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Strings](Ustilz.Utils.Strings.md 'Ustilz.Utils.Strings')

## Strings.ArgumentIsEmpty(object) Method

The string argument '{argumentName}' cannot be empty.

```csharp
public static string ArgumentIsEmpty(object? argumentName);
```
#### Parameters

<a name='Ustilz.Utils.Strings.ArgumentIsEmpty(object).argumentName'></a>

`argumentName` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The argument Name.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
format or args is null.

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.