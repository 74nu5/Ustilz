﻿namespace Ustilz.Enums
{
    #region Usings

    using System;
    using System.ComponentModel;
    using System.Linq;
    using System.Reflection;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The enum helper.</summary>
    /// <typeparam name="T">The T</typeparam>
    [PublicAPI]
    public static class EnumHelper<T>
    {
        /// <summary>The get enum description.</summary>
        /// <param name="value">The value.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetEnumDescription(string value)
        {
            var type = typeof(T);
            var name = Enum.GetNames(type).Where(f => f.Equals(value, StringComparison.CurrentCultureIgnoreCase)).Select(d => d).FirstOrDefault();

            if (name == null)
            {
                return string.Empty;
            }

            var field = type.GetField(name);
            var customAttribute = field.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;

            return customAttribute != null ? customAttribute.Description : name;
        }
    }
}