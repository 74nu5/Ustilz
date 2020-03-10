namespace Ustilz.Utils
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Reflection;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The check.</summary>
    [DebuggerStepThrough]
    [PublicAPI]
    public static class Check
    {
        #region Méthodes publiques

        /// <summary>The has no nulls.</summary>
        /// <param name="collection">The value.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <typeparam name="T">Type de la valeur à tester.</typeparam>
        /// <returns>The IReadOnlyList.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="collection" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="parameterName" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">Collection has null.</exception>
        [NotNull]
        public static IReadOnlyList<T> HasNoNulls<T>([NotNull] IReadOnlyList<T> collection, [InvokerParameterName] [NotNull] string parameterName)
            where T : class
        {
            if (collection == null)
            {
                throw new ArgumentNullException(nameof(collection));
            }

            if (parameterName == null)
            {
                throw new ArgumentNullException(nameof(parameterName));
            }

            NotNull(collection, parameterName);

            if (collection.All(e => e != null))
            {
                return collection;
            }

            NotEmpty(parameterName, nameof(parameterName));

            throw new ArgumentException(parameterName);
        }

        /// <summary>The not empty.</summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <typeparam name="T">Type de la valeur à tester.</typeparam>
        /// <returns>The IReadOnlyList.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="value" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentNullException"><paramref name="parameterName" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">Collection is empty.</exception>
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static IReadOnlyList<T> NotEmpty<T>([NotNull] IReadOnlyList<T> value, [InvokerParameterName] [NotNull] string parameterName)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            if (parameterName == null)
            {
                throw new ArgumentNullException(nameof(parameterName));
            }

            NotNull(value, parameterName);

            if (value.Count != 0)
            {
                return value;
            }

            NotEmpty(parameterName, nameof(parameterName));

            throw new ArgumentException(Strings.CollectionArgumentIsEmpty(parameterName));
        }

        /// <summary>The not empty.</summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="value" /> is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">Value is empty.</exception>
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static string NotEmpty(string value, [InvokerParameterName] [NotNull] string parameterName)
        {
            if (value is null)
            {
                NotEmpty(parameterName, nameof(parameterName));
                throw new ArgumentNullException(parameterName);
            }

            if (value.Trim().Length != 0)
            {
                return value;
            }

            NotEmpty(parameterName, nameof(parameterName));
            throw new ArgumentException(Strings.ArgumentIsEmpty(parameterName));
        }

        /// <summary>Méthode de vérification de la nullité de l'objet passé en paramètre.</summary>
        /// <param name="value">L'objet à vérifier.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <typeparam name="T">Type de la valeur à tester.</typeparam>
        /// <returns>Retourne l'objet en entrée.</returns>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        /// <exception cref="ArgumentException">Value is empty.</exception>
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T NotNull<T>([NoEnumeration] T value, [InvokerParameterName] [NotNull] string parameterName)
        {
            if (value != null)
            {
                return value;
            }

            NotEmpty(parameterName, nameof(parameterName));

            throw new ArgumentNullException(parameterName);
        }

        /// <summary>Méthode de vérification de la nullité de l'objet passé en paramètre.</summary>
        /// <param name="value">L'objet à vérifier.</param>
        /// <param name="parameterName">Nom du paramètre.</param>
        /// <param name="propertyName">Nom de la propriété.</param>
        /// <typeparam name="T">Type de la valeur à tester.</typeparam>
        /// <returns>Retourne l'objet en entrée.</returns>
        /// <exception cref="ArgumentException">Value is null.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        [NotNull]
        [ContractAnnotation("value:null => halt")]
        public static T NotNull<T>([NoEnumeration] T value, [InvokerParameterName] [NotNull] string parameterName, [NotNull] string propertyName)
        {
            if (value != null)
            {
                return value;
            }

            NotEmpty(parameterName, nameof(parameterName));
            NotEmpty(propertyName, nameof(propertyName));

            throw new ArgumentException(Strings.ArgumentPropertyNull(propertyName, parameterName));
        }

        /// <summary>The null but not empty.</summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentException">Value is null.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        public static string? NullButNotEmpty(string? value, [InvokerParameterName] [NotNull] string parameterName)
        {
            if (value is null || value.Length != 0)
            {
                return value;
            }

            NotEmpty(parameterName, nameof(parameterName));

            throw new ArgumentException(Strings.ArgumentIsEmpty(parameterName));
        }

        /// <summary>The valid entity type.</summary>
        /// <param name="value">The value.</param>
        /// <param name="parameterName">The parameter name.</param>
        /// <returns>The <see cref="Type" />.</returns>
        /// <exception cref="ArgumentException">Condition.</exception>
        /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
        public static Type ValidEntityType(Type value, [InvokerParameterName] [NotNull] string parameterName)
        {
            if (value.GetTypeInfo().IsClass)
            {
                return value;
            }

            NotEmpty(parameterName, nameof(parameterName));

            throw new ArgumentException(Strings.InvalidEntityType(value, parameterName));
        }

        #endregion
    }
}
