#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Results](Ustilz.Api.ApiResponse.Results.md 'Ustilz.Api.ApiResponse.Results')

## ApiResponseCreatedResult<TResult> Class

Class which represent an api response result.

```csharp
public class ApiResponseCreatedResult<TResult> : Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.TResult'></a>

`TResult`

Type of result.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Ustilz.Api.ApiResponse.Results.ApiResponseResult&lt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>')[TResult](Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.md#Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.TResult 'Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult<TResult>.TResult')[&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>') &#129106; ApiResponseCreatedResult<TResult>

| Constructors | |
| :--- | :--- |
| [ApiResponseCreatedResult(ApiRequestHeaders, string, ApiResponseBody&lt;TResult&gt;)](Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.ApiResponseCreatedResult(Ustilz.Api.ApiResponse.ApiRequestHeaders,string,Ustilz.Api.ApiResponse.ApiResponseBody_TResult_).md 'Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult<TResult>.ApiResponseCreatedResult(Ustilz.Api.ApiResponse.ApiRequestHeaders, string, Ustilz.Api.ApiResponse.ApiResponseBody<TResult>)') | Initializes a new instance of the [ApiResponseResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>') class. |
| [ApiResponseCreatedResult(ApiRequestHeaders, Uri, ApiResponseBody&lt;TResult&gt;)](Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.ApiResponseCreatedResult(Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Uri,Ustilz.Api.ApiResponse.ApiResponseBody_TResult_).md 'Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult<TResult>.ApiResponseCreatedResult(Ustilz.Api.ApiResponse.ApiRequestHeaders, System.Uri, Ustilz.Api.ApiResponse.ApiResponseBody<TResult>)') | Initializes a new instance of the [ApiResponseResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>') class. |

| Methods | |
| :--- | :--- |
| [ExecuteAsync(HttpContext)](Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext).md 'Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult<TResult>.ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext)') | Write an HTTP response reflecting the result and set headers with [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders'). |
