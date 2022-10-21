### [Ustilz.Http](Ustilz.Http.md 'Ustilz.Http').[HttpExtensions](Ustilz.Http.HttpExtensions.md 'Ustilz.Http.HttpExtensions')

## HttpExtensions.SetHeaders(this HttpResponse, Dictionary<string,IEnumerable<string>>) Method

The set headers.

```csharp
public static void SetHeaders(this Microsoft.AspNetCore.Http.HttpResponse response, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>> headers);
```
#### Parameters

<a name='Ustilz.Http.HttpExtensions.SetHeaders(thisMicrosoft.AspNetCore.Http.HttpResponse,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).response'></a>

`response` [Microsoft.AspNetCore.Http.HttpResponse](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpResponse 'Microsoft.AspNetCore.Http.HttpResponse')

The response.

<a name='Ustilz.Http.HttpExtensions.SetHeaders(thisMicrosoft.AspNetCore.Http.HttpResponse,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).headers'></a>

`headers` [System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

The headers.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[response](Ustilz.Http.HttpExtensions.SetHeaders(thisMicrosoft.AspNetCore.Http.HttpResponse,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).md#Ustilz.Http.HttpExtensions.SetHeaders(thisMicrosoft.AspNetCore.Http.HttpResponse,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).response 'Ustilz.Http.HttpExtensions.SetHeaders(this Microsoft.AspNetCore.Http.HttpResponse, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>).response') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
[headers](Ustilz.Http.HttpExtensions.SetHeaders(thisMicrosoft.AspNetCore.Http.HttpResponse,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).md#Ustilz.Http.HttpExtensions.SetHeaders(thisMicrosoft.AspNetCore.Http.HttpResponse,System.Collections.Generic.Dictionary_string,System.Collections.Generic.IEnumerable_string__).headers 'Ustilz.Http.HttpExtensions.SetHeaders(this Microsoft.AspNetCore.Http.HttpResponse, System.Collections.Generic.Dictionary<string,System.Collections.Generic.IEnumerable<string>>).headers') is [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
The source or predicate is null.

[System.ArgumentException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentException 'System.ArgumentException')  
An element with the same key already exists in the [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2').

[System.NotSupportedException](https://docs.microsoft.com/en-us/dotnet/api/System.NotSupportedException 'System.NotSupportedException')  
The [System.Collections.Generic.IDictionary&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IDictionary-2 'System.Collections.Generic.IDictionary`2') is read-only.