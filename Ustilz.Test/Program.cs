// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Ustilz.Test
{
    #region Usings

    using Ustilz.Extensions;

    #endregion

    /// <summary>The program.</summary>
    internal class Program
    {
        #region Propriétés et indexeurs

        /// <summary>Gets or sets the t.</summary>
        public int T { get; set; } = 4;

        #endregion

        #region Méthodes privées

        /// <summary>The main.</summary>
        /// <param name="args">The args.</param>
        private static void Main(string[] args)
        {
            "t".Dump();
        }

        #endregion
    }
}
