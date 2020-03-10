namespace Ustilz.Extensions.Actions
{
    #region Usings

    using System;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

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
        public static void ExecuteIfAnyFalse(this Action? falseAction, Action? trueAction = null, [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction!.Invoke();
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
            [CanBeNull] T parameter,
            Action<T>? trueAction = null,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction!.Invoke(parameter);
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
            [CanBeNull] T1 parameter1,
            [CanBeNull] T2 parameter2,
            Action<T1, T2>? trueAction = null,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction!.Invoke(parameter1, parameter2);
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
        /// <typeparam name="T4">The type of the fourth parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="parameter4">The fourth parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3>(
            this Action<T1, T2, T3>? falseAction,
            [CanBeNull] T1 parameter1,
            [CanBeNull] T2 parameter2,
            [CanBeNull] T3 parameter3,
            Action<T1, T2, T3>? trueAction = null,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction!.Invoke(parameter1, parameter2, parameter3);
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
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter1">The first parameter to pass to the action with gets executed.</param>
        /// <param name="parameter2">The second parameter to pass to the action with gets executed.</param>
        /// <param name="parameter3">The third parameter to pass to the action with gets executed.</param>
        /// <param name="trueAction">The action to execute if all values are true.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T1, T2, T3, T4>(
            this Action<T1, T2, T3, T4>? falseAction,
            [CanBeNull] T1 parameter1,
            [CanBeNull] T2 parameter2,
            [CanBeNull] T3 parameter3,
            [CanBeNull] T4 parameter4,
            Action<T1, T2, T3, T4>? trueAction = null,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.Any(x => !x()))
            {
                falseAction!.Invoke(parameter1, parameter2, parameter3, parameter4);
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
        public static void ExecuteIfAnyFalse(this Action? falseAction, [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction!.Invoke();
        }

        /// <summary>Executes the specified action if one of the given Boolean values is false.</summary>
        /// <exception cref="ArgumentNullException">FalseAction can not be null.</exception>
        /// <exception cref="ArgumentNullException">Values can not be null.</exception>
        /// <typeparam name="T">The type of the parameter.</typeparam>
        /// <param name="falseAction">The action to execute if any of the given values is false.</param>
        /// <param name="parameter">The parameter to pass to the action with gets executed.</param>
        /// <param name="values">The Boolean values to check.</param>
        [PublicAPI]
        public static void ExecuteIfAnyFalse<T>(this Action<T>? falseAction, [CanBeNull] T parameter, [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction!.Invoke(parameter);
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
            [CanBeNull] T1 parameter1,
            [CanBeNull] T2 parameter2,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction!.Invoke(parameter1, parameter2);
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
            [CanBeNull] T1 parameter1,
            [CanBeNull] T2 parameter2,
            [CanBeNull] T3 parameter3,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction!.Invoke(parameter1, parameter2, parameter3);
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
            [CanBeNull] T1 parameter1,
            [CanBeNull] T2 parameter2,
            [CanBeNull] T3 parameter3,
            [CanBeNull] T4 parameter4,
            [NotNull] params Func<bool>[] values)
        {
            falseAction.ThrowIfNull(nameof(falseAction));
            values.ThrowIfNull(nameof(values));

            if (values.All(x => x()))
            {
                return;
            }

            falseAction!.Invoke(parameter1, parameter2, parameter3, parameter4);
        }
    }
}
