namespace Ustilz.Test.Extensions
{
    #region Usings

    using Ustilz.Extensions;
    using Ustilz.Extensions.Int32;

    using Xunit;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public partial class ExtensionsInt32Test
    {
        #region Méthodes privées

        /// <summary>The times test.</summary>
        [Fact]
        private void TimesTest()
        {
            var i = 0;
            5.Times(() => i++);
            Assert.Equal(5, i);
        }

        #endregion
    }
}