#### [Ustilz.Api](index.md 'index')
### [Ustilz.Api.ApiResponse](Ustilz.Api.ApiResponse.md 'Ustilz.Api.ApiResponse')

## ApiResponseResultState Enum

Represents all result states for an <seealso cref="T:Ustilz.Api.ApiResponse.ApiResponseBody`1"/>

```csharp
public enum ApiResponseResultState
```
### Fields

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.BadRequest'></a>

`BadRequest` 5

When some calls returns bad request code.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.Conflict'></a>

`Conflict` 7

When some calls returns conflict code.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.Error'></a>

`Error` 2

When all calls are in error.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.Forbidden'></a>

`Forbidden` 4

When some calls returns forbidden code.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.Incomplete'></a>

`Incomplete` 1

When some calls are in error.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.NotFound'></a>

`NotFound` 6

When some calls returns not found code.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.Success'></a>

`Success` 0

When every thing is ok.

<a name='Ustilz.Api.ApiResponse.ApiResponseResultState.Unauthorized'></a>

`Unauthorized` 3

When some calls returns unauthorized code.