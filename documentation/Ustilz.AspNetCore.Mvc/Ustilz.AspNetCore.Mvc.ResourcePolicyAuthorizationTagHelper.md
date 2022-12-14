### [Ustilz.AspNetCore.Mvc](Ustilz.AspNetCore.Mvc.md 'Ustilz.AspNetCore.Mvc')

## ResourcePolicyAuthorizationTagHelper Class

Tag Helper qui permet de conditionner l'affichage d'une balise en fonction d'une politique d'authorisation.

```csharp
public class ResourcePolicyAuthorizationTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Microsoft.AspNetCore.Razor.TagHelpers.TagHelper](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelper 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelper') &#129106; ResourcePolicyAuthorizationTagHelper

| Constructors | |
| :--- | :--- |
| [ResourcePolicyAuthorizationTagHelper(IHttpContextAccessor, IAuthorizationService)](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ResourcePolicyAuthorizationTagHelper(Microsoft.AspNetCore.Http.IHttpContextAccessor,Microsoft.AspNetCore.Authorization.IAuthorizationService).md 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ResourcePolicyAuthorizationTagHelper(Microsoft.AspNetCore.Http.IHttpContextAccessor, Microsoft.AspNetCore.Authorization.IAuthorizationService)') | Initialise une nouvelle instance de la classe [ResourcePolicyAuthorizationTagHelper](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.md 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper'). |

| Properties | |
| :--- | :--- |
| [PolicyName](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.PolicyName.md 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.PolicyName') | Obtient ou définit le nom de la politique. |
| [ResourceId](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ResourceId.md 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ResourceId') | Obtient ou définit l'identifiant de la route. |

| Methods | |
| :--- | :--- |
| [ProcessAsync(TagHelperContext, TagHelperOutput)](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).md 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)') | Asynchronously executes the [Microsoft.AspNetCore.Razor.TagHelpers.TagHelper](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelper 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelper') with the given [context](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).md#Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).context 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).context') and<br/>[output](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).md#Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output'). |
