#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse](Ustilz.Api.ApiResponse.md 'Ustilz.Api.ApiResponse').[ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

## ApiRequestHeaders.BindAsync(HttpContext) Method

Method which bind monitoring ids present in the headers to a [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders') object.

```csharp
public static System.Threading.Tasks.ValueTask<Ustilz.Api.ApiResponse.ApiRequestHeaders> BindAsync(Microsoft.AspNetCore.Http.HttpContext context);
```
#### Parameters

<a name='Ustilz.Api.ApiResponse.ApiRequestHeaders.BindAsync(Microsoft.AspNetCore.Http.HttpContext).context'></a>

`context` [Microsoft.AspNetCore.Http.HttpContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.HttpContext 'Microsoft.AspNetCore.Http.HttpContext')

The http context.

#### Returns
[System.Threading.Tasks.ValueTask&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')[ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.ValueTask-1 'System.Threading.Tasks.ValueTask`1')  
Returns the headers object.