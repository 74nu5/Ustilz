#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse.Extensions](Ustilz.Api.ApiResponse.Extensions.md 'Ustilz.Api.ApiResponse.Extensions').[RouteHandlerBuilderExtensions](Ustilz.Api.ApiResponse.Extensions.RouteHandlerBuilderExtensions.md 'Ustilz.Api.ApiResponse.Extensions.RouteHandlerBuilderExtensions')

## RouteHandlerBuilderExtensions.ProducesApiResponse<TResult>(this RouteHandlerBuilder, HttpStatusCode) Method

Method which add metadata : Produces [ApiResponseBody&lt;TResponse&gt;](Ustilz.Api.ApiResponse.ApiResponseBody_TResponse_.md 'Ustilz.Api.ApiResponse.ApiResponseBody<TResponse>').

```csharp
public static Microsoft.AspNetCore.Builder.RouteHandlerBuilder ProducesApiResponse<TResult>(this Microsoft.AspNetCore.Builder.RouteHandlerBuilder routeHandlerBuilder, System.Net.HttpStatusCode statusCode);
```
#### Type parameters

<a name='Ustilz.Api.ApiResponse.Extensions.RouteHandlerBuilderExtensions.ProducesApiResponse_TResult_(thisMicrosoft.AspNetCore.Builder.RouteHandlerBuilder,System.Net.HttpStatusCode).TResult'></a>

`TResult`
#### Parameters

<a name='Ustilz.Api.ApiResponse.Extensions.RouteHandlerBuilderExtensions.ProducesApiResponse_TResult_(thisMicrosoft.AspNetCore.Builder.RouteHandlerBuilder,System.Net.HttpStatusCode).routeHandlerBuilder'></a>

`routeHandlerBuilder` [Microsoft.AspNetCore.Builder.RouteHandlerBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Builder.RouteHandlerBuilder 'Microsoft.AspNetCore.Builder.RouteHandlerBuilder')

The route builder.

<a name='Ustilz.Api.ApiResponse.Extensions.RouteHandlerBuilderExtensions.ProducesApiResponse_TResult_(thisMicrosoft.AspNetCore.Builder.RouteHandlerBuilder,System.Net.HttpStatusCode).statusCode'></a>

`statusCode` [System.Net.HttpStatusCode](https://docs.microsoft.com/en-us/dotnet/api/System.Net.HttpStatusCode 'System.Net.HttpStatusCode')

The status code.

#### Returns
[Microsoft.AspNetCore.Builder.RouteHandlerBuilder](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Builder.RouteHandlerBuilder 'Microsoft.AspNetCore.Builder.RouteHandlerBuilder')  
Return the route builder.