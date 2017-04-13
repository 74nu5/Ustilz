namespace Ustilz.Enums
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
#if NETSTANDARD1_6
    using System.ComponentModel.DataAnnotations;
#endif
    using System.Linq;
    using System.Reflection;

    using JetBrains.Annotations;

#endregion

    /// <summary> The enum helper. </summary>
    /// <typeparam name="T"> The T </typeparam>
    [PublicAPI]
    public static class EnumHelper<T>
    {
#region Méthodes publiques

        /// <summary> Méthode . </summary>
        /// <param name="value"> The value. </param>
        /// <returns> The <see cref="string" />. </returns>
        public static string GetEnumDescription(T value)
        {
            var type = typeof(T);
#if NETSTANDARD1_6
            if (type.GetTypeInfo().BaseType != typeof(Enum))
#else
            if (type.BaseType != typeof(Enum))
#endif
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

#if NETSTANDARD1_6
            var field = type.GetTypeInfo().GetField(name);
            var customAttribute = field.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
#else
            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
#endif


            return customAttribute != null ? customAttribute.Description : name;
        }

        /// <summary>
        /// To the description dictionary.
        /// </summary>
        /// <returns>Retourne un dictionnaire { key = name, value = description } pour une enum</returns>
        public static Dictionary<string, string> ToDescriptionDictionary()
        {
            var type = typeof(T);
#if NETSTANDARD1_6
            if (type.GetTypeInfo().BaseType != typeof(Enum))
#else
            if (type.BaseType != typeof(Enum))
#endif
            {
                throw new ArgumentException("Le type fournit n'est pas une enumération.");
            }

            var names = Enum.GetNames(type);
            return names.ToDictionary(
                name => name,
                name =>
#if NETSTANDARD1_6
                    (type.GetTypeInfo().GetField(name).GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute)?
#else
                    (type.GetField(name).GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute)?
#endif
                    .Description);
        }

#endregion
    }
}
