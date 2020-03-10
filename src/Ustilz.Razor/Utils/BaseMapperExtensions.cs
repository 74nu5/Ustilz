namespace Ustilz.Razor.Utils
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    #endregion

    /// <summary>
    ///     Extensions class of <see cref="BaseMapper" />.
    /// </summary>
    [PublicAPI]
    public static class BaseMapperExtensions
    {
        /// <summary>
        ///     Method which add a class by it name.
        /// </summary>
        /// <param name="m">The <see cref="BaseMapper" />.</param>
        /// <param name="name">The css class name.</param>
        /// <returns>Returns the <see cref="BaseMapper" />.</returns>
        public static BaseMapper Add(this BaseMapper m, string name)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            m.Items.Add(() => name);
            return m;
        }

        /// <summary>
        ///     Method which add a class by a function.
        /// </summary>
        /// <param name="m">The <see cref="BaseMapper" />.</param>
        /// <param name="funcName">The function which calculate css class name.</param>
        /// <returns>Returns the <see cref="BaseMapper" />.</returns>
        public static BaseMapper Add(this BaseMapper m, Func<string> funcName)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m));
            }

            if (funcName == null)
            {
                throw new ArgumentNullException(nameof(funcName));
            }

            m.Items.Add(funcName);
            return m;
        }

        /// <summary>
        ///     Method which add a class by a function with a function which indicating whether the css class can be apply.
        /// </summary>
        /// <param name="m">The <see cref="BaseMapper" />.</param>
        /// <param name="funcName">The function which calculate css class name.</param>
        /// <param name="func">The function which calculate whether the css class can be apply.</param>
        /// <returns>Returns the <see cref="BaseMapper" />.</returns>
        public static BaseMapper AddIf(this BaseMapper m, Func<string> funcName, Func<bool> func)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m));
            }

            if (funcName == null)
            {
                throw new ArgumentNullException(nameof(funcName));
            }

            if (func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            m.Items.Add(() => func() ? funcName() : null);
            return m;
        }

        /// <summary>
        ///     Method which add a class by it name with a function which indicating whether the css class can be apply.
        /// </summary>
        /// <param name="m">The <see cref="BaseMapper" />.</param>
        /// <param name="name">The css class name.</param>
        /// <param name="func">The function which calculate whether the css class can be apply.</param>
        /// <returns>Returns the <see cref="BaseMapper" />.</returns>
        public static BaseMapper AddIf(this BaseMapper m, string name, Func<bool> func)
        {
            if (m == null)
            {
                throw new ArgumentNullException(nameof(m));
            }

            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }

            m.Items.Add(() => func() ? name : null);
            return m;
        }
    }
}
