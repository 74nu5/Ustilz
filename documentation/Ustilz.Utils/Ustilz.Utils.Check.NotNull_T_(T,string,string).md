### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Check](Ustilz.Utils.Check.md 'Ustilz.Utils.Check')

## Check.NotNull<T>(T, string, string) Method

Méthode de vérification de la nullité de l'objet passé en paramètre.

```csharp
public static T NotNull<T>(T value, string parameterName, string propertyName);
```
#### Type parameters

<a name='Ustilz.Utils.Check.NotNull_T_(T,string,string).T'></a>

`T`

Type de la valeur à tester.
#### Parameters

<a name='Ustilz.Utils.Check.NotNull_T_(T,string,string).value'></a>

`value` [T](Ustilz.Utils.Check.NotNull_T_(T,string,string).md#Ustilz.Utils.Check.NotNull_T_(T,string,string).T 'Ustilz.Utils.Check.NotNull<T>(T, string, string).T')

L'objet à vérifier.

<a name='Ustilz.Utils.Check.NotNull_T_(T,string,string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Nom du paramètre.

<a name='Ustilz.Utils.Check.NotNull_T_(T,string,string).propertyName'></a>

`propertyName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Nom de la propriété.

#### Returns
[T](Ustilz.Utils.Check.NotNull_T_(T,string,string).md#Ustilz.Utils.Check.NotNull_T_(T,string,string).T 'Ustilz.Utils.Check.NotNull<T>(T, string, string).T')  
Retourne l'objet en entrée.

#### Exceptions

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Value is null.

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').