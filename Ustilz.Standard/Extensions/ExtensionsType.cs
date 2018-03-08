namespace Ustilz.Extensions
{
    #region Usings

    using System;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;
    using JetBrains.Annotations;
    using Ustilz.Utils;

    #endregion

    /// <summary>The extensions type.</summary>
    [PublicAPI]
    public static class ExtensionsType
    {
        #region Méthodes publiques

        /// <summary>The ctor.</summary>
        /// <param name="type">The type.</param>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="Func{TResult}"/>.</returns>
        public static Func<TResult> Ctor<TResult>(this Type type)
        {
            var ci = GetConstructor(type, Type.EmptyTypes);
            return Expression.Lambda<Func<TResult>>(Expression.New(ci)).Compile();
        }

        /// <summary>The ctor.</summary>
        /// <param name="type">The type.</param>
        /// <typeparam name="TArg1">Type du premier argument</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="Func{T,TResult}"/>.</returns>
        public static Func<TArg1, TResult> Ctor<TArg1, TResult>(this Type type)
        {
            var ci = GetConstructor(type, typeof(TArg1));
            var param1 = Expression.Parameter(typeof(TArg1), "arg1");

            return Expression.Lambda<Func<TArg1, TResult>>(
                Expression.New(ci, param1), param1).Compile();
        }

        /// <summary>The ctor.</summary>
        /// <param name="type">The type.</param>
        /// <typeparam name="TArg1">Type du premier argument</typeparam>
        /// <typeparam name="TArg2">Type du deuxième argument</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="Func{T1,T2,TResult}"/>.</returns>
        public static Func<TArg1, TArg2, TResult> Ctor<TArg1, TArg2, TResult>(this Type type)
        {
            var ci = GetConstructor(type, typeof(TArg1), typeof(TArg2));
            var param1 = Expression.Parameter(typeof(TArg1), "arg1");
            var param2 = Expression.Parameter(typeof(TArg2), "arg2");

            return Expression.Lambda<Func<TArg1, TArg2, TResult>>(
                Expression.New(ci, param1, param2), param1, param2).Compile();
        }

        /// <summary>The ctor.</summary>
        /// <param name="type">The type.</param>
        /// <typeparam name="TArg1">Type du premier argument</typeparam>
        /// <typeparam name="TArg2">Type du deuxième argument</typeparam>
        /// <typeparam name="TArg3">Type du troisième argument</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="Func{T1,T2,T3,TResult}"/>.</returns>
        public static Func<TArg1, TArg2, TArg3, TResult> Ctor<TArg1, TArg2, TArg3, TResult>(this Type type)
        {
            var ci = GetConstructor(type, typeof(TArg1), typeof(TArg2), typeof(TArg3));

            var param1 = Expression.Parameter(typeof(TArg1), "arg1");
            var param2 = Expression.Parameter(typeof(TArg2), "arg2");
            var param3 = Expression.Parameter(typeof(TArg3), "arg3");

            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TResult>>(Expression.New(ci, param1, param2, param3), param1, param2, param3).Compile();
        }

        /// <summary>The ctor.</summary>
        /// <param name="type">The type.</param>
        /// <typeparam name="TArg1">Type du premier argument</typeparam>
        /// <typeparam name="TArg2">Type du deuxième argument</typeparam>
        /// <typeparam name="TArg3">Type du troisième argument</typeparam>
        /// <typeparam name="TArg4">Type du quatrième argument</typeparam>
        /// <typeparam name="TResult">Type du résultat</typeparam>
        /// <returns>The <see cref="Func{T1,T2,T3,T4,TResult}"/>.</returns>
        public static Func<TArg1, TArg2, TArg3, TArg4, TResult> Ctor<TArg1, TArg2, TArg3, TArg4, TResult>(this Type type)
        {
            var ci = GetConstructor(type, typeof(TArg1), typeof(TArg2), typeof(TArg3), typeof(TArg4));

            var param1 = Expression.Parameter(typeof(TArg1), "arg1");
            var param2 = Expression.Parameter(typeof(TArg2), "arg2");
            var param3 = Expression.Parameter(typeof(TArg3), "arg3");
            var param4 = Expression.Parameter(typeof(TArg4), "arg4");

            return Expression.Lambda<Func<TArg1, TArg2, TArg3, TArg4, TResult>>(Expression.New(ci, param1, param2, param3, param4), param1, param2, param3, param4).Compile();
        }

        #endregion

        #region Méthodes privées

        /// <summary>The get constructor.</summary>
        /// <param name="type">The type.</param>
        /// <param name="argumentTypes">The argument types.</param>
        /// <returns>The <see cref="ConstructorInfo"/>.</returns>
        /// <exception cref="InvalidOperationException">Lève une exception lorsque le constructeur n'existe pas</exception>
        private static ConstructorInfo GetConstructor(Type type, params Type[] argumentTypes)
        {
            Check.NotNull(type, nameof(type));
            Check.NotNull(argumentTypes, nameof(argumentTypes));

            var ci = type.GetConstructor(argumentTypes);
            if (ci != null)
            {
                return ci;
            }

            var sb = new StringBuilder();
            sb.Append(type.Name).Append(" has no ctor(");
            for (var i = 0; i < argumentTypes.Length; i++)
            {
                if (i > 0)
                {
                    sb.Append(',');
                }

                sb.Append(argumentTypes[i].Name);
            }

            sb.Append(')');
            throw new InvalidOperationException(sb.ToString());
        }

        #endregion
    }
}