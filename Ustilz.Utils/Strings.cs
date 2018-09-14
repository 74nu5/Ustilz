namespace Ustilz.Utils
{
    #region Usings

    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The strings.</summary>
    [PublicAPI]
    public static class Strings
    {
        #region Champs et constantes statiques

        /// <summary>The resource manager.</summary>
        private static readonly ResourceManager ResourceManager;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes static members of the <see cref="Strings" /> class.</summary>
        static Strings() => ResourceManager = new ResourceManager("Adm.Cds.Common.Standard.Properties.CoreStrings", typeof(Strings).GetTypeInfo().Assembly);

        #endregion

        #region Méthodes publiques

        /// <summary>The string argument '{argumentName}' cannot be empty.</summary>
        /// <param name="argumentName">The argument Name.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string ArgumentIsEmpty([CanBeNull] object argumentName)
            => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), new[] { argumentName });

        /// <summary>The property '{property}' of the argument '{argument}' cannot be null.</summary>
        /// <param name="property">The property.</param>
        /// <param name="argument">The argument.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string ArgumentPropertyNull([CanBeNull] object property, [CanBeNull] object argument)
            => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyNull", "property", "argument"), property, argument);

        /// <summary>The collection argument '{argumentName}' must contain at least one element.</summary>
        /// <param name="argumentName">The argument Name.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string CollectionArgumentIsEmpty([CanBeNull] object argumentName)
            => string.Format(CultureInfo.CurrentCulture, GetString("CollectionArgumentIsEmpty", "argumentName"), new[] { argumentName });

        /// <summary>The generer initiales.</summary>
        /// <param name="nom">The nom.</param>
        /// <returns>The <see cref="string" />.</returns>
        [CanBeNull]
        public static string GenererInitiales([CanBeNull] this string nom) => nom?.Substring(0, 1).ToUpper();

        /// <summary>The entity type '{type}' provided for the argument '{argumentName}' must be a reference type.</summary>
        /// <param name="type">The type.</param>
        /// <param name="argumentName">The argument Name.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string InvalidEntityType([CanBeNull] object type, [CanBeNull] object argumentName) => string.Format(CultureInfo.CurrentCulture,
            GetString("InvalidEntityType", "type", "argumentName"), new[] { type, argumentName });

        #endregion

        #region Méthodes privées

        /// <summary>The get string.</summary>
        /// <param name="name">The name.</param>
        /// <param name="formatterNames">The formatter names.</param>
        /// <returns>The <see cref="string" />.</returns>
        private static string GetString(string name, params string[] formatterNames)
        {
            var str = ResourceManager.GetString(name);
            if (formatterNames == null)
            {
                return str;
            }

            for (var index = 0; index < formatterNames.Length; ++index)
            {
                str = str.Replace("{" + formatterNames[index] + "}", "{" + index + "}");
            }

            return str;
        }

        #endregion
    }
}
