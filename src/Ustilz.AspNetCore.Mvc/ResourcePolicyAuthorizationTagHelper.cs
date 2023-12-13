namespace Ustilz.AspNetCore.Mvc;

using System.Threading.Tasks;

using JetBrains.Annotations;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Razor.TagHelpers;

/// <summary>
///     Tag Helper qui permet de conditionner l'affichage d'une balise en fonction d'une politique d'authorisation.
/// </summary>
[HtmlTargetElement("*", Attributes = "asp-authpolicy,asp-route-id")]
[PublicAPI]
public class ResourcePolicyAuthorizationTagHelper : TagHelper
{
    private readonly IAuthorizationService authorizationService;

    private readonly IHttpContextAccessor httpContextAccessor;

    /// <summary>
    ///     Initialise une nouvelle instance de la classe <see cref="ResourcePolicyAuthorizationTagHelper" />.
    /// </summary>
    /// <param name="httpContextAccessor">Accesseur du context http.</param>
    /// <param name="authorizationService">Service d'authorisation.</param>
    public ResourcePolicyAuthorizationTagHelper(
        IHttpContextAccessor httpContextAccessor,
        IAuthorizationService authorizationService)
    {
        this.httpContextAccessor = httpContextAccessor;
        this.authorizationService = authorizationService;
    }

    /// <summary>
    ///     Obtient ou définit le nom de la politique.
    /// </summary>
    [HtmlAttributeName("asp-authpolicy")]
    public string PolicyName { get; set; } = string.Empty;

    /// <summary>
    ///     Obtient ou définit l'identifiant de la route.
    /// </summary>
    [HtmlAttributeName("asp-route-id")]
    public string ResourceId { get; set; } = string.Empty;

    /// <inheritdoc />
    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await base.ProcessAsync(context, output);

        var httpContext = this.httpContextAccessor.HttpContext;
        if (httpContext != null && !(await this.authorizationService.AuthorizeAsync(httpContext.User, this.ResourceId, this.PolicyName)).Succeeded)
            output.SuppressOutput();
    }
}
