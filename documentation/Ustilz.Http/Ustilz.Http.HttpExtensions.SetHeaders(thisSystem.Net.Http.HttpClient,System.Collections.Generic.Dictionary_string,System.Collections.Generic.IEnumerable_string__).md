### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpExtensions](Ustilz.Http.HttpExtensions.md 'Ustilz.Http.HttpExtensions')

## HttpExtensions.SetHeaders(this HttpClient, Dictionary<string,IEnumerable<string>>) Method

The set headers.

```csharp
public static void SetHeaders(this System.Net.Http.HttpClient client, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> headers);
```
#### Parameters

<a name='Ustilz.Http.HttpExtensions.SetHeaders(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).client'></a>

`client` [System.Net.Http.HttpClient](https://docs.microsoft.com/en-us/dotnet/api/System.Net.Http.HttpClient 'System.Net.Http.HttpClient')

The client.

<a name='Ustilz.Http.HttpExtensions.SetHeaders(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).headers'></a>

`headers` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The headers.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[client](Ustilz.Http.HttpExtensions.SetHeaders(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).md#Ustilz.Http.HttpExtensions.SetHeaders(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).client 'Ustilz.Http.HttpExtensions.SetHeaders(this System.Net.Http.HttpClient, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>).client') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[headers](Ustilz.Http.HttpExtensions.SetHeaders(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).md#Ustilz.Http.HttpExtensions.SetHeaders(thisSystem.Net.Http.HttpClient,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).headers 'Ustilz.Http.HttpExtensions.SetHeaders(this System.Net.Http.HttpClient, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>).headers') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').