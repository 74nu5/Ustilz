#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse](Ustilz.Api.ApiResponse.md 'Ustilz.Api.ApiResponse')

## ApiResponseError Class

Record which represent a api error.

```csharp
public class ApiResponseError :
System.IEquatable<Ustilz.Api.ApiResponse.ApiResponseError>
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ApiResponseError

Implements [System.IEquatable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')[ApiResponseError](Ustilz.Api.ApiResponse.ApiResponseError.md 'Ustilz.Api.ApiResponse.ApiResponseError')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1 'System.IEquatable`1')

| Constructors | |
| :--- | :--- |
| [ApiResponseError(int, string)](Ustilz.Api.ApiResponse.ApiResponseError.ApiResponseError(int,string).md 'Ustilz.Api.ApiResponse.ApiResponseError.ApiResponseError(int, string)') | Record which represent a api error. |

| Fields | |
| :--- | :--- |
| [Empty](Ustilz.Api.ApiResponse.ApiResponseError.Empty.md 'Ustilz.Api.ApiResponse.ApiResponseError.Empty') | Represents a empty error. |
| [NotFound](Ustilz.Api.ApiResponse.ApiResponseError.NotFound.md 'Ustilz.Api.ApiResponse.ApiResponseError.NotFound') | Represents a not found error. |
| [NotImplemented](Ustilz.Api.ApiResponse.ApiResponseError.NotImplemented.md 'Ustilz.Api.ApiResponse.ApiResponseError.NotImplemented') | Represents a not implemented error. |

| Properties | |
| :--- | :--- |
| [ErrorCode](Ustilz.Api.ApiResponse.ApiResponseError.ErrorCode.md 'Ustilz.Api.ApiResponse.ApiResponseError.ErrorCode') | The error code. |
| [ErrorMessage](Ustilz.Api.ApiResponse.ApiResponseError.ErrorMessage.md 'Ustilz.Api.ApiResponse.ApiResponseError.ErrorMessage') | The error message. |

| Operators | |
| :--- | :--- |
| [implicit operator ApiResponseError(string)](Ustilz.Api.ApiResponse.ApiResponseError.op_ImplicitUstilz.Api.ApiResponse.ApiResponseError(string).md 'Ustilz.Api.ApiResponse.ApiResponseError.op_Implicit Ustilz.Api.ApiResponse.ApiResponseError(string)') | Implict operator which convert a string to a [ApiResponseError](Ustilz.Api.ApiResponse.ApiResponseError.md 'Ustilz.Api.ApiResponse.ApiResponseError'). |
