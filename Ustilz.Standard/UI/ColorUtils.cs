namespace Ustilz.UI
{
    #region Usings

    using System;
    using System.Globalization;
    using System.Linq;
    using System.Numerics;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The color utils.</summary>
    [PublicAPI]
    public static class ColorUtils
    {
        #region Champs et constantes statiques

        /// <summary>The random.</summary>
        private static readonly Random Random = new Random();

        #endregion

        #region Méthodes publiques

        /// <summary>The generer couleurs.</summary>
        /// <returns>The <see cref="string" />.</returns>
        [NotNull]
        public static string GenererCouleur() => $"{Random.Next(0x1000000):X6}";

        /// <summary>The get color from nom.</summary>
        /// <param name="nom">The nom.</param>
        /// <returns>The <see cref="string" />.</returns>
        [NotNull]
        public static string GetColorFromNom([NotNull] string nom) => GetColorFromNom(nom, false);

        /// <summary>The get color from nom.</summary>
        /// <param name="nom">The nom.</param>
        /// <param name="eclaircir"> Booléen pour éclaircir la couleur</param>
        /// <returns>The <see cref="string" />.</returns>
        [NotNull]
        public static string GetColorFromNom([NotNull] string nom, bool eclaircir)
        {
            if (nom.Length == 3)
            {
                return $"#{string.Join(string.Empty, nom.Select(c => ((byte)c).ToString("X")))}";
            }

            var s = string.Join(string.Empty, nom.Select(c => ((byte)c).ToString("X")));
            var bi = BigInteger.Parse(s, NumberStyles.AllowHexSpecifier);
            var bii = bi % 0xFFFFFF;

            // On force des couleurs plus claire pour pouvoir l'utiliser comme fond
            if (eclaircir)
            {
                bii |= 0xA0A0A0;
            }

            var color = $"#{(long)bii:X6}";
            return color.Length != 7 ? "#000000" : color;
        }

        #endregion
    }
}
