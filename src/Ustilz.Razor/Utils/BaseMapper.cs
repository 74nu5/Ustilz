namespace Ustilz.Razor.Utils
{
    #region Usings

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    ///     Base class for style and css class mapper.
    /// </summary>
    public class BaseMapper
    {
        #region Propriétés et indexeurs

        /// <summary>
        ///     Obtient la liste des éléments dans le mapper.
        /// </summary>
        public List<Func<string>> Items { get; } = new List<Func<string>>();

        #endregion
    }
}
