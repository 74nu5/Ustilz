namespace Ustilz.Razor.Utils;

using System;
using System.Collections.Generic;

/// <summary>
///     Base class for style and css class mapper.
/// </summary>
public class BaseMapper
{
    /// <summary>
    ///     Obtient la liste des éléments dans le mapper.
    /// </summary>
    public List<Func<string?>> Items { get; } = new ();
}
