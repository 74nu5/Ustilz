namespace Ustilz.Utils;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

using JetBrains.Annotations;

/// <summary>The check.</summary>
[DebuggerStepThrough]
[PublicAPI]
public static class Check
{
    /// <summary>Method that ensure the value must be positive.</summary>
    /// <param name="numeric">Value to check.</param>
    /// <returns>Returns the value.</returns>
    public static int EnsurePositive(int numeric)
        => numeric switch
           {
               <= 0 => throw new ArgumentException(Strings.MustBePositive(numeric), nameof(numeric)),
               var _ => numeric
           };

    /// <summary>Method that ensure the value must be positive.</summary>
    /// <param name="numeric">Value to check.</param>
    /// <returns>Returns the value.</returns>
    public static double EnsurePositive(double numeric)
        => numeric switch
           {
               <= 0 => throw new ArgumentException(Strings.MustBePositive(numeric), nameof(numeric)),
               var _ => numeric
           };

    /// <summary>The has no nulls.</summary>
    /// <param name="collection">The value.</param>
    /// <param name="parameterName">The parameter name.</param>
    /// <typeparam name="T">Type de la valeur à tester.</typeparam>
    /// <returns>The IReadOnlyList.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="collection" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="parameterName" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">Collection has null.</exception>
    public static IReadOnlyList<T?> HasNoNulls<T>(IReadOnlyList<T?> collection, [InvokerParameterName] string parameterName)
        where T : class
    {
        _ = parameterName ?? throw new ArgumentNullException(nameof(parameterName));
        _ = collection ?? throw new ArgumentNullException(nameof(collection));

        NotNull(collection, parameterName);

        if (collection.All(e => e != null))
        {
            return collection;
        }

        NotEmpty(parameterName, nameof(parameterName));

        throw new ArgumentException(parameterName);
    }

    /// <summary>The not empty.</summary>
    /// <param name="value">The value.</param>
    /// <param name="parameterName">The parameter name.</param>
    /// <typeparam name="T">Type de la valeur à tester.</typeparam>
    /// <returns>The IReadOnlyList.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="value" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentNullException"><paramref name="parameterName" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">Collection is empty.</exception>
    [ContractAnnotation("value:null => halt")]
    public static IReadOnlyList<T?> NotEmpty<T>(IReadOnlyList<T?> value, [InvokerParameterName] string parameterName)
    {
        _ = parameterName ?? throw new ArgumentNullException(nameof(parameterName));
        _ = value ?? throw new ArgumentNullException(nameof(value));

        NotNull(value, parameterName);

        return value.Count switch
               {
                   0 => throw new ArgumentException(Strings.CollectionArgumentIsEmpty(parameterName)),
                   var _ => value
               };
    }

    /// <summary>The not empty.</summary>
    /// <param name="value">The value.</param>
    /// <param name="parameterName">The parameter name.</param>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentNullException"><paramref name="value" /> is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">Value is empty.</exception>
    [ContractAnnotation("value:null => halt")]
    public static string NotEmpty(string value, [InvokerParameterName] string parameterName)
        => value switch
           {
               null => throw new ArgumentNullException(value),
               { } v when v.Trim().Length == 0 => throw new ArgumentException(Strings.ArgumentIsEmpty(parameterName)),
               var _ => value
           };

    /// <summary>Méthode de vérification de la nullité de l'objet passé en paramètre.</summary>
    /// <param name="value">L'objet à vérifier.</param>
    /// <param name="parameterName">Nom du paramètre.</param>
    /// <typeparam name="T">Type de la valeur à tester.</typeparam>
    /// <returns>Retourne l'objet en entrée.</returns>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    /// <exception cref="ArgumentException">Value is empty.</exception>
    [ContractAnnotation("value:null => halt")]
    public static T NotNull<T>([NoEnumeration] T value, [InvokerParameterName] string parameterName)
    {
        if (value == null)
        {
            NotEmpty(parameterName, nameof(parameterName));

            throw new ArgumentNullException(parameterName);
        }

        return value;
    }

    /// <summary>Méthode de vérification de la nullité de l'objet passé en paramètre.</summary>
    /// <param name="value">L'objet à vérifier.</param>
    /// <param name="parameterName">Nom du paramètre.</param>
    /// <param name="propertyName">Nom de la propriété.</param>
    /// <typeparam name="T">Type de la valeur à tester.</typeparam>
    /// <returns>Retourne l'objet en entrée.</returns>
    /// <exception cref="ArgumentException">Value is null.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    [ContractAnnotation("value:null => halt")]
    public static T NotNull<T>([NoEnumeration] T value, [InvokerParameterName] string parameterName, string propertyName)
    {
        if (value != null)
        {
            return value;
        }

        NotEmpty(parameterName, nameof(parameterName));
        NotEmpty(propertyName, nameof(propertyName));

        throw new ArgumentException(Strings.ArgumentPropertyNull(propertyName, parameterName));
    }

    /// <summary>The null but not empty.</summary>
    /// <param name="value">The value.</param>
    /// <param name="parameterName">The parameter name.</param>
    /// <returns>The <see cref="string" />.</returns>
    /// <exception cref="ArgumentException">Value is null.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    public static string? NullButNotEmpty(string? value, [InvokerParameterName] string parameterName)
    {
        if (value is null || value.Length != 0)
        {
            return value;
        }

        NotEmpty(parameterName, nameof(parameterName));

        throw new ArgumentException(Strings.ArgumentIsEmpty(parameterName));
    }

    /// <summary>The valid entity type.</summary>
    /// <param name="value">The value.</param>
    /// <param name="parameterName">The parameter name.</param>
    /// <returns>The <see cref="Type" />.</returns>
    /// <exception cref="ArgumentException">Condition.</exception>
    /// <exception cref="ArgumentNullException">value is <see langword="null" />.</exception>
    public static Type ValidEntityType(Type value, [InvokerParameterName] string parameterName)
    {
        if (value.GetTypeInfo().IsClass)
        {
            return value;
        }

        NotEmpty(parameterName, nameof(parameterName));

        throw new ArgumentException(Strings.InvalidEntityType(value, parameterName));
    }
}
