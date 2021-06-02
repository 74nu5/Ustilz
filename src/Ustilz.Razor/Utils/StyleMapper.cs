namespace Ustilz.Razor.Utils
{
    using System.Linq;

    using JetBrains.Annotations;

    /// <summary>Class of css style mapper.</summary>
    [PublicAPI]
    public class StyleMapper : BaseMapper
    {
        /// <summary>Method which joins all styles.</summary>
        /// <returns>Returns all the styles join.</returns>
        public string AsString()
            => string.Join("; ", this.Items.Select(i => i()));

        /// <summary>Method which print all styles.</summary>
        /// <returns>Returns all the styles.</returns>
        public override string ToString()
            => this.AsString();
    }
}
