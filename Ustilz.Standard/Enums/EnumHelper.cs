namespace Ustilz.Enums
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Reflection;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The enum helper. </summary>
    [PublicAPI]
    public static class EnumHelper
    {
        #region Méthodes publiques

        /// <summary>Méthode d'obtention de la description d'une valeur d'une énumération.</summary>
        /// <typeparam name="T">Type de l'énumération</typeparam>
        /// <param name="value">The value. </param>
        /// <returns>The <see cref="string"/>. </returns>
        public static string GetEnumDescription<T>(T value)
        {
            var type = typeof(T);
            if (type.GetTypeInfo().BaseType != typeof(Enum))
            {
                throw new ArgumentException("Le type fournit n'est pas une enumération.", nameof(value));
            }

            var name = Enum.GetNames(type).FirstOrDefault(f => string.Equals(f, value.ToString(), StringComparison.CurrentCultureIgnoreCase));

            var field = type.GetTypeInfo().GetField(name);

            return field.GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute customAttribute ? customAttribute.Description ?? string.Empty : name;
        }

        /// <summary>To the description dictionary.</summary>
        /// <typeparam name="T">Type de l'énumération</typeparam>
        /// <returns>Retourne un dictionnaire { key = name, value = description } pour une enum</returns>
        public static Dictionary<string, string> GetDescriptionDictionary<T>()
        {
            var type = typeof(T);
            if (type.GetTypeInfo().BaseType != typeof(Enum))
            {
                throw new TypeAccessException("Le type fournit n'est pas une enumération.");
            }

            var names = Enum.GetNames(type);

            string Selector(string name)
            {
                if (!(type.GetTypeInfo().GetField(name).GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute attribute))
                {
                    return null;
                }

                return attribute.Description ?? string.Empty;
            }

            return names.ToDictionary(name => name, Selector);
        }

        #endregion
    }
}
