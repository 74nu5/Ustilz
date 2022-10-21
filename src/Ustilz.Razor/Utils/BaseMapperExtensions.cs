namespace Ustilz.Razor.Utils;

using System;

using JetBrains.Annotations;

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
        _ = name ?? throw new ArgumentNullException(nameof(name));
        _ = m ?? throw new ArgumentNullException(nameof(m));

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
        _ = funcName ?? throw new ArgumentNullException(nameof(funcName));
        _ = m ?? throw new ArgumentNullException(nameof(m));

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
        _ = func ?? throw new ArgumentNullException(nameof(func));
        _ = funcName ?? throw new ArgumentNullException(nameof(funcName));
        _ = m ?? throw new ArgumentNullException(nameof(m));

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
        _ = func ?? throw new ArgumentNullException(nameof(func));
        _ = name ?? throw new ArgumentNullException(nameof(name));
        _ = m ?? throw new ArgumentNullException(nameof(m));

        m.Items.Add(() => func() ? name : null);
        return m;
    }
}