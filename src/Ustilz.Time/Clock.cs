namespace Ustilz.Time
{
    #region Usings

    using System;
    using System.Diagnostics.CodeAnalysis;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Class de wrapping de la propriété <see cref="DateTime.Now" />.</summary>
    [PublicAPI]
    [SuppressMessage("ReSharper", "EventExceptionNotDocumented", Justification = "Improbable")]
    public static class Clock
    {
        #region Champs et constantes statiques

        /// <summary>La fonction de remplacement de <see cref="DateTime.Now" />.</summary>
        private static Func<DateTime> function = () => DateTime.Now;

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Obtient la valeur définit par la fonction <see cref="function" />, renvoie <see cref="DateTime.Now" /> si la fonction n'est pas définit.</summary>
        [SuppressMessage("ReSharper", "SA1623", Justification = "For Rider")]
        public static DateTime Now => function?.Invoke() ?? DateTime.Now;

        #endregion

        #region Méthodes publiques

        /// <summary>Méthode de remise à zéro de la fonction <see cref="Now" />.</summary>
        public static void Reset() => function = () => DateTime.Now;

        /// <summary>Définit la fonction <see cref="function" />, appelée par la propriété <see cref="Now" />.</summary>
        /// <param name="value">La fonction appelée par <see cref="Now" />.</param>
        public static void SetFunctionNow(Func<DateTime> value)
            => function = value ?? (() => DateTime.Now);

        #endregion
    }
}
