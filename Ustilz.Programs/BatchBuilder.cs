namespace Ustilz.Programs
{
    #region Usings

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    public class BatchBuilder : ProgBuilder<BatchBuilder, Batch>
    {
        #region Méthodes publiques

        /// <summary>The build.</summary>
        /// <returns>The <see cref="Prog" />.</returns>
        public override Batch Build() => new Batch(this.Services.BuildServiceProvider(), this.LogAction);

        #endregion
    }
}
