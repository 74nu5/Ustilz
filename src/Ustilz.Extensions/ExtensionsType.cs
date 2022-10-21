namespace Ustilz.Extensions;

using System.Linq.Expressions;
using System.Reflection;

using JetBrains.Annotations;

using Ustilz.Utils;

/// <summary>The extensions type.</summary>
[PublicAPI]
public static class ExtensionsType
{
    /// <summary>The ctor.</summary>
    /// <param name="type">The type.</param>
    /// <typeparam name="TResult">Type du résultat.</typeparam>
    /// <returns>The <see cref="Func{TResult}" />.</returns>
    /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas.</exception>
    /// <exception cref="ArgumentNullException">constructor is null.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="type" /> is null.</exception>
    /// <exception cref="ArgumentException">
    ///     TDelegate is not a delegate type. -or- body.Type represents a type that is not assignable to the return type of TDelegate. -or- parameters does
    ///     not contain the same number of elements as the list of parameters for TDelegate. -or- The <see cref="System.Linq.Expressions.Expression.Type"></see> property of an element of
    ///     parameters is not assignable from the type of the corresponding parameter type of TDelegate.
    /// </exception>
    public static Func<TResult> Ctor<TResult>(this Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var ci = GetConstructor(type, Type.EmptyTypes);
        return Expression.Lambda<Func<TResult>>(Expression.New(ci)).Compile();
    }

    /// <summary>The ctor.</summary>
    /// <param name="type">The type.</param>
    /// <typeparam name="TArg1">Type du premier argument.</typeparam>
    /// <typeparam name="TResult">Type du résultat.</typeparam>
    /// <returns>The <see cref="Func{T,TResult}" />.</returns>
    /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas.</exception>
    /// <exception cref="ArgumentNullException">constructor is null.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="type" /> is null.</exception>
    /// <exception cref="ArgumentException">
    ///     TDelegate is not a delegate type. -or- body.Type represents a type that is not assignable to the return type of TDelegate. -or- parameters does
    ///     not contain the same number of elements as the list of parameters for TDelegate. -or- The <see cref="System.Linq.Expressions.Expression.Type"></see> property of an element of
    ///     parameters is not assignable from the type of the corresponding parameter type of TDelegate.
    /// </exception>
    public static Func<TArg1, TResult> Ctor<TArg1, TResult>(this Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var ci = GetConstructor(type, typeof(TArg1));
        var param1 = Expression.Parameter(typeof(TArg1), nameof(TArg1));

        return Expression.Lambda<Func<TArg1, TResult>>(Expression.New(ci, param1), param1).Compile();
    }

    /// <summary>The ctor.</summary>
    /// <param name="type">The type.</param>
    /// <typeparam name="TArg1">Type du premier argument.</typeparam>
    /// <typeparam name="TArg2">Type du deuxième argument.</typeparam>
    /// <typeparam name="TResult">Type du résultat.</typeparam>
    /// <returns>The <see cref="Func{T1,T2,TResult}" />.</returns>
    /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas.</exception>
    /// <exception cref="ArgumentNullException">constructor is null.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="type" /> is null.</exception>
    /// <exception cref="ArgumentException">
    ///     TDelegate is not a delegate type. -or- body.Type represents a type that is not assignable to the return type of TDelegate. -or- parameters does
    ///     not contain the same number of elements as the list of parameters for TDelegate. -or- The <see cref="System.Linq.Expressions.Expression.Type"></see> property of an element of
    ///     parameters is not assignable from the type of the corresponding parameter type of TDelegate.
    /// </exception>
    public static Func<TArg1, TArg2, TResult> Ctor<TArg1, TArg2, TResult>(this Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var ci = GetConstructor(type, typeof(TArg1), typeof(TArg2));
        var param1 = Expression.Parameter(typeof(TArg1), nameof(TArg1));
        var param2 = Expression.Parameter(typeof(TArg2), nameof(TArg2));

        return Expression.Lambda<Func<TArg1, TArg2, TResult>>(Expression.New(ci, param1, param2), param1, param2).Compile();
    }

