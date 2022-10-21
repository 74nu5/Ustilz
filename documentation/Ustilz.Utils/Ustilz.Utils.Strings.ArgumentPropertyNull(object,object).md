### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Strings](Ustilz.Utils.Strings.md 'Ustilz.Utils.Strings')

## Strings.ArgumentPropertyNull(object, object) Method

The property '{property}' of the argument '{argument}' cannot be null.

```csharp
public static string ArgumentPropertyNull(object? property, object argument);
```
#### Parameters

<a name='Ustilz.Utils.Strings.ArgumentPropertyNull(object,object).property'></a>

`property` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The property.

<a name='Ustilz.Utils.Strings.ArgumentPropertyNull(object,object).argument'></a>

`argument` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The argument.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
format or args is null.

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.