namespace Ustilz.Enums
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    using Ustilz.Annotations;

    #endregion

    /// <summary> The enum helper. </summary>
    /// <typeparam name="T"> The T </typeparam>
    [PublicAPI]
    public static class EnumHelper<T>
    {
        #region Méthodes publiques

        /// <summary> The get enum description. </summary>
        /// <param name="value"> The value. </param>
        /// <returns> The <see cref="string" />. </returns>
        public static string GetEnumDescription(T value)
        {
            var type = typeof(T);

            if (type.BaseType != typeof(Enum))
            {
                throw new ArgumentException("Le type fournit n'est pas une enumération.");
            }

            var name =
                Enum.GetNames(type)
                    .Where(f => Equals(value, StringComparison.CurrentCultureIgnoreCase))
                    .Select(d => d)
                    .FirstOrDefault();

            if (name == null)
            {
                return string.Empty;
            }

            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;

            return customAttribute != null ? customAttribute.Description : name;
        }

        /// <summary>
        /// To the description dictionary.
        /// </summary>
        /// <returns>Retourne un dictionnaire { key = name, value = description } pour une enum</returns>
        public static Dictionary<string, string> ToDescriptionDictionary()
        {
            var type = typeof(T);
            if (type.BaseType != typeof(Enum))
            {
                throw new ArgumentException("Le type fournit n'est pas une enumération.");
            }

            var names = Enum.GetNames(type);
            return names.ToDictionary(
                name => name,
                name =>
                    (type.GetField(name).GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute)?
                    .Description);
        }

        #endregion
    }

    public enum Toto
    {
        [Description("kdjfhgdfkgjh sdfkghs dklfjh sdlkjfhljfg")]
        DV,

        IATA,

        eBillet
    }
}
