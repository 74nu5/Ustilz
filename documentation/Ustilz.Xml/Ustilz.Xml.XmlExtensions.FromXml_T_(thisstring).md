### [Ustilz.Xml](Ustilz.Xml.md 'Ustilz.Xml').[XmlExtensions](Ustilz.Xml.XmlExtensions.md 'Ustilz.Xml.XmlExtensions')

## XmlExtensions.FromXml<T>(this string) Method

Méthode de dé-sérialisation à partir d'une chaine de caractère.

```csharp
public static T? FromXml<T>(this string xmlStr)
    where T : class;
```
#### Type parameters

<a name='Ustilz.Xml.XmlExtensions.FromXml_T_(thisstring).T'></a>

`T`

Le type vers lequel dé-sérialiser.
#### Parameters

<a name='Ustilz.Xml.XmlExtensions.FromXml_T_(thisstring).xmlStr'></a>

`xmlStr` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

La chaine de caractères à dé-sérialiser.

#### Returns
[T](Ustilz.Xml.XmlExtensions.FromXml_T_(thisstring).md#Ustilz.Xml.XmlExtensions.FromXml_T_(thisstring).T 'Ustilz.Xml.XmlExtensions.FromXml<T>(this string).T')  
Retourne l'objet de T dé-sérialisé.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The [xmlStr](Ustilz.Xml.XmlExtensions.FromXml_T_(thisstring).md#Ustilz.Xml.XmlExtensions.FromXml_T_(thisstring).xmlStr 'Ustilz.Xml.XmlExtensions.FromXml<T>(this string).xmlStr') parameter is null.

[System.Security.SecurityException](https://docs.microsoft.com/en-us/dotnet/api/System.Security.SecurityException 'System.Security.SecurityException')  
The [System.Xml.XmlReader](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.XmlReader 'System.Xml.XmlReader') does not have sufficient permissions to access the location of the XML data.

[System.IO.FileNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/System.IO.FileNotFoundException 'System.IO.FileNotFoundException')  
The file identified by the URI does not exist.

[System.UriFormatException](https://docs.microsoft.com/en-us/dotnet/api/System.UriFormatException 'System.UriFormatException')  
In the [.NET for Windows Store apps](http://go.microsoft.com/fwlink/?LinkID=247912) or the [Portable Class  
Library](~/docs/standard/cross-platform/cross-platform-development-with-the-portable-class-library.md), catch the base class exception,  
[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException'), instead. The URI format is not correct.

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
An error occurred during deserialization. The original exception is available using the  
[System.Exception.InnerException](https://docs.microsoft.com/en-us/dotnet/api/System.Exception.InnerException 'System.Exception.InnerException') property.