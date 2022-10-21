### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpService](Ustilz.Http.HttpService.md 'Ustilz.Http.HttpService')

## HttpService.GetResponseAsyncInternalAsync<TResponse>(Uri, string) Method

The get.

```csharp
private System.Threading.Tasks.Task<TResponse?> GetResponseAsyncInternalAsync<TResponse>(System.Uri url, string? authentification)
    where TResponse : class;
```
#### Type parameters

<a name='Ustilz.Http.HttpService.GetResponseAsyncInternalAsync_TResponse_(System.Uri,string).TResponse'></a>

`TResponse`

Type de la réponse.
#### Parameters

<a name='Ustilz.Http.HttpService.GetResponseAsyncInternalAsync_TResponse_(System.Uri,string).url'></a>

`url` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The url.

<a name='Ustilz.Http.HttpService.GetResponseAsyncInternalAsync_TResponse_(System.Uri,string).authentification'></a>

`authentification` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentification.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Ustilz.Http.HttpService.GetResponseAsyncInternalAsync_TResponse_(System.Uri,string).md#Ustilz.Http.HttpService.GetResponseAsyncInternalAsync_TResponse_(System.Uri,string).TResponse 'Ustilz.Http.HttpService.GetResponseAsyncInternalAsync<TResponse>(System.Uri, string).TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The TResponse.