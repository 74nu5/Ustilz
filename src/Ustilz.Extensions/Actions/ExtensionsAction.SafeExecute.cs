namespace Ustilz.Extensions.Actions;

using System;

using JetBrains.Annotations;

using Ustilz.Extensions.Enumerables;

/// <summary>Class containing some extension methods for <see cref="Action" />.</summary>
public static partial class ExtensionsAction
{
    /// <summary>Executes the given action inside of a try catch block and catches all exceptions.</summary>
    /// <exception cref="ArgumentNullException">Action can not be null.</exception>
    /// <param name="action">The action to execute.</param>
    /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
    [PublicAPI]
    public static bool SafeExecute(this Action action)
    {
        ArgumentNullException.ThrowIfNull(action);

        try
        {
            action();
            return true;
        }
        catch
        {
            return false;
        }
    }

    /// <summary>Executes the given action inside of a try catch block. Catches exceptions of the given type.</summary>
    /// <exception cref="ArgumentNullException">Action can not be null.</exception>
    /// <typeparam name="TException">The type of the exception.</typeparam>
    /// <param name="action">The action to execute.</param>
    /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
    [PublicAPI]
    public static bool SafeExecute<TException>(this Action action)
        where TException : Exception
        => action.SafeExecute(typeof(TException));

    /// <summary>Executes the given action inside of a try catch block. Catches exceptions of the given types.</summary>
    /// <exception cref="ArgumentNullException">Action can not be null.</exception>
    /// <typeparam name="TException1">The first exception type to catch.</typeparam>
    /// <typeparam name="TException2">The second exception type to catch.</typeparam>
    /// <param name="action">The action to execute.</param>
    /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
    [PublicAPI]
    public static bool SafeExecute<TException1, TException2>(this Action action)
        where TException1 : Exception
        where TException2 : Exception
        => action.SafeExecute(typeof(TException1), typeof(TException2));

    /// <summary>Executes the given action inside of a try catch block. Catches exceptions of the given types.</summary>
    /// <exception cref="ArgumentNullException">Action can not be null.</exception>
    /// <typeparam name="TException1">The first exception type to catch.</typeparam>
    /// <typeparam name="TException2">The second exception type to catch.</typeparam>
    /// <typeparam name="TException3">The third exception type to catch.</typeparam>
    /// <param name="action">The action to execute.</param>
    /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
    [PublicAPI]
    public static bool SafeExecute<TException1, TException2, TException3>(this Action action)
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        => action.SafeExecute(typeof(TException1), typeof(TException2), typeof(TException3));

    /// <summary>Executes the given action inside of a try catch block. Catches exceptions of the given types.</summary>
    /// <exception cref="ArgumentNullException">Action can not be null.</exception>
    /// <typeparam name="TException1">The first exception type to catch.</typeparam>
    /// <typeparam name="TException2">The second exception type to catch.</typeparam>
    /// <typeparam name="TException3">The third exception type to catch.</typeparam>
    /// <typeparam name="TException4">The fourth exception type to catch.</typeparam>
    /// <param name="action">The action to execute.</param>
    /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
    [PublicAPI]
    public static bool SafeExecute<TException1, TException2, TException3, TException4>(this Action action)
        where TException1 : Exception
        where TException2 : Exception
        where TException3 : Exception
        where TException4 : Exception
        => action.SafeExecute(typeof(TException1), typeof(TException2), typeof(TException3), typeof(TException4));

    /// <summary>
    ///     Executes the given action inside of a try catch block. Catches all exception types contained in the given list of
    ///     exception types.
    /// </summary>
    /// <exception cref="ArgumentNullException">Action can not be null.</exception>
    /// <exception cref="ArgumentNullException">ExceptionsToCatch can not be null.</exception>
    /// <param name="action">The action to execute.</param>
    /// <param name="exceptionsToCatch">A list of exception types to catch.</param>
    /// <returns>Returns true if the action was executed without an exception, otherwise false.</returns>
    [PublicAPI]
    public static bool SafeExecute(this Action action, params Type[] exceptionsToCatch)
    {
        _ = exceptionsToCatch ?? throw new ArgumentNullException(nameof(exceptionsToCatch));
        _ = action ?? throw new ArgumentNullException(nameof(action));

        try
        {
            action.Invoke();
            return true;
        }
        catch (Exception ex)
        {
            if (exceptionsToCatch.NotAny(x => x == ex.GetType()))
            {
                throw;
            }

            return false;
        }
    }
}