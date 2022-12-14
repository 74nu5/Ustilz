#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Extensions](Ustilz.Api.ApiResponse.Extensions.md 'Ustilz.Api.ApiResponse.Extensions').[ResultsExtensions](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.md 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions')

## ResultsExtensions.StatusCode<TResult>(this IResultExtensions, ApiRequestHeaders, HttpStatusCode, TResult, ApiResponseError[]) Method

Method which returns a new api response result.

```csharp
public static Microsoft.AspNetCore.Http.IResult StatusCode<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions resultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders headers, System.Net.HttpStatusCode statusCode, TResult result, params Ustilz.Api.ApiResponse.ApiResponseError[] errors);
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).TResult'></a>

`TResult`
#### Parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).resultExtensions'></a>

`resultExtensions` [Microsoft.AspNetCore.Http.IResultExtensions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResultExtensions 'Microsoft.AspNetCore.Http.IResultExtensions')

The result extensions.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).headers'></a>

`headers` [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

The api headers.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).statusCode'></a>

`statusCode` [System.Net.HttpStatusCode](https://docs.microsoft.com/en-us/dotnet/api/System.Net.HttpStatusCode 'System.Net.HttpStatusCode')

The result status code.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).result'></a>

`result` [TResult](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).md#Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).TResult 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode<TResult>(this Microsoft.AspNetCore.Http.IResultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders, System.Net.HttpStatusCode, TResult, Ustilz.Api.ApiResponse.ApiResponseError[]).TResult')

The result.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.StatusCode_TResult_(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Net.HttpStatusCode,TResult,Ustilz.Api.ApiResponse.ApiResponseError[]).errors'></a>

`errors` [ApiResponseError](Ustilz.Api.ApiResponse.ApiResponseError.md 'Ustilz.Api.ApiResponse.ApiResponseError')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The errors.

#### Returns
[Microsoft.AspNetCore.Http.IResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult 'Microsoft.AspNetCore.Http.IResult')  
Returns a new api response result.