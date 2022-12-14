### [Ustilz.AspNetCore.Mvc](Ustilz.AspNetCore.Mvc.md 'Ustilz.AspNetCore.Mvc').[ResourcePolicyAuthorizationTagHelper](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.md 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper')

## ResourcePolicyAuthorizationTagHelper.ProcessAsync(TagHelperContext, TagHelperOutput) Method

Asynchronously executes the [Microsoft.AspNetCore.Razor.TagHelpers.TagHelper](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelper 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelper') with the given [context](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).md#Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).context 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).context') and  
[output](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).md#Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output').

```csharp
public override System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output);
```
#### Parameters

<a name='Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).context'></a>

`context` [Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext')

Contains information associated with the current HTML tag.

<a name='Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output'></a>

`output` [Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput')

A stateful HTML element used to generate an HTML tag.

Implements [ProcessAsync(TagHelperContext, TagHelperOutput)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent.ProcessAsync#Microsoft_AspNetCore_Razor_TagHelpers_ITagHelperComponent_ProcessAsync_Microsoft_AspNetCore_Razor_TagHelpers_TagHelperContext,Microsoft_AspNetCore_Razor_TagHelpers_TagHelperOutput_ 'Microsoft.AspNetCore.Razor.TagHelpers.ITagHelperComponent.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')

#### Returns
[System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')  
A [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') that on completion updates the [output](Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).md#Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output 'Ustilz.AspNetCore.Mvc.ResourcePolicyAuthorizationTagHelper.ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput).output').

### Remarks
By default this calls into [Microsoft.AspNetCore.Razor.TagHelpers.TagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)](https://docs.microsoft.com/en-us/dotnet/api/Microsoft.AspNetCore.Razor.TagHelpers.TagHelper.Process#Microsoft_AspNetCore_Razor_TagHelpers_TagHelper_Process_Microsoft_AspNetCore_Razor_TagHelpers_TagHelperContext,Microsoft_AspNetCore_Razor_TagHelpers_TagHelperOutput_ 'Microsoft.AspNetCore.Razor.TagHelpers.TagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)').