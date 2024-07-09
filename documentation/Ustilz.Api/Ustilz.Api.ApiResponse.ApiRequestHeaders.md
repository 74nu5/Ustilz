#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse](Ustilz.Api.ApiResponse.md 'Ustilz.Api.ApiResponse')

## ApiRequestHeaders Class

Record which represents the eat mapi headers request.

```csharp
public sealed class ApiRequestHeaders : Ustilz.Models.ServiceMonitoringDefinition,
System.IEquatable<Ustilz.Api.ApiResponse.ApiRequestHeaders>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Ustilz.Models.ServiceMonitoringDefinition](https://docs.microsoft.com/en-us/dotnet/api/Ustilz.Models.ServiceMonitoringDefinition 'Ustilz.Models.ServiceMonitoringDefinition') &#129106; ApiRequestHeaders

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [ApiRequestHeaders(Guid, string, Guid)](Ustilz.Api.ApiResponse.ApiRequestHeaders.ApiRequestHeaders(System.Guid,string,System.Guid).md 'Ustilz.Api.ApiResponse.ApiRequestHeaders.ApiRequestHeaders(System.Guid, string, System.Guid)') | Record which represents the eat mapi headers request. |

| Fields | |
| :--- | :--- |
| [CorrelationIdKey](Ustilz.Api.ApiResponse.ApiRequestHeaders.CorrelationIdKey.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders.CorrelationIdKey') | The correlation id key.<br/><remarks>
| [FunctionalIdKey](Ustilz.Api.ApiResponse.ApiRequestHeaders.FunctionalIdKey.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders.FunctionalIdKey') | The functional id key. |
| [TechnicalIdKey](Ustilz.Api.ApiResponse.ApiRequestHeaders.TechnicalIdKey.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders.TechnicalIdKey') | The technical id key. |

| Properties | |
| :--- | :--- |
| [TechnicalId](Ustilz.Api.ApiResponse.ApiRequestHeaders.TechnicalId.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders.TechnicalId') | The technical id. |

| Methods | |
| :--- | :--- |
| [BindAsync(HttpContext)](Ustilz.Api.ApiResponse.ApiRequestHeaders.BindAsync(Microsoft.AspNetCore.Http.HttpContext).md 'Ustilz.Api.ApiResponse.ApiRequestHeaders.BindAsync(Microsoft.AspNetCore.Http.HttpContext)') | Method which bind monitoring ids present in the headers to a [ApiRequestHeaders](Ustilz.Api.ApiResponse.ApiRequestHeaders.md 'Ustilz.Api.ApiResponse.ApiRequestHeaders') object. |