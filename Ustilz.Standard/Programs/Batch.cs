namespace Ustilz.Programs
{
    #region Usings

    using System;

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    public class Batch : Prog<BatchBuilder>
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Batch" /> class.</summary>
        /// <param name="provider">The provider.</param>
        /// <param name="logAction">The logs actions.</param>
        public Batch(ServiceProvider provider, Action<string>[] logAction)
            : base(provider, logAction)
        {
        }

        #endregion
    }
}
