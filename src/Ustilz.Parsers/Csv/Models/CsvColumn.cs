namespace Ustilz.Parsers.Csv.Models;

using System.Globalization;

/// <summary>
///     Représente une colonne d'un fichier CSV.
/// </summary>
/// <param name="columnName">Nom de la colonne.</param>
/// <param name="columnType">Type de la colonne.</param>
internal class CsvColumn(string columnName, Type columnType)
{
    /// <summary>
    ///     Obtient le nom de la colonne.
    /// </summary>
    public string Name { get; } = columnName;

    /// <summary>
    ///     Obtient le type de la colonne.
    /// </summary>
    public Type Type { get; } = columnType;

    /// <summary>
    ///     Obtient l'index de la colonne.
    /// </summary>
    public int Index { get; set; } = -1;

    /// <summary>
    ///     Obtient le nom de la propriété lié à la colonne.
    /// </summary>
    public string PropertyName { get; init; } = string.Empty;

    /// <summary>
    ///     Obtient la culture de la colonne.
    /// </summary>
    public CultureInfo Culture { get; init; } = CultureInfo.CurrentCulture;

    /// <summary>
    ///     Obtient le caractère à remplacer par la valeur par défaut.
    /// </summary>
    public char CharReplaceByDefaultValue { get; init; } = '\0';

    /// <summary>
    ///    Obtient ou définit la valeur à ignorer.
    /// </summary>
    public string IgnoreValue { get; init; } = string.Empty;
}
