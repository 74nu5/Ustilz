namespace Ustilz.Parsers.Csv.Attributes;

using System.Diagnostics.CodeAnalysis;

/// <summary>
///     Attribut permettant de définir une colonne dynamique d'un fichier CSV.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class CsvColumnDynamicAttribute : Attribute
{
    /// <summary>
    ///     Obtient ou définit une expression régulière permettant d'extraire une ou plusieurs valeurs du titre des colonnes.
    /// </summary>
    [StringSyntax(StringSyntaxAttribute.Regex)]
    public string HeaderRegex { get; set; } = string.Empty;
}

/// <summary>
///     Attribut permettant de définir une colonne typée d'un fichier CSV.
/// </summary>
/// <typeparam name="TColumnType">Type de la colonne.</typeparam>
public class CsvColumnDynamicAttribute<TColumnType>
        : CsvColumnDynamicAttribute
        where TColumnType : CsvColumnAttribute;
