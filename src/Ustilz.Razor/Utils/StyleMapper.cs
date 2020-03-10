namespace Ustilz.Razor.Utils
{
    #region Usings

    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Class of css style mapper.</summary>
    [PublicAPI]
    public class StyleMapper : BaseMapper
    {
        /// <summary>Method which joins all styles.</summary>
        /// <returns>Returns all the styles join.</returns>
        public string AsString()
            => string.Join("; ", this.Items.Select(i => i()).Where(i => i != null));

        /// <summary>Method which print all styles.</summary>
        /// <returns>Returns all the styles.</returns>
        public override string ToString()
            => this.AsString();
    }
}
