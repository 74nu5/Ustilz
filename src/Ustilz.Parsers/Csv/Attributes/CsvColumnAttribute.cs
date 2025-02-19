namespace Ustilz.Parsers.Csv.Attributes;

using JetBrains.Annotations;

/// <summary>
///     Attribute to define a column in a CSV file.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
[PublicAPI]
public class CsvColumnAttribute
        : Attribute
{
    /// <summary>
    ///     Attribute to define a column in a CSV file.
    /// </summary>
    /// <param name="columnName">Name of the column.</param>
    public CsvColumnAttribute(string columnName)
        => this.Name = columnName;

    /// <summary>
    ///     Gets the name of the column.
    /// </summary>
    public string Name { get; }

    /// <summary>
    ///     Gets or sets the index of the column.
    /// </summary>
    public int Index { get; set; } = -1;

    /// <summary>
    ///     Gets or sets the index of the column among homonymous columns.
    /// </summary>
    /// <remarks>Base 1. Default is 1.</remarks>
    public int HomonymNumber { get; set; } = 1;

    /// <summary>
    ///     Gets or sets the culture of the column.
    /// </summary>
    public string Culture { get; set; } = "fr-FR";

    /// <summary>
    ///     Gets or sets the character to replace with the default value.
    /// </summary>
    public char CharReplaceByDefaultValue { get; set; } = '\0';

    /// <summary>
    ///     Gets or sets the value to ignore.
    /// </summary>
    public string IgnoreValue { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets a value indicating whether the column is nullable.
    /// </summary>
    public bool Nullable { get; set; }
}

/// <summary>
///     Attribute to define a typed column in a CSV file.
/// </summary>
/// <typeparam name="TColumnType">Type of the column.</typeparam>
[PublicAPI]
public class CsvColumnAttribute<TColumnType>
        : CsvColumnAttribute
        where TColumnType : IParsable<TColumnType>
{
    /// <summary>
    ///     Attribute to define a typed column in a CSV file.
    /// </summary>
    /// <param name="columnName">Name of the column.</param>
    public CsvColumnAttribute(string columnName)
            : base(columnName)
    {
    }
}
