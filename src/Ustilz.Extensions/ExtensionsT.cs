namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The extensions t. </summary>
    [PublicAPI]
    public static class ExtensionsT
    {
        /// <summary>Méthode de "transformation" d'objet en boolean.</summary>
        /// <typeparam name="T">Type à "transformer".</typeparam>
        /// <param name="transformObject">Objet à "transformer".</param>
        /// <returns>Retourne l'interprétation de l'objet passé en paramètre en booléen.</returns>
        public static bool AsBool<T>(this T transformObject)
            => transformObject switch
            {
                int n => n > 0,
                string s when bool.TryParse(s, out var b) => b,
                string s when int.TryParse(s, out var i) => i.AsBool(),
                string s => !string.IsNullOrEmpty(s),
                var _ => false
            };

        /// <summary>The between. </summary>
        /// <param name="value">The value. </param>
        /// <param name="from">The from. </param>
        /// <param name="to">The to. </param>
        /// <typeparam name="T">Type à comparer. </typeparam>
        /// <returns>The <see cref="bool" />. </returns>
        public static bool Between<T>(
            [System.Diagnostics.CodeAnalysis.NotNull]
            this T value,
            T from,
            T to)
            where T : IComparable<T>
            => value.CompareTo(from) >= 0 && value.CompareTo(to) <= 0;

        /// <summary>Executes the action specified, which the given object as parameter.</summary>
        /// <remarks>Use this method to chain method calls on the same object.</remarks>
        /// <param name="chainObject">The object to act on.</param>
        /// <param name="action">The action.</param>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <returns>Returns the given object.</returns>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        /// <exception cref="ArgumentNullException">The action can not be null.</exception>
        [System.Diagnostics.Contracts.Pure]
        public static T Chain<T>(
            [MaybeNull] this T chainObject,
            [System.Diagnostics.CodeAnalysis.NotNull]
            Action<T> action)
        {
            if (action is null)
            {
                throw new ArgumentNullException(nameof(action));
            }

            action(chainObject);
            return chainObject;
        }

        /// <summary>Méthode d'affichage d'un objet. </summary>
        /// <param name="o">L'objet à afficher. </param>
        /// <typeparam name="T">Type de l'objet. </typeparam>
        /// <returns>Retourne l'objet. </returns>
        /// <exception cref="IOException">An I/O error occurred.</exception>
        /// <exception cref="ArgumentNullException">values is null.</exception>
        /// <exception cref="InvalidCastException">An element in the sequence cannot be cast to type TResult.</exception>
        public static T Dump<T>(this T o)
        {
            if (o is IEnumerable list)
            {
                var enumerable = list as object[] ?? list.Cast<object>().ToArray();
                Console.WriteLine($@"[{string.Join(", ", enumerable.Select(t => t.Dump()).ToArray())}]");
                return o;
            }

            Console.WriteLine(o);
            return o;
        }

        /// <summary>Méthode de test du nullité d'une valeur, si la valeur est nulle la méthode renvoie la valeur par défaut renseignée.</summary>
        /// <param name="source">La valeur à tester.</param>
        /// <param name="defaultValue">La valeur par défaut.</param>
        /// <typeparam name="T">Type de l'objet.</typeparam>
        /// <returns>Retourne l'objet passé en entrée, la valeur par défaut si celle-ci est nulle.</returns>
        public static T IfNull<T>([MaybeNull] this T source, T defaultValue)
            where T : class
            => source ?? defaultValue;

        /// <summary>Vérifie si la valeur est présente dans le tableau donné.</summary>
        /// <param name="value">La valeur à rechercher.</param>
        /// <param name="values">Un tableau contenant les valeurs.</param>
        /// <typeparam name="T">Le type de la valeur.</typeparam>
        /// <returns>Renvoie true si la valeur est présente dans le tableau, false sinon.</returns>
        /// <exception cref="ArgumentNullException">Les valeurs ne peuvent pas être nulles.</exception>
        [System.Diagnostics.Contracts.Pure]
        public static bool IsIn<T>(
            [MaybeNull] this T value,
            [System.Diagnostics.CodeAnalysis.NotNull]
            params T[] values)
        {
            values.ThrowIfNull(nameof(values));
            return values.Contains(value);
        }

        /// <summary>Vérifie si la valeur est présente dans le IEnumerable donné.</summary>
        /// <param name="value">La valeur à rechercher.</param>
        /// <param name="values">Un IEnumerable contenant les valeurs.</param>
        /// <typeparam name="T">Le type de la valeur.</typeparam>
        /// <returns>Retourne true si la valeur est présente dans le IEnumerable, false sinon.</returns>
        /// <exception cref="ArgumentNullException">Les valeurs ne peuvent pas être nulles.</exception>
        [System.Diagnostics.Contracts.Pure]
        public static bool IsIn<T>(
            [MaybeNull] this T value,
            [System.Diagnostics.CodeAnalysis.NotNull]
            IEnumerable<T> values)
        {
            values.ThrowIfNull(nameof(values));
            return values.Contains(value);
        }

        /// <summary>Vérifie si la valeur n'est pas présente dans le tableau donné.</summary>
        /// <param name="value">La valeur à rechercher.</param>
        /// <param name="values">Un tableau contenant les valeurs.</param>
        /// <typeparam name="T">Le type de la valeur.</typeparam>
        /// <returns>Renvoie true si la valeur n'est pas présente dans le tableau, false sinon.</returns>
        /// <exception cref="ArgumentNullException">Les valeurs ne peuvent pas être nulles.</exception>
        [System.Diagnostics.Contracts.Pure]
        public static bool IsNotIn<T>(
            [MaybeNull] this T value,
            [System.Diagnostics.CodeAnalysis.NotNull]
            params T[] values)
            => !value.IsIn(values);

        /// <summary>Vérifie si la valeur n'est pas présente dans le IEnumerable donné.</summary>
        /// <param name="value">La valeur à rechercher.</param>
        /// <param name="values">Un IEnumerable contenant les valeurs.</param>
        /// <typeparam name="T">Le type de la valeur.</typeparam>
        /// <returns>Retourne true si la valeur n'est pas présente dans le IEnumerable, false sinon.</returns>
        /// <exception cref="ArgumentNullException">Les valeurs ne peuvent pas être nulles.</exception>
        [System.Diagnostics.Contracts.Pure]
        public static bool IsNotIn<T>(
            [MaybeNull] this T value,
            [System.Diagnostics.CodeAnalysis.NotNull]
            IEnumerable<T> values)
            => !value.IsIn(values);

        /// <summary>Détermine si l'objet n'est pas nul.</summary>
        /// <param name="source">L'objet à tester.</param>
        /// <typeparam name="T">Type de l'objet.</typeparam>
        /// <returns>Retourne true si l'objet n'est pas null, false sinon.</returns>
        [DebuggerStepThrough]
        public static bool IsNotNull<T>([MaybeNull] this T source)
            where T : class
            => source != null;

        /// <summary>Détermine si l'objet est nul.</summary>
        /// <param name="source">L'objet à tester.</param>
        /// <typeparam name="T">Type de l'objet.</typeparam>
        /// <returns>Retourne true si l'objet est null, false sinon.</returns>
        [DebuggerStepThrough]
        public static bool IsNull<T>([MaybeNull] this T source)
            where T : class
            => source == null;

#pragma warning disable IDE0060 // Supprimer le paramètre inutilisé
        /// <summary>Permute les valeurs données.</summary>
        /// <param name="nullObject">Un objet pour appeler la méthode d'extension, qui peut être nul.</param>
        /// <param name="value0">La première valeur.</param>
        /// <param name="value1">La deuxième valeur.</param>
        /// <typeparam name="T">Le type des valeurs.</typeparam>
        public static void Swap<T>([MaybeNull] this object nullObject, ref T value0, ref T value1) => (value0, value1) = (value1, value0);
#pragma warning restore IDE0060

        /// <summary>Lève une exception <see cref="ArgumentNullException" /> si <paramref name="testObject" /> est null.</summary>
        /// <remarks>Si <paramref name="errorMessage" /> est null, cette méthode utilisera le message par défaut suivant: "{nom d'objet} ne peut pas être nul".</remarks>
        /// <param name="testObject">The object to check.</param>
        /// <param name="parameterName">Le nom du paramètre <paramref name="testObject" />.</param>
        /// <param name="errorMessage">Le texte utilisé comme message d'exception si <paramref name="testObject" /> est nul.</param>
        /// <typeparam name="TObject">Le type de l'objet <paramref name="testObject" />.</typeparam>
        /// <exception cref="ArgumentNullException">Obj is null.</exception>
        [DebuggerStepThrough]
        [ContractAnnotation("testObject:null => halt")]
        public static void ThrowIfNull<TObject>(
            [MaybeNull] [NoEnumeration] this TObject testObject,
            [System.Diagnostics.CodeAnalysis.NotNull]
            string parameterName,
            string? errorMessage = null)
        {
            if (testObject != null)
            {
                return;
            }

            throw new ArgumentNullException(parameterName, errorMessage ?? $"{parameterName} can not be null.");
        }

        /// <summary>Méthode de conversion.</summary>
        /// <param name="value">Valeur à convertir.</param>
        /// <typeparam name="T">Type vers lequel convertir.</typeparam>
        /// <returns>Retourne l'objet convertit.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="value" /> is <see langword="null" />.</exception>
        [SuppressMessage("ReSharper", "MethodNameNotMeaningful", Justification = "Comprehensible")]
        [SuppressMessage("ReSharper", "CatchAllClause", Justification = "Obvious")]
        public static T To<T>(
            [System.Diagnostics.CodeAnalysis.NotNull]
            this IConvertible value)
            where T : new()
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            try
            {
                if (value.Equals(string.Empty))
                {
                    return new T();
                }

                var t = typeof(T);
                var u = Nullable.GetUnderlyingType(t);

                return u != null ? (T)Convert.ChangeType(value, u, CultureInfo.CurrentCulture) : (T)Convert.ChangeType(value, t, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return new T();
            }
        }

        /// <summary>Méthode de conversion.</summary>
        /// <param name="value">Valeur à convertir.</param>
        /// <param name="ifError">Valeur à renvoyer si la conversion échoue.</param>
        /// <typeparam name="T">Type vers lequel convertir.</typeparam>
        /// <returns>Retourne l'objet convertit.</returns>
        [SuppressMessage("ReSharper", "MethodNameNotMeaningful", Justification = "Comprehensible")]
        [SuppressMessage("ReSharper", "CatchAllClause", Justification = "Obvious")]
        public static T To<T>([MaybeNull] this IConvertible value, IConvertible ifError)
        {
            try
            {
                if (value == null || value.Equals(string.Empty))
                {
                    return (T)ifError;
                }

                var t = typeof(T);
                var u = Nullable.GetUnderlyingType(t);

                return u != null ? (T)Convert.ChangeType(value, u, CultureInfo.CurrentCulture) : (T)Convert.ChangeType(value, t, CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return (T)ifError;
            }
        }
    }
}
