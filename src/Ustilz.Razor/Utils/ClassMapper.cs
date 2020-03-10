namespace Ustilz.Razor.Utils
{
    #region Usings

    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>Class of css class mapper.</summary>
    [PublicAPI]
    public class ClassMapper : BaseMapper
    {
        /// <summary>Method which joins all css classes.</summary>
        /// <returns>Returns all css classes join.</returns>
        public string AsString()
            => string.Join(" ", this.Items.Select(i => i()).Where(i => i != null));

        /// <summary>Method which print css classes.</summary>
        /// <returns>Returns all css classes.</returns>
        public override string ToString()
            => this.AsString();
    }
}
