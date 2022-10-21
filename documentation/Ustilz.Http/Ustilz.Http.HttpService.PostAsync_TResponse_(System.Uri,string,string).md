### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpService](Ustilz.Http.HttpService.md 'Ustilz.Http.HttpService')

## HttpService.PostAsync<TResponse>(Uri, string, string) Method

The post.

```csharp
public System.Threading.Tasks.Task<TResponse?> PostAsync<TResponse>(System.Uri url, string content, string? authentification)
    where TResponse : class;
```
#### Type parameters

<a name='Ustilz.Http.HttpService.PostAsync_TResponse_(System.Uri,string,string).TResponse'></a>

`TResponse`

Type de la réponse.
#### Parameters

<a name='Ustilz.Http.HttpService.PostAsync_TResponse_(System.Uri,string,string).url'></a>

`url` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The url.

<a name='Ustilz.Http.HttpService.PostAsync_TResponse_(System.Uri,string,string).content'></a>

`content` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The http content.

<a name='Ustilz.Http.HttpService.PostAsync_TResponse_(System.Uri,string,string).authentification'></a>

`authentification` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentification.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Ustilz.Http.HttpService.PostAsync_TResponse_(System.Uri,string,string).md#Ustilz.Http.HttpService.PostAsync_TResponse_(System.Uri,string,string).TResponse 'Ustilz.Http.HttpService.PostAsync<TResponse>(System.Uri, string, string).TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The TResponse.