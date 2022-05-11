namespace Ustilz.Utils;

using System;
using System.Globalization;
using System.Resources;

/// <summary>Classe d'accès aux ressources.</summary>
// ReSharper disable once InconsistentNaming
internal static class SR
{
    private static ResourceManager? resourceManager;

    /// <summary>Obtient le message "Enumeration yielded no results".</summary>
    internal static string? EmptyEnumerable => GetResourceString("EmptyEnumerable", @"Enumeration yielded no results");

    /// <summary>Obtient le message "Sequence contains more than one element".</summary>
    internal static string? MoreThanOneElement => GetResourceString("MoreThanOneElement", @"Sequence contains more than one element");

    /// <summary>Obtient le message "Sequence contains more than one matching element".</summary>
    internal static string? MoreThanOneMatch => GetResourceString("MoreThanOneMatch", @"Sequence contains more than one matching element");

    /// <summary>Obtient le message "Sequence contains no elements".</summary>
    internal static string? NoElements => GetResourceString("NoElements", @"Sequence contains no elements");

    /// <summary>Obtient le message "Sequence contains no matching element".</summary>
    internal static string? NoMatch => GetResourceString("NoMatch", @"Sequence contains no matching element");

    private static ResourceManager ResourceManager => resourceManager ??= new (typeof(SR));

    private static string? GetResourceString(string resourceKey, string? defaultString = null)
    {
        var resourceString = ResourceManager.GetString(resourceKey, CultureInfo.CurrentCulture);
        return defaultString != null && resourceKey.Equals(resourceString, StringComparison.Ordinal) ? defaultString : resourceString;
    }
}
