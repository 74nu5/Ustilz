namespace Ustilz.Extensions.Actions
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using JetBrains.Annotations;

    /// <summary>Class containing some extension methods for <see cref="Action" />.</summary>
    public static partial class ExtensionsAction
    {
        /// <summary>Executes the specified action if one of the given Boolean values is false, otherwise it executes the specified true action, if one is specified.</summary>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="trueAction">The action to execute if all of the given value is true.</param>
        /// <param name="values">The Boolean values to check.</param>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [PublicAPI]
        public static void ExecuteIfAnyFalse(this Action falseAction, Action? trueAction = null, params Func<bool>[] values)
        {
            _ = falseAction ?? throw new ArgumentNullException(nameof(falseAction));
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction();
            }
            else
            {
                trueAction?.Invoke();
            }
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false, otherwise it executes the specified true action, if one is specified.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T>(
            this Action<T>? falseAction,
            T parameter,
            Action<T>? trueAction = null,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction?.Invoke(parameter);
            }
            else
            {
                trueAction?.Invoke(parameter);
            }
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false, otherwise it executes the specified true action, if one is specified.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2>(
            this Action<T1, T2>? falseAction,
            T1 parameter1,
            T2 parameter2,
            Action<T1, T2>? trueAction = null,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction?.Invoke(parameter1, parameter2);
            }
            else
            {
                trueAction?.Invoke(parameter1, parameter2);
            }
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false, otherwise it executes the specified true action, if one is specified.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3>(
            this Action<T1, T2, T3>? falseAction,
            T1 parameter1,
            T2 parameter2,
            T3 parameter3,
            Action<T1, T2, T3>? trueAction = null,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction?.Invoke(parameter1, parameter2, parameter3);
            }
            else
            {
                trueAction?.Invoke(parameter1, parameter2, parameter3);
            }
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false, otherwise it executes the specified true action, if one is specified.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        [SuppressMessage("ReSharper", "TooManyArguments", Justification = "It's API purpose.")]
        public static void ExecuteIfAnyFalse<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4>? falseAction,
            T1 parameter1,
            T2 parameter2,
            T3 parameter3,
            T4 parameter4,
            Action<T1, T2, T3, T4>? trueAction = null,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction?.Invoke(parameter1, parameter2, parameter3, parameter4);
            }
            else
            {
                trueAction?.Invoke(parameter1, parameter2, parameter3, parameter4);
            }
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse(this Action falseAction, params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));
            _ = falseAction ?? throw new ArgumentNullException(nameof(falseAction));

            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.All(x => x()))
            {
                return;
            }

            falseAction();
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T>(this Action<T> falseAction, T parameter, params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));
            _ = falseAction ?? throw new ArgumentNullException(nameof(falseAction));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction(parameter);
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2>(
            this Action<T1, T2>? falseAction,
            T1 parameter1,
            T2 parameter2,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction?.Invoke(parameter1, parameter2);
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3>(
            this Action<T1, T2, T3>? falseAction,
            T1 parameter1,
            T2 parameter2,
            T3 parameter3,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction?.Invoke(parameter1, parameter2, parameter3);
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T1">The type of the first parameter.</typeparam>
        /// <typeparam name="T2">The type of the second parameter.</typeparam>
        /// <typeparam name="T3">The type of the third parameter.</typeparam>
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4>? falseAction,
            T1 parameter1,
            T2 parameter2,
            T3 parameter3,
            T4 parameter4,
            params Func<bool>[] values)
        {
            _ = values ?? throw new ArgumentNullException(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction?.Invoke(parameter1, parameter2, parameter3, parameter4);
        }
    }
}
