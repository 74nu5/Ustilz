### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Strings](Ustilz.Utils.Strings.md 'Ustilz.Utils.Strings')

## Strings.CollectionArgumentIsEmpty(object) Method

The collection argument '{argumentName}' must contain at least one element.

```csharp
public static string CollectionArgumentIsEmpty(object? argumentName);
```
#### Parameters

<a name='Ustilz.Utils.Strings.CollectionArgumentIsEmpty(object).argumentName'></a>

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