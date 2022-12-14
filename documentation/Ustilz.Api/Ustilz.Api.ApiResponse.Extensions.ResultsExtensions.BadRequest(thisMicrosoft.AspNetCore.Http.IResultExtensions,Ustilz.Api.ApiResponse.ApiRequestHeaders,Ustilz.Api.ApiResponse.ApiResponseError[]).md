#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Extensions](Ustilz.Api.ApiResponse.Extensions.md 'Ustilz.Api.ApiResponse.Extensions').[ResultsExtensions](Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.md 'Ustilz.Api.ApiResponse.Extensions.ResultsExtensions')

## ResultsExtensions.BadRequest(this IResultExtensions, ApiRequestHeaders, ApiResponseError[]) Method

Method which returns a new api response result.

```csharp
public static Microsoft.AspNetCore.Http.IResult BadRequest(this Microsoft.AspNetCore.Http.IResultExtensions resultExtensions, Ustilz.Api.ApiResponse.ApiRequestHeaders headers, params Ustilz.Api.ApiResponse.ApiResponseError[] errors);
```
#### Parameters

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.BadRequest(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,Ustilz.Api.ApiResponse.ApiResponseError[]).resultExtensions'></a>

`resultExtensions` [Microsoft.AspNetCore.Http.IResultExtensions](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResultExtensions 'Microsoft.AspNetCore.Http.IResultExtensions')

The result extensions.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.BadRequest(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,Ustilz.Api.ApiResponse.ApiResponseError[]).headers'></a>

`headers` [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')

The api headers.

<a name='Ustilz.Api.ApiResponse.Extensions.ResultsExtensions.BadRequest(thisMicrosoft.AspNetCore.Http.IResultExtensions,Ustilz.Api.ApiResponse.ApiRequestHeaders,Ustilz.Api.ApiResponse.ApiResponseError[]).errors'></a>

`errors` [ApiResponseError](Ustilz.Api.ApiResponse.ApiResponseError.md 'Ustilz.Api.ApiResponse.ApiResponseError')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The bad request errors.

#### Returns
[Microsoft.AspNetCore.Http.IResult](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Http.IResult 'Microsoft.AspNetCore.Http.IResult')  
Returns a new api response result.