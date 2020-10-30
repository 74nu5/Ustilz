namespace Ustilz.AspNetCore.Mvc.Tests
{
    #region Usings

    using Microsoft.AspNetCore.Authorization;

    #endregion

    public class MinimumAgeRequirement : IAuthorizationRequirement
    {
        public MinimumAgeRequirement(int minimumAge)
            => this.MinimumAge = minimumAge;

        public int MinimumAge { get; }
    }
}
