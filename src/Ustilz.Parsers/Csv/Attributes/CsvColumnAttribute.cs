namespace Ustilz.Parsers.Csv.Attributes;

using JetBrains.Annotations;

/// <summary>
///     Attribut permettant de définir une colonne d'un fichier CSV.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
[PublicAPI]
public class CsvColumnAttribute
    : Attribute
{
    /// <summary>
    ///     Attribut permettant de définir une colonne d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    public CsvColumnAttribute(string columnName)
    {
        this.Name = columnName;
    }

    /// <summary>
    ///     Obtient le nom de la colonne.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Obtient ou définit l'index de la colonne.
    /// </summary>
    public int Index { get; set; } = -1;

    /// <summary>
    ///     Obtient ou définit la culture de la colonne.
    /// </summary>
    public string Culture { get; set; } = "fr-FR";

    /// <summary>
    ///     Obtient ou définit le caractère à remplacer par la valeur par défaut.
    /// </summary>
    public char CharReplaceByDefaultValue { get; set; } = '\0';

    /// <summary>
    ///    Obtient ou définit la valeur à ignorer.
    /// </summary>
    public string IgnoreValue { get; set; } = string.Empty;
}

/// <summary>
///     Attribut permettant de définir une colonne typée d'un fichier CSV.
/// </summary>
/// <typeparam name="TColumnType">Type de la colonne.</typeparam>
[PublicAPI]
public class CsvColumnAttribute<TColumnType>
    : CsvColumnAttribute
    where TColumnType : IParsable<TColumnType>
{
    /// <summary>
    ///     Attribut permettant de définir une colonne typée d'un fichier CSV.
    /// </summary>
    /// <param name="columnName">Nom de la colonne.</param>
    public CsvColumnAttribute(string columnName)
        : base(columnName)
    {
    }
}
