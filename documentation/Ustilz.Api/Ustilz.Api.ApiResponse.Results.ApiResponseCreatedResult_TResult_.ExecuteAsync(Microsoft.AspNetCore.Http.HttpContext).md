#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Results](Ustilz.Api.ApiResponse.Results.md 'Ustilz.Api.ApiResponse.Results').[ApiResponseCreatedResult&lt;TResult&gt;](Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.md 'Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult<TResult>')

## ApiResponseCreatedResult<TResult>.ExecuteAsync(HttpContext) Method

Write an HTTP response reflecting the result and set headers with [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders').

```csharp
public override System.Threading.Tasks.Task ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext httpContext);
```
#### Parameters

<a name='Ustilz.Api.ApiResponse.Results.ApiResponseCreatedResult_TResult_.ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext).httpContext'></a>

`httpContext` [Microsoft.AspNetCore.Http.HttpContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpContext 'Microsoft.AspNetCore.Http.HttpContext')

The [Microsoft.AspNetCore.Http.HttpContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpContext 'Microsoft.AspNetCore.Http.HttpContext') for the current request.

Implements [ExecuteAsync(HttpContext)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult.ExecuteAsync#Microsoft_AspNetCore_Http_IResult_ExecuteAsync_Microsoft_AspNetCore_Http_HttpContext_ 'Microsoft.AspNetCore.Http.IResult.ExecuteAsync(Microsoft.AspNetCore.Http.HttpContext)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A task that represents the asynchronous execute operation.