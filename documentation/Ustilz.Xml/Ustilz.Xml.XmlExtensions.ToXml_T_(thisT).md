### [Ustilz.Xml](Ustilz.Xml.md 'Ustilz.Xml').[XmlExtensions](Ustilz.Xml.XmlExtensions.md 'Ustilz.Xml.XmlExtensions')

## XmlExtensions.ToXml<T>(this T) Method

Méthode de sérialisation d'un objet.

```csharp
public static string ToXml<T>(this T objectToDeserialize);
```
#### Type parameters

<a name='Ustilz.Xml.XmlExtensions.ToXml_T_(thisT).T'></a>

`T`

Type a sérialiser.
#### Parameters

<a name='Ustilz.Xml.XmlExtensions.ToXml_T_(thisT).objectToDeserialize'></a>

`objectToDeserialize` [T](Ustilz.Xml.XmlExtensions.ToXml_T_(thisT).md#Ustilz.Xml.XmlExtensions.ToXml_T_(thisT).T 'Ustilz.Xml.XmlExtensions.ToXml<T>(this T).T')

L'objet à sérialiser.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Retourne une chaine de caractères représentant l'objet sous format Xml.

#### Exceptions

[System.InvalidOperationException](https://docs.microsoft.com/en-us/dotnet/api/System.InvalidOperationException 'System.InvalidOperationException')  
An error occurred during serialization. The original exception is available using the  
[System.Exception.InnerException](https://docs.microsoft.com/en-us/dotnet/api/System.Exception.InnerException 'System.Exception.InnerException') property.