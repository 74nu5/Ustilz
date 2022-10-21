### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpService](Ustilz.Http.HttpService.md 'Ustilz.Http.HttpService')

## HttpService.GetStringAsync<TResponse>(Uri, string) Method

The get async.

```csharp
public System.Threading.Tasks.Task<TResponse?> GetStringAsync<TResponse>(System.Uri url, string? authentification)
    where TResponse : class;
```
#### Type parameters

<a name='Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).TResponse'></a>

`TResponse`

Type de la réponse.
#### Parameters

<a name='Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).url'></a>

`url` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The url.

<a name='Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).authentification'></a>

`authentification` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentification.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).md#Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).TResponse 'Ustilz.Http.HttpService.GetStringAsync<TResponse>(System.Uri, string).TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[url](Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).md#Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).url 'Ustilz.Http.HttpService.GetStringAsync<TResponse>(System.Uri, string).url') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[authentification](Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).md#Ustilz.Http.HttpService.GetStringAsync_TResponse_(System.Uri,string).authentification 'Ustilz.Http.HttpService.GetStringAsync<TResponse>(System.Uri, string).authentification') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').