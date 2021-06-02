namespace Ustilz.Utils
{
    using System;
    using System.Diagnostics.CodeAnalysis;

    using JetBrains.Annotations;

    /// <summary>Classe d'aide pour la lévée d'exception.</summary>
    [PublicAPI]
    [SuppressMessage("ReSharper", "HollowTypeName", Justification = "It's a helper !")]
    public static class ThrowHelper
    {
        /// <summary>Lève une exeption <see cref="ArgumentNullException" />.</summary>
        /// <param name="argument">Nom de l'argument.</param>
        /// <exception cref="ArgumentNullException">No condition.</exception>
        public static void ThrowArgumentNullException(string argument) => throw new ArgumentNullException(argument);

        /// <summary>Lève une exeption <see cref="ArgumentOutOfRangeException" />.</summary>
        /// <param name="argument">Nom de l'argument.</param>
        /// <exception cref="ArgumentOutOfRangeException">No condition.</exception>
        public static void ThrowArgumentOutOfRangeException(string argument) => throw new ArgumentOutOfRangeException(argument);

        /// <summary>Lève une exeption <see cref="InvalidOperationException" /> avec un message "Plus d'un élément trouvé".</summary>
        /// <exception cref="InvalidOperationException">No condition.</exception>
        public static void ThrowMoreThanOneElementException() => throw new InvalidOperationException(SR.MoreThanOneElement);

        /// <summary>Lève une exeption <see cref="InvalidOperationException" /> avec un message "Plus d'un élément correspond".</summary>
        /// <exception cref="InvalidOperationException">No condition.</exception>
        public static void ThrowMoreThanOneMatchException() => throw new InvalidOperationException(SR.MoreThanOneMatch);

        /// <summary>Lève une exeption <see cref="InvalidOperationException" /> avec un message "Aucun élément trouvé".</summary>
        /// <exception cref="InvalidOperationException">No condition.</exception>
        public static void ThrowNoElementsException() => throw new InvalidOperationException(SR.NoElements);

        /// <summary>Lève une exeption <see cref="InvalidOperationException" /> avec un message "Aucun élément ne correspond".</summary>
        /// <exception cref="InvalidOperationException">No condition.</exception>
        public static void ThrowNoMatchException() => throw new InvalidOperationException(SR.NoMatch);

        /// <summary>Lève une exeption <see cref="NotSupportedException" />.</summary>
        /// <exception cref="NotSupportedException">No condition.</exception>
        public static void ThrowNotSupportedException() => throw new NotSupportedException();
    }
}
