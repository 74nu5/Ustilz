namespace Ustilz.Programs
{
    #region Usings

    using System;

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    /// <summary>
    /// Classe représentant l'objet Batch, permettant de configurer une application de type batch.
    /// </summary>
    public sealed class Batch : Prog<BatchBuilder>
    {
        #region Constructeurs et destructeurs

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="Batch"/>.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <param name="logAction">The logs actions.</param>
        public Batch(ServiceProvider provider, Action<string>[] logAction)
            : base(provider, logAction)
        {
        }

        #endregion
    }
}