    /// <summary>The ctor.</summary>
    /// <param name="type">The type.</param>
    /// <typeparam name="TArg1">Type du premier argument.</typeparam>
    /// <typeparam name="TArg2">Type du deuxième argument.</typeparam>
    /// <typeparam name="TArg3">Type du troisième argument.</typeparam>
    /// <typeparam name="TResult">Type du résultat.</typeparam>
    /// <returns>The <see cref="Func{T1,T2,T3,TResult}" />.</returns>
    /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas.</exception>
    /// <exception cref="ArgumentNullException">constructor is null.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="type" /> is null.</exception>
    /// <exception cref="ArgumentException">
    ///     TDelegate is not a delegate type. -or- body.Type represents a type that is not assignable to the return type of TDelegate. -or- parameters does
    ///     not contain the same number of elements as the list of parameters for TDelegate. -or- The <see cref="System.Linq.Expressions.Expression.Type"></see> property of an element of
    ///     parameters is not assignable from the type of the corresponding parameter type of TDelegate.
    /// </exception>
    public static Func<TArg1, TArg2, TArg3, TResult> Ctor<TArg1, TArg2, TArg3, TResult>(this Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var ci = GetConstructor(type, typeof(TArg1), typeof(TArg2), typeof(TArg3));

        var param1 = Expression.Parameter(typeof(TArg1), nameof(TArg1));
        var param2 = Expression.Parameter(typeof(TArg2), nameof(TArg2));
        var param3 = Expression.Parameter(typeof(TArg3), nameof(TArg3));

        return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(Expression.New(ci, param1, param2, param3), param1, param2, param3).Compile();
    }

    /// <summary>The ctor.</summary>
    /// <param name="type">The type.</param>
    /// <typeparam name="TArg1">Type du premier argument.</typeparam>
    /// <typeparam name="TArg2">Type du deuxième argument.</typeparam>
    /// <typeparam name="TArg3">Type du troisième argument.</typeparam>
    /// <typeparam name="TArg4">Type du quatrième argument.</typeparam>
    /// <typeparam name="TResult">Type du résultat.</typeparam>
    /// <returns>The <see cref="Func{T1,T2,T3,T4,TResult}" />.</returns>
    /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas.</exception>
    /// <exception cref="ArgumentNullException">constructor is null.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="type" /> is null.</exception>
    /// <exception cref="ArgumentException">
    ///     TDelegate is not a delegate type. -or- body.Type represents a type that is not assignable to the return type of TDelegate. -or- parameters does
    ///     not contain the same number of elements as the list of parameters for TDelegate. -or- The <see cref="System.Linq.Expressions.Expression.Type"></see> property of an element of
    ///     parameters is not assignable from the type of the corresponding parameter type of TDelegate.
    /// </exception>
    public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Ctor<TArg1, TArg2, TArg3, TArg4, TResult>(this Type type)
    {
        ArgumentNullException.ThrowIfNull(type);

        var ci = GetConstructor(type, typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4));

        var param1 = Expression.Parameter(typeof(TArg1), nameof(TArg1));
        var param2 = Expression.Parameter(typeof(TArg2), nameof(TArg2));
        var param3 = Expression.Parameter(typeof(TArg3), nameof(TArg3));
        var param4 = Expression.Parameter(typeof(TArg4), nameof(TArg4));

        return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(Expression.New(ci, param1, param2, param3, param4), param1, param2, param3, param4).Compile();
    }

    /// <summary>The get constructor.</summary>
    /// <param name="type">The type.</param>
    /// <param name="argumentTypes">The argument types.</param>
    /// <returns>The <see cref="ConstructorInfo" />.</returns>
    /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas.</exception>
    private static ConstructorInfo GetConstructor(Type type, params Type[] argumentTypes)
    {
        ArgumentNullException.ThrowIfNull(argumentTypes);
        ArgumentNullException.ThrowIfNull(type);

        return type.GetConstructor(argumentTypes) ??
               throw new InvalidOperationException($"{type.Name} has no ctor({string.Join(", ", argumentTypes.Select(t => t.Name))})");
    }
}
