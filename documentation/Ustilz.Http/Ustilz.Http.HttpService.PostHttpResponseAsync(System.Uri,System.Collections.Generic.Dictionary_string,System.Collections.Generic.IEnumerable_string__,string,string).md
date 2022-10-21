### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpService](Ustilz.Http.HttpService.md 'Ustilz.Http.HttpService')

## HttpService.PostHttpResponseAsync(Uri, Dictionary<string,IEnumerable<string>>, string, string) Method

The post http response async.

```csharp
public System.Threading.Tasks.Task<(System.Net.HttpStatusCode StatusCode,string? ResponsePhrase,System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> Headers,string? Response)> PostHttpResponseAsync(System.Uri url, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> headers, string body, string? authentification);
```
#### Parameters

<a name='Ustilz.Http.HttpService.PostHttpResponseAsync(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).url'></a>

`url` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The url.

<a name='Ustilz.Http.HttpService.PostHttpResponseAsync(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).headers'></a>

`headers` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The headers.

<a name='Ustilz.Http.HttpService.PostHttpResponseAsync(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).body'></a>

`body` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The body.

<a name='Ustilz.Http.HttpService.PostHttpResponseAsync(System.Uri,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__,string,string).authentification'></a>

`authentification` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The authentification.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Net.HttpStatusCode](https://docs.microsoft.com/en-us/dotnet/api/System.Net.HttpStatusCode 'System.Net.HttpStatusCode')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[,](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.ValueTuple 'System.ValueTuple')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
The [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task').