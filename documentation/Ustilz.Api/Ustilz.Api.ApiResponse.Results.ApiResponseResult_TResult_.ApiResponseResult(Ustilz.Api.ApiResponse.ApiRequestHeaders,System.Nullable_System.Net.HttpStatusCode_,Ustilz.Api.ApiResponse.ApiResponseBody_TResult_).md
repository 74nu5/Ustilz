#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Results](Ustilz.Api.ApiResponse.Results.md 'Ustilz.Api.ApiResponse.Results').[ApiResponseResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>')

## ApiResponseResult(ApiRequestHeaders, Nullable<HttpStatusCode>, ApiResponseBody<TResult>) Constructor

Initializes a new instance of the [ApiResponseResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>') class.

```csharp
public ApiResponseResult(Ustilz.Api.ApiResponse.ApiRequestHeaders headers, System.Nullable<System.Net.HttpStatusCode> statusCode=System.Net.HttpStatusCode.OK, Ustilz.Api.ApiResponse.ApiResponseBody<TResult>? result=null);
```
#### Parameters

<a name='Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.ApiResponseResult(Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Nullable_System.Net.HttpStatusCode_,Ustilz.Api.ApiResponse.ApiResponseBody_TResult_).headers'></a>

`headers` [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

The monitoring ids.

<a name='Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.ApiResponseResult(Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Nullable_System.Net.HttpStatusCode_,Ustilz.Api.ApiResponse.ApiResponseBody_TResult_).statusCode'></a>

`statusCode` [System.Nullable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')[System.Net.HttpStatusCode](https://docs.microsoft.com/en-us/dotnet/api/System.Net.HttpStatusCode 'System.Net.HttpStatusCode')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1 'System.Nullable`1')

The result status code.

<a name='Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.ApiResponseResult(Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Nullable_System.Net.HttpStatusCode_,Ustilz.Api.ApiResponse.ApiResponseBody_TResult_).result'></a>

`result` [Ustilz.Api.ApiResponse.ApiResponseBody&lt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>')[TResult](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md#Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.TResult 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>.TResult')[&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>')

The result body.