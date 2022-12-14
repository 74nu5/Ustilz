#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Extensions](Ustilz.Api.ApiResponse.Extensions.md 'Ustilz.Api.ApiResponse.Extensions').[ResultsExtensions](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.md 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions')

## ResultsExtensions.Ok<TResult>(this IResultExtensions, ApiRequestHeaders, TResult) Method

Method which returns a new api response result.

```csharp
public static Microsoft.AspNetCore.Http.IResult Ok<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions resultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders headers, TResult result);
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).TResult'></a>

`TResult`

Type of result.
#### Parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).resultExtensions'></a>

`resultExtensions` [Microsoft.AspNetCore.Http.IResultExtensions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResultExtensions 'Microsoft.AspNetCore.Http.IResultExtensions')

The result extensions.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).headers'></a>

`headers` [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

The api headers.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).result'></a>

`result` [TResult](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).md#Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).TResult 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Ok<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders, TResult).TResult')

The result.

#### Returns
[Microsoft.AspNetCore.Http.IResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult 'Microsoft.AspNetCore.Http.IResult')  
Returns a new api response result.