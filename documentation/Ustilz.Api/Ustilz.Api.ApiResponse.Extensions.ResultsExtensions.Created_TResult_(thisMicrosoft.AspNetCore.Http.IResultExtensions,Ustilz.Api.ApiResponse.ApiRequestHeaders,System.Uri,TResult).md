#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Extensions](Ustilz.Api.ApiResponse.Extensions.md 'Ustilz.Api.ApiResponse.Extensions').[ResultsExtensions](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.md 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions')

## ResultsExtensions.Created<TResult>(this IResultExtensions, ApiRequestHeaders, Uri, TResult) Method

Method which returns a new api response result.

```csharp
public static Microsoft.AspNetCore.Http.IResult Created<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions resultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders headers, System.Uri location, TResult? result=default(TResult?));
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).TResult'></a>

`TResult`

Type of result.
#### Parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).resultExtensions'></a>

`resultExtensions` [Microsoft.AspNetCore.Http.IResultExtensions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResultExtensions 'Microsoft.AspNetCore.Http.IResultExtensions')

The result extensions.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).headers'></a>

`headers` [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

The api headers.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).location'></a>

`location` [System.Uri](https://docs.microsoft.com/en-us/dotnet/api/System.Uri 'System.Uri')

The resources created uri.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).result'></a>

`result` [TResult](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).md#Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,TResult).TResult 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Created<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders, System.Uri, TResult).TResult')

The result.

#### Returns
[Microsoft.AspNetCore.Http.IResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult 'Microsoft.AspNetCore.Http.IResult')  
Returns a new api response result.