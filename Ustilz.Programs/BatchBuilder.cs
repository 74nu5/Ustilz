namespace Ustilz.Programs
{
    #region Usings

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    /// <summary>
    /// Classe de builder de l'objet <see cref="Batch"/>.
    /// </summary>
    public sealed class BatchBuilder : ProgBuilder<BatchBuilder, Batch>
    {
        #region Méthodes publiques

        /// <summary>Méthode de build.</summary>
        /// <returns>Retourne l'objet <see cref="Batch" />.</returns>
        public override Batch Build() => new Batch(this.Services.BuildServiceProvider(), this.LogAction);

        #endregion
    }
}
