### [Ustilz.Extensions.Configuration](Ustilz.Extensions.Configuration.md 'Ustilz.Extensions.Configuration').[ExtensionsConfigurationBuilder](Ustilz.Extensions.Configuration.ExtensionsConfigurationBuilder.md 'Ustilz.Extensions.Configuration.ExtensionsConfigurationBuilder')

## ExtensionsConfigurationBuilder.UseAppSettingsJson(this IConfigurationBuilder) Method

The use app settings json.

```csharp
public static Microsoft.Extensions.Configuration.IConfigurationBuilder UseAppSettingsJson(this Microsoft.Extensions.Configuration.IConfigurationBuilder builder);
```
#### Parameters

<a name='Ustilz.Extensions.Configuration.ExtensionsConfigurationBuilder.UseAppSettingsJson(thisMicrosoft.Extensions.Configuration.IConfigurationBuilder).builder'></a>

`builder` [Microsoft.Extensions.Configuration.IConfigurationBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationBuilder 'Microsoft.Extensions.Configuration.IConfigurationBuilder')

The builder.

#### Returns
[Microsoft.Extensions.Configuration.IConfigurationBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationBuilder 'Microsoft.Extensions.Configuration.IConfigurationBuilder')  
The [Microsoft.Extensions.Configuration.IConfigurationBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.Extensions.Configuration.IConfigurationBuilder 'Microsoft.Extensions.Configuration.IConfigurationBuilder').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
Lève une exception lorsque la variable d'environnement ASPNETCORE_ENVIRONMENT n'est pas trouvée.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
path1, path2, or path3 contains one or more of the invalid characters defined in [System.IO.Path.GetInvalidPathChars](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Path.GetInvalidPathChars 'System.IO.Path.GetInvalidPathChars').