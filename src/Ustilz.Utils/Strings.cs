namespace Ustilz.Utils
{
    #region Usings

    using System;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The strings.</summary>
    [PublicAPI]
    public static class Strings
    {
        /// <summary>The resource manager.</summary>
        private static readonly ResourceManager ResourceManager = new ResourceManager("Ustilz.Utils.Properties.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>The string argument '{argumentName}' cannot be empty.</summary>
        /// <param name="argumentName">The argument Name.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentNullException">format or args is null.</exception>
        /// <exception cref="FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
        public static string ArgumentIsEmpty(object? argumentName)
            => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), new[] { argumentName });

        /// <summary>The property '{property}' of the argument '{argument}' cannot be null.</summary>
        /// <param name="property">The property.</param>
        /// <param name="argument">The argument.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentNullException">format or args is null.</exception>
        /// <exception cref="FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
        public static string ArgumentPropertyNull(object? property, [CanBeNull] object argument)
            => string.Format(CultureInfo.CurrentCulture, GetString("ArgumentPropertyNull", "property", "argument"), property, argument);

        /// <summary>The collection argument '{argumentName}' must contain at least one element.</summary>
        /// <param name="argumentName">The argument Name.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentNullException">format or args is null.</exception>
        /// <exception cref="FormatException">format is invalid. -or- The index of a format item is less than zero, or greater than or equal to the length of the args array.</exception>
        public static string CollectionArgumentIsEmpty(object? argumentName)
            => string.Format(CultureInfo.CurrentCulture, GetString("CollectionArgumentIsEmpty", "argumentName"), new[] { argumentName });

        /// <summary>Méthode de génération des initiales.</summary>
        /// <param name="nom">The nom.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentOutOfRangeException">startIndex plus length indicates a position not within this instance. -or- startIndex or length is less than zero.</exception>
        /// <exception cref="ArgumentNullException">The property is set to null.</exception>
        public static string? GenerateInitials(this string? nom) => nom?.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture);

        /// <summary>The entity type '{type}' provided for the argument '{argumentName}' must be a reference type.</summary>
        /// <param name="type">The type.</param>
        /// <param name="argumentName">The argument Name.</param>
        /// <returns>The <see cref="string" />.</returns>
        /// <exception cref="ArgumentNullException">The property is set to null.</exception>
        public static string InvalidEntityType(object? type, object? argumentName) => string.Format(
            CultureInfo.CurrentCulture,
            GetString("InvalidEntityType", "type", "argumentName"),
            new[] { type, argumentName });

        /// <summary>The get string.</summary>
        /// <param name="name">The name.</param>
        /// <param name="formatterNames">The formatter names.</param>
        /// <returns>The <see cref="string" />.</returns>
        private static string GetString(string name, params string[]? formatterNames)
        {
            var str = ResourceManager.GetString(name, CultureInfo.CurrentCulture);
            if (str == null)
            {
                return name;
            }

            if (formatterNames == null)
            {
                return str;
            }

            for (var index = 0; index < formatterNames.Length; ++index)
            {
                str = str.Replace($"{{{formatterNames[index]}}}", $"{{{index}}}", StringComparison.CurrentCulture);
            }

            return str;
        }
    }
}
