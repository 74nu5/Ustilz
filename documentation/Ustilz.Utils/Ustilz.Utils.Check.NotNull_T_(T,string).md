### [Ustilz.Utils](Ustilz.Utils.md 'Ustilz.Utils').[Check](Ustilz.Utils.Check.md 'Ustilz.Utils.Check')

## Check.NotNull<T>(T, string) Method

Méthode de vérification de la nullité de l'objet passé en paramètre.

```csharp
public static T NotNull<T>(T value, string parameterName);
```
#### Type parameters

<a name='Ustilz.Utils.Check.NotNull_T_(T,string).T'></a>

`T`

Type de la valeur à tester.
#### Parameters

<a name='Ustilz.Utils.Check.NotNull_T_(T,string).value'></a>

`value` [T](Ustilz.Utils.Check.NotNull_T_(T,string).md#Ustilz.Utils.Check.NotNull_T_(T,string).T 'Ustilz.Utils.Check.NotNull<T>(T, string).T')

L'objet à vérifier.

<a name='Ustilz.Utils.Check.NotNull_T_(T,string).parameterName'></a>

`parameterName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Nom du paramètre.

#### Returns
[T](Ustilz.Utils.Check.NotNull_T_(T,string).md#Ustilz.Utils.Check.NotNull_T_(T,string).T 'Ustilz.Utils.Check.NotNull<T>(T, string).T')  
Retourne l'objet en entrée.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
value is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
Value is empty.