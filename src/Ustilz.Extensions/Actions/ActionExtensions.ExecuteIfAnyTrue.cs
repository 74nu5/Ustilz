namespace Ustilz.Extensions.Actions;

using System;
using System.Linq;

using JetBrains.Annotations;

/// <summary>Class containing some extension methods for <see cref="Action" />.</summary>
public static partial class ActionExtensions
{
    /// <summary>Executes the specified action if one of the given Boolean values is true, otherwise it executes the specified false action, if one is specified.</summary>
    /// <exception cref="ArgumentNullException">TrueAction can not be null.</exception>
    /// <exception cref="ArgumentNullException">Values can not be null.</exception>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="falseAction">The action to execute if any of the given values is false.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue(this Action? trueAction, Action? falseAction = null, params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Any(x => x()))
            trueAction?.Invoke();
        else
            falseAction?.Invoke();
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true, otherwise it executes the specified false action, if one is specified.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
    /// <param name="falseAction">The action to execute if any of the given values is false.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T>(
        this Action<T>? trueAction,
        T parameter,
        Action<T>? falseAction = null,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Any(x => x()))
            trueAction?.Invoke(parameter);
        else
            falseAction?.Invoke(parameter);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true, otherwise it executes the specified false action, if one is specified.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
    /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
    /// <param name="falseAction">The action to execute if any of the given values is false.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T1, T2>(
        this Action<T1, T2>? trueAction,
        T1 parameter1,
        T2 parameter2,
        Action<T1, T2>? falseAction = null,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Any(x => x()))
            trueAction?.Invoke(parameter1, parameter2);
        else
            falseAction?.Invoke(parameter1, parameter2);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true, otherwise it executes the specified false action, if one is specified.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
    /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
    /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
    /// <param name="falseAction">The action to execute if any of the given values is false.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T1, T2, T3>(
        this Action<T1, T2, T3>? trueAction,
        T1 parameter1,
        T2 parameter2,
        T3 parameter3,
        Action<T1, T2, T3>? falseAction = null,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Any(x => x()))
            trueAction?.Invoke(parameter1, parameter2, parameter3);
        else
            falseAction?.Invoke(parameter1, parameter2, parameter3);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true, otherwise it executes the specified false action, if one is specified.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
    /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
    /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
    /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
    /// <param name="falseAction">The action to execute if any of the given values is false.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4>? trueAction,
        T1 parameter1,
        T2 parameter2,
        T3 parameter3,
        T4 parameter4,
        Action<T1, T2, T3, T4>? falseAction = null,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (values.Any(x => x()))
            trueAction?.Invoke(parameter1, parameter2, parameter3, parameter4);
        else
            falseAction?.Invoke(parameter1, parameter2, parameter3, parameter4);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue(this Action? trueAction, params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (!values.Any(x => x()))
            return;

        trueAction?.Invoke();
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T>(this Action<T>? trueAction, T parameter, params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (!values.Any(x => x()))
            return;

        trueAction?.Invoke(parameter);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
    /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T1, T2>(
        this Action<T1, T2>? trueAction,
        T1 parameter1,
        T2 parameter2,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (!values.Any(x => x()))
            return;

        trueAction?.Invoke(parameter1, parameter2);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
    /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
    /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T1, T2, T3>(
        this Action<T1, T2, T3>? trueAction,
        T1 parameter1,
        T2 parameter2,
        T3 parameter3,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (!values.Any(x => x()))
            return;

        trueAction?.Invoke(parameter1, parameter2, parameter3);
    }

    /// <summary>Executes the specified action if one of the given Boolean values is true.</summary>
    /// <exception cref="ArgumentNullException">True action can not be null, if any value is true.</exception>
    /// <typeparam name="T1">The type of the first parameter.</typeparam>
    /// <typeparam name="T2">The type of the second parameter.</typeparam>
    /// <typeparam name="T3">The type of the third parameter.</typeparam>
    /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
    /// <param name="trueAction">The action to execute if one of the values is true.</param>
    /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
    /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
    /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
    /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
    /// <param name="values">The Boolean values to check.</param>
    [PublicAPI]
    public static void ExecuteIfAnyTrue<T1, T2, T3, T4>(
        this Action<T1, T2, T3, T4>? trueAction,
        T1 parameter1,
        T2 parameter2,
        T3 parameter3,
        T4 parameter4,
        params Func<bool>[] values)
    {
        ArgumentNullException.ThrowIfNull(values);

        if (!values.Any(x => x()))
            return;

        trueAction?.Invoke(parameter1, parameter2, parameter3, parameter4);
    }
}
