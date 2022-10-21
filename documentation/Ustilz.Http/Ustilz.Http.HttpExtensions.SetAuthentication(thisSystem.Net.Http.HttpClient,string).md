### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpExtensions](Ustilz.Http.HttpExtensions.md 'Ustilz.Http.HttpExtensions')

## HttpExtensions.SetAuthentication(this HttpClient, string) Method

The set authentication.

```csharp
public static void SetAuthentication(this System.Net.Http.HttpClient client, string authentication);
```
#### Parameters

<a name='Ustilz.Http.HttpExtensions.SetAuthentication(thisSystem.Net.Http.HttpClient,string).client'></a>

`client` [System.Net.Http.HttpClient](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpClient 'System.Net.Http.HttpClient')

The client.

<a name='Ustilz.Http.HttpExtensions.SetAuthentication(thisSystem.Net.Http.HttpClient,string).authentication'></a>

`authentication` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentication.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[client](Ustilz.Http.HttpExtensions.SetAuthentication(thisSystem.Net.Http.HttpClient,string).md#Ustilz.Http.HttpExtensions.SetAuthentication(thisSystem.Net.Http.HttpClient,string).client 'Ustilz.Http.HttpExtensions.SetAuthentication(this System.Net.Http.HttpClient, string).client') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[authentication](Ustilz.Http.HttpExtensions.SetAuthentication(thisSystem.Net.Http.HttpClient,string).md#Ustilz.Http.HttpExtensions.SetAuthentication(thisSystem.Net.Http.HttpClient,string).authentication 'Ustilz.Http.HttpExtensions.SetAuthentication(this System.Net.Http.HttpClient, string).authentication') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.FormatException](https://docs.microsoft.com/en-us/dotnet/api/System.FormatException 'System.FormatException')  
Inputis not valid authentication header value information.