### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpService](Ustilz.Http.HttpService.md 'Ustilz.Http.HttpService')

## HttpService.PostAsyncInternalAsync<TResponse>(Uri, Dictionary<string,IEnumerable<string>>, string, string) Method

The post async internal.

```csharp
private System.Threading.Tasks.Task<TResponse?> PostAsyncInternalAsync<TResponse>(System.Uri url, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> headers, string content, string? authentification)
    where TResponse : class;
```
#### Type parameters

<a name='Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).TResponse'></a>

`TResponse`

Test de la réponse.
#### Parameters

<a name='Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).url'></a>

`url` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The url.

<a name='Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).headers'></a>

`headers` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The headers.

<a name='Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).content'></a>

`content` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The content.

<a name='Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).authentification'></a>

`authentification` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentification.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TResponse](Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).md#Ustilz.Http.HttpService.PostAsyncInternalAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).TResponse 'Ustilz.Http.HttpService.PostAsyncInternalAsync<TResponse>(System.Uri, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, string, string).TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').