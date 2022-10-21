### [Ustilz.Xml](Ustilz.Xml.md 'Ustilz.Xml').[XmlExtensions](Ustilz.Xml.XmlExtensions.md 'Ustilz.Xml.XmlExtensions')

## XmlExtensions.FromXml<T>(this XDocument) Method

Méthode de dé-sérialisation à partir d'un XDocument.

```csharp
public static T? FromXml<T>(this System.Xml.Linq.XDocument xDocument)
    where T : class;
```
#### Type parameters

<a name='Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.Linq.XDocument).T'></a>

`T`

Le type vers lequel dé-sérialiser.
#### Parameters

<a name='Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.Linq.XDocument).xDocument'></a>

`xDocument` [System.Xml.Linq.XDocument](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.Linq.XDocument 'System.Xml.Linq.XDocument')

Le XDocument à dé-sérialiser.

#### Returns
[T](Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.Linq.XDocument).md#Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.Linq.XDocument).T 'Ustilz.Xml.XmlExtensions.FromXml<T>(this System.Xml.Linq.XDocument).T')  
Retourne l'objet de T dé-sérialisé.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[xDocument](Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.Linq.XDocument).md#Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.Linq.XDocument).xDocument 'Ustilz.Xml.XmlExtensions.FromXml<T>(this System.Xml.Linq.XDocument).xDocument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
An error occurred during deserialization. The original exception is available using the  
[System.Exception.InnerException](https://docs.microsoft.com/en-us/dotnet/api/System.Exception.InnerException 'System.Exception.InnerException') property.