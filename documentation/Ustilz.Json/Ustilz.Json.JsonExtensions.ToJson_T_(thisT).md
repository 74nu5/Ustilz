### [Ustilz.Json](Ustilz.Json.md 'Ustilz.Json').[JsonExtensions](Ustilz.Json.JsonExtensions.md 'Ustilz.Json.JsonExtensions')

## JsonExtensions.ToJson<T>(this T) Method

Méthode de sérialisation d'un objet en Json.

```csharp
public static string ToJson<T>(this T objectToSerialize);
```
#### Type parameters

<a name='Ustilz.Json.JsonExtensions.ToJson_T_(thisT).T'></a>

`T`

Type à partir duquel sérialiser.
#### Parameters

<a name='Ustilz.Json.JsonExtensions.ToJson_T_(thisT).objectToSerialize'></a>

`objectToSerialize` [T](Ustilz.Json.JsonExtensions.ToJson_T_(thisT).md#Ustilz.Json.JsonExtensions.ToJson_T_(thisT).T 'Ustilz.Json.JsonExtensions.ToJson<T>(this T).T')

L'objet à sérialiser.

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
Retourne une chaine de caractères représentant l'objet en paramètre.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[objectToSerialize](Ustilz.Json.JsonExtensions.ToJson_T_(thisT).md#Ustilz.Json.JsonExtensions.ToJson_T_(thisT).objectToSerialize 'Ustilz.Json.JsonExtensions.ToJson<T>(this T).objectToSerialize') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').