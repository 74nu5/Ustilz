#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse](Ustilz.Api.ApiResponse.md 'Ustilz.Api.ApiResponse').[ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>')

## ApiResponseBody(ApiResponseResultState, TResponse, ApiResponseError[]) Constructor

Record which represent an api response body.

```csharp
public ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState Success, TResponse? Response, params Ustilz.Api.ApiResponse.ApiResponseError[] ResponseError);
```
#### Parameters

<a name='Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState,TResponse,Ustilz.Api.ApiResponse.ApiResponseError[]).Success'></a>

`Success` [ApiResponseResultState](Ustilz.Api.ApiResponse.ApiResponseResultState.md 'Ustilz.Api.ApiResponse.ApiResponseResultState')

A flag indicating whether the request succeed.

<a name='Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState,TResponse,Ustilz.Api.ApiResponse.ApiResponseError[]).Response'></a>

`Response` [TResponse](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md#Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.TResponse 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.TResponse')

The response.

<a name='Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState,TResponse,Ustilz.Api.ApiResponse.ApiResponseError[]).ResponseError'></a>

`ResponseError` [ApiResponseError](Ustilz.Api.ApiResponse.ApiResponseError.md 'Ustilz.Api.ApiResponse.ApiResponseError')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The api response error.