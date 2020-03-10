namespace Ustilz.Extensions.Test.Int32
{
    #region Usings

    using Ustilz.Extensions.Int32;

    using Xunit;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public sealed partial class ExtensionsInt32Test
    {
        /// <summary>The times test.</summary>
        [Fact]
        private void TimesTest()
        {
            var i = 0;
            5.Times(() => i++);
            Assert.Equal(5, i);
        }
    }
}
