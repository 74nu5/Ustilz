#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse](Ustilz.Api.ApiResponse.md 'Ustilz.Api.ApiResponse')

## ApiResponseBody<TResponse> Class

Record which represent an api response body.

```csharp
public class ApiResponseBody<TResponse> :
System.IEquatable<Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>>
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.TResponse'></a>

`TResponse`

The response type.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ApiResponseBody<TResponse>

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[Ustilz.Api.ApiResponse.ApiResponseBody&lt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>')[TResponse](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md#Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.TResponse 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.TResponse')[&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [ApiResponseBody()](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody().md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ApiResponseBody()') | Initializes a new instance of the [ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>') class. |
| [ApiResponseBody(List&lt;ApiResponseError&gt;)](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(System.Collections.Generic.List_Ustilz.Api.ApiResponse.ApiResponseError_).md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ApiResponseBody(System.Collections.Generic.List<Ustilz.Api.ApiResponse.ApiResponseError>)') | Initializes a new instance of the [ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>') class. |
| [ApiResponseBody(TResponse)](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(TResponse).md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ApiResponseBody(TResponse)') | Initializes a new instance of the [ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>') class. |
| [ApiResponseBody(ApiResponseError[])](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseError[]).md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseError[])') | Initializes a new instance of the [ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>') class. |
| [ApiResponseBody(ApiResponseResultState, TResponse, ApiResponseError[])](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState,TResponse,Ustilz.Api.ApiResponse.ApiResponseError[]).md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState, TResponse, Ustilz.Api.ApiResponse.ApiResponseError[])') | Record which represent an api response body. |
| [ApiResponseBody(ApiResponseResultState, ApiResponseError[])](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState,Ustilz.Api.ApiResponse.ApiResponseError[]).md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ApiResponseBody(Ustilz.Api.ApiResponse.ApiResponseResultState, Ustilz.Api.ApiResponse.ApiResponseError[])') | Initializes a new instance of the [ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>') class. |

| Properties | |
| :--- | :--- |
| [Response](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.Response.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.Response') | The response. |
| [ResponseError](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.ResponseError.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.ResponseError') | The api response error. |
| [Success](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.Success.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>.Success') | A flag indicating whether the request succeed. |
