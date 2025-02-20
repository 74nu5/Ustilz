namespace Ustilz.Parsers.Csv.Models;

using System.Diagnostics;
using System.Globalization;

/// <summary>
///     Représente une colonne d'un fichier CSV.
/// </summary>
/// <param name="columnName">Nom de la colonne.</param>
/// <param name="columnType">Type de la colonne.</param>
/// <param name="nullable">Indique si la colonne est nullable.</param>
[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
internal class CsvColumn(string columnName, Type columnType, bool nullable)
{
    /// <summary>
    ///     Obtient le nom de la colonne.
    /// </summary>
    public string Name { get; } = columnName;

    /// <summary>
    ///     Obtient le numéro de la colonne colonne parmis les colonnes homonymes.
    /// </summary>
    /// <remarks>Base 1. Par défaut 1.</remarks>
    public int HomonymNumber { get; init; } = 1;

    /// <summary>
    ///     Obtient le type de la colonne.
    /// </summary>
    public Type Type { get; } = columnType;

    /// <summary>
    ///     Obtient une valeur indiquant si la colonne est nullable.
    /// </summary>
    public bool IsNullableColumn { get; } = nullable;

    /// <summary>
    ///     Obtient ou définit l'index de la colonne.
    /// </summary>
    public virtual int Index { get; set; } = -1;

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
    ///     Obtient ou définit la valeur à ignorer.
    /// </summary>
    public string IgnoreValue { get; init; } = string.Empty;

    /// <summary>
    ///     Obtient ou définit la clé de la méthode de parsing.
    /// </summary>
    public string ParseMethodInfoKey { get; set; } = string.Empty;

    private string GetDebuggerDisplay()
    {
        var nullable = this.IsNullableColumn ? "?" : string.Empty;
        return $"{this.Name} : {this.Type.Name}{nullable}";
    }
}
