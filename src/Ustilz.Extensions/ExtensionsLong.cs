namespace Ustilz.Extensions
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>
    /// Classe d'extension du type long.
    /// </summary>
    [PublicAPI]
    public static class ExtensionsLong
    {
        #region Méthodes privées

        /// <summary>
        /// Métode de conversion d'un nombre en lettres.
        /// </summary>
        /// <param name="number">Nombre à convertir.</param>
        /// <returns>Retourne la représentation en lettre du nombre passé en paramètres.</returns>
        public static string ConvertIntoWords(this long number)
        {
            if (number == 0)
            {
                return "zero";
            }

            if (number < 0)
            {
                return "minus " + ConvertIntoWords(Math.Abs(number));
            }

            var words = string.Empty;
            if (number / 10000000 > 0)
            {
                words += ConvertIntoWords(number / 10000000) + " crores ";
                number %= 10000000;
            }

            if (number / 100000 > 0)
            {
                words += ConvertIntoWords(number / 100000) + " lacs ";
                number %= 100000;
            }

            if (number / 1000 > 0)
            {
                words += ConvertIntoWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if (number / 100 > 0)
            {
                words += ConvertIntoWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number <= 0)
            {
                return words;
            }

            var unitsMap = new[]
            {
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen",
                "seventeen", "eighteen", "nineteen"
            };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            if (number < 20)
            {
                words += unitsMap[number];
                return words;
            }

            words += tensMap[number / 10];
            if (number % 10 > 0)
            {
                words += " " + unitsMap[number % 10];
            }

            return words;
        }

        #endregion
    }
}
