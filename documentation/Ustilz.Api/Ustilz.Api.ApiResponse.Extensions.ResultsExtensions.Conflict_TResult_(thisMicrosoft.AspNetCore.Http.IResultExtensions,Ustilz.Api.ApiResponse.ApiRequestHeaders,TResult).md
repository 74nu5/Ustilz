#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Extensions](Ustilz.Api.ApiResponse.Extensions.md 'Ustilz.Api.ApiResponse.Extensions').[ResultsExtensions](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.md 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions')

## ResultsExtensions.Conflict<TResult>(this IResultExtensions, ApiRequestHeaders, TResult) Method

Method which returns a new api response result.

```csharp
public static Microsoft.AspNetCore.Http.IResult Conflict<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions resultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders headers, TResult? result=default(TResult?));
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).TResult'></a>

`TResult`
#### Parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).resultExtensions'></a>

`resultExtensions` [Microsoft.AspNetCore.Http.IResultExtensions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResultExtensions 'Microsoft.AspNetCore.Http.IResultExtensions')

The result extensions.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).headers'></a>

`headers` [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

The api headers.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).result'></a>

`result` [TResult](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).md#Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,TResult).TResult 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.Conflict<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders, TResult).TResult')

The conflicted result.

#### Returns
[Microsoft.AspNetCore.Http.IResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult 'Microsoft.AspNetCore.Http.IResult')  
Returns a new api response result.