// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ArgumentEmptyException.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ustilz.Arguments.Exceptions
{
    #region Usings

    using System;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The argument empty exception.</summary>
    [PublicAPI]
    public class ArgumentEmptyException : ArgumentException
    {
        /// <summary>The nu l_ o u_ vide.</summary>
        private const string NUL_OU_VIDE = "L'argument est nul ou vide.";

        /// <summary>Initializes a new instance of the <see cref="ArgumentEmptyException"/> class.</summary>
        public ArgumentEmptyException()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ArgumentEmptyException"/> class. Initializes a new instance of the <see cref="ArgumentEmptyException"/> avec un message d'erreur
        ///     spécifié et une référence à l'exception interne ayant provoqué cette exception.</summary>
        /// <param name="innerException">Exception ayant provoqué l'exception actuelle.Si le paramètre<paramref name="innerException"/> n'est pas une
        ///     référence null, l'exception actuelle est levée dans un bloc catch
        ///     qui gère l'exception interne.</param>
        public ArgumentEmptyException(Exception innerException)
            : base(NUL_OU_VIDE, innerException)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ArgumentEmptyException"/> class. Initialise une nouvelle instance de
        ///     la classe <see cref="T:System.ArgumentException"/> avec un message d'erreur
        ///     spécifié, le nom du paramètre et une référence à l'exception interne ayant provoqué cette exception.</summary>
        /// <param name="paramName">Nom du paramètre ayant provoqué l'exception actuelle. </param>
        /// <param name="innerException">Exception ayant provoqué l'exception actuelle.Si le paramètre<paramref name="innerException"/> n'est pas une
        ///     référence null, l'exception actuelle est levée dans un bloc catch
        ///     qui gère l'exception interne.</param>
        public ArgumentEmptyException([InvokerParameterName] string paramName, Exception innerException)
            : base(NUL_OU_VIDE, paramName, innerException)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ArgumentEmptyException"/> class. Initialise une nouvelle instance de
        ///     la classe <see cref="T:System.ArgumentException"/> avec un message d'erreur
        ///     spécifié et le nom du paramètre ayant provoqué l'exception.</summary>
        /// <param name="paramName">Nom du paramètre ayant provoqué l'exception actuelle. </param>
        public ArgumentEmptyException([InvokerParameterName] string paramName)
            : base(NUL_OU_VIDE, paramName)
        {
        }
    }
}