### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpService](Ustilz.Http.HttpService.md 'Ustilz.Http.HttpService')

## HttpService.GetHttpResponseAsync<TResponse>(Uri, Dictionary<string,IEnumerable<string>>, string) Method

The get http response async.

```csharp
public System.Threading.Tasks.Task<(System.Net.HttpStatusCode Code,string? ResponsePhrase,System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> Headers,TResponse? Response)> GetHttpResponseAsync<TResponse>(System.Uri url, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> headers, string? authentification)
    where TResponse : class, new();
```
#### Type parameters

<a name='Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).TResponse'></a>

`TResponse`

Type de la réponse.
#### Parameters

<a name='Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).url'></a>

`url` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The url.

<a name='Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).headers'></a>

`headers` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The headers.

<a name='Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).authentification'></a>

`authentification` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentification.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Net.HttpStatusCode](https://docs.microsoft.com/en-us/dotnet/api/System.Net.HttpStatusCode 'System.Net.HttpStatusCode')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[TResponse](Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).md#Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).TResponse 'Ustilz.Http.HttpService.GetHttpResponseAsync<TResponse>(System.Uri, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, string).TResponse')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[url](Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).md#Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).url 'Ustilz.Http.HttpService.GetHttpResponseAsync<TResponse>(System.Uri, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, string).url') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[headers](Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).md#Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).headers 'Ustilz.Http.HttpService.GetHttpResponseAsync<TResponse>(System.Uri, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, string).headers') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[authentification](Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).md#Ustilz.Http.HttpService.GetHttpResponseAsync_TResponse_(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string).authentification 'Ustilz.Http.HttpService.GetHttpResponseAsync<TResponse>(System.Uri, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>, string).authentification') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').