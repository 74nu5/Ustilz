namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Threading.Tasks;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public static partial class ExtensionsInt32
    {
        #region Méthodes privées

        /// <summary>The times.</summary>
        /// <param name="count">The count.</param>
        /// <param name="action">The action.</param>
        public static void Times(this int count, Action action) => Parallel.For(0, count, (l, state) => action());

        #endregion
    }
}