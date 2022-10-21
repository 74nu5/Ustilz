### [Ustilz.Xml](Ustilz.Xml.md 'Ustilz.Xml').[XmlExtensions](Ustilz.Xml.XmlExtensions.md 'Ustilz.Xml.XmlExtensions')

## XmlExtensions.FromXml<T>(this XmlDocument) Method

Méthode de dé-sérialisation à partir d'un document Xml.

```csharp
public static T? FromXml<T>(this System.Xml.XmlDocument xmlDocument)
    where T : class;
```
#### Type parameters

<a name='Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.XmlDocument).T'></a>

`T`

Le type vers lequel dé-sérialiser.
#### Parameters

<a name='Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.XmlDocument).xmlDocument'></a>

`xmlDocument` [System.Xml.XmlDocument](https://docs.microsoft.com/en-us/dotnet/api/System.Xml.XmlDocument 'System.Xml.XmlDocument')

Document Xml à dé-sérialiser.

#### Returns
[T](Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.XmlDocument).md#Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.XmlDocument).T 'Ustilz.Xml.XmlExtensions.FromXml<T>(this System.Xml.XmlDocument).T')  
Retourne l'objet de T dé-sérialisé.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[xmlDocument](Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.XmlDocument).md#Ustilz.Xml.XmlExtensions.FromXml_T_(thisSystem.Xml.XmlDocument).xmlDocument 'Ustilz.Xml.XmlExtensions.FromXml<T>(this System.Xml.XmlDocument).xmlDocument') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
Le document ne peut pas être null.