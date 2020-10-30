namespace Ustilz.AspNetCore.Mvc
{
    #region Usings

    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    #endregion

    [HtmlTargetElement("*", Attributes = "asp-authpolicy,asp-route-id")]
    public class ResourcePolicyAuthorizationTagHelper : TagHelper
    {
        private readonly IAuthorizationService authorizationService;

        private readonly IHttpContextAccessor httpContextAccessor;

        public ResourcePolicyAuthorizationTagHelper(
            IHttpContextAccessor httpContextAccessor,
            IAuthorizationService authorizationService)
        {
            this.httpContextAccessor = httpContextAccessor;
            this.authorizationService = authorizationService;
        }

        [HtmlAttributeName("asp-authpolicy")]
        public string PolicyName { get; set; }

        [HtmlAttributeName("asp-route-id")]
        public string ResourceId { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            await base.ProcessAsync(context, output);

            var httpContext = this.httpContextAccessor.HttpContext;
            if (httpContext != null && !(await this.authorizationService.AuthorizeAsync(httpContext.User, this.ResourceId, this.PolicyName)).Succeeded)
            {
                output.SuppressOutput();
            }
        }
    }
}
