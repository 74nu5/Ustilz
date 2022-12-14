#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Results](Ustilz.Api.ApiResponse.Results.md 'Ustilz.Api.ApiResponse.Results')

## ApiResponseResult<TResult> Class

Class which represent an api response result.

```csharp
public class ApiResponseResult<TResult> :
Microsoft.AspNetCore.Http.IResult
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.TResult'></a>

`TResult`

Type of result.

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ApiResponseResult<TResult>

Derived  
&#8627; [ApiResponseBadRequestResult](Ustilz.Api.ApiResponse.Results.ApiResponseBadRequestResult.md 'Ustilz.Api.ApiResponse.Results.ApiResponseBadRequestResult')  
&#8627; [ApiResponseConflictResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseConflictResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseConflictResult<TResult>')  
&#8627; [ApiResponseCreatedResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult<TResult>')  
&#8627; [ApiResponseNoContentResult](Ustilz.Api.ApiResponse.Results.ApiResponseNoContentResult.md 'Ustilz.Api.ApiResponse.Results.ApiResponseNoContentResult')  
&#8627; [ApiResponseNotFoundResult](Ustilz.Api.ApiResponse.Results.ApiResponseNotFoundResult.md 'Ustilz.Api.ApiResponse.Results.ApiResponseNotFoundResult')

Implements [Microsoft.AspNetCore.Http.IResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult 'Microsoft.AspNetCore.Http.IResult')

| Constructors | |
| :--- | :--- |
| [ApiResponseResult(ApiRequestHeaders, Nullable&lt;HttpStatusCode&gt;, ApiResponseBody&lt;TResult&gt;)](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.ApiResponseResult(Ustilz.Api.ApiResponse.ApiRequestHeaders,System.Nullable_System.Net.HttpStatusCode_,Ustilz.Api.ApiResponse.ApiResponseBody_TResult_).md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>.ApiResponseResult(Ustilz.Api.ApiResponse.ApiRequestHeaders, System.Nullable<System.Net.HttpStatusCode>, Ustilz.Api.ApiResponse.ApiResponseBody<TResult>)') | Initializes a new instance of the [ApiResponseResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>') class. |

| Methods | |
| :--- | :--- |
| [ExecuteAsync(HttpContext)](Ustilz.Api.ApiResponse.Results.ApiResponseResult_TResult_.ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext).md 'Ustilz.Api.ApiResponse.Results.ApiResponseResult<TResult>.ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext)') | Write an HTTP response reflecting the result and set headers with [Ustilz.Models.ServiceMonitoringDefinition](https://docs.microsoft.com/en-us/dotnet/api/Ustilz.Models.ServiceMonitoringDefinition 'Ustilz.Models.ServiceMonitoringDefinition'). |
