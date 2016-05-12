namespace Ustilz.Arguments
{
    #region Usings

    using System;

    using Ustilz.Annotations;
    using Ustilz.Arguments.Exceptions;

    #endregion

    /// <summary>The checker.</summary>
    public sealed class Checker
    {
        #region Champs

        /// <summary>The param name.</summary>
        private readonly string paramName;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Checker"/> class.</summary>
        /// <param name="paramName">The param name.</param>
        public Checker(string paramName)
        {
            this.paramName = paramName;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The less than.</summary>
        /// <param name="i">The i.</param>
        /// <param name="count">The count.</param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="ArgumentException"></exception>
        public void LessThan<T>(T i, T count) where T : struct, IComparable
        {
            if (i.CompareTo(count) == 1)
            {
                throw new ArgumentException($"Le parametre {this.paramName} est en dehors des valeurs requises.", this.paramName);
            }
        }

        /// <summary>The not null.</summary>
        /// <param name="o">The o.</param>
        /// <typeparam name="T"></typeparam>
        /// <exception cref="ArgumentNullException"></exception>
        public void NotNull<T>([CanBeNull] T o) where T : class
        {
            if (o == null)
            {
                throw new ArgumentNullException(this.paramName);
            }
        }

        /// <summary>The not null or empty.</summary>
        /// <param name="str">The str.</param>
        /// <exception cref="ArgumentEmptyException"></exception>
        public void NotNullOrEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                throw new ArgumentEmptyException(this.paramName);
            }
        }

        #endregion
    }
}