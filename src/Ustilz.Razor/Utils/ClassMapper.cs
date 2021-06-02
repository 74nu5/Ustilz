namespace Ustilz.Razor.Utils
{
    using System.Linq;

    using JetBrains.Annotations;

    /// <summary>Class of css class mapper.</summary>
    [PublicAPI]
    public class ClassMapper : BaseMapper
    {
        /// <summary>Method which joins all css classes.</summary>
        /// <returns>Returns all css classes join.</returns>
        public string AsString()
            => string.Join(" ", this.Items.Select(i => i()));

        /// <summary>Method which print css classes.</summary>
        /// <returns>Returns all css classes.</returns>
        public override string ToString()
            => this.AsString();
    }
}
