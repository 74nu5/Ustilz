namespace Ustilz.Test.Extensions
{
    #region Usings

    using Ustilz.Extensions;
    using Ustilz.Extensions.String;

    using Xunit;

    #endregion

    /// <summary>The extensions string.</summary>
    public partial class ExtensionsStringTest
    {
        #region Méthodes publiques

        /// <summary>The f test.</summary>
        [Fact]
        public void FTest()
        {
            const string Expected = "Bonjour le monde";
            const string Pattern = "Bonjour {0}";
            Assert.Equal(Expected, Pattern.F("le monde"));
        }

        /// <summary>The fs test.</summary>
        [Fact]
        public void FsTest()
        {
        }


        /// <summary>The hex to bytes test.</summary>
        [Fact]
        public void HexToBytesTest()
        {
        }

        /// <summary>The is null or empty test.</summary>
        [Fact]
        public void IsNullOrEmptyTest()
        {
        }

        /// <summary>The join test.</summary>
        [Fact]
        public void JoinTest()
        {
        }

        /// <summary>The to enum test.</summary>
        [Fact]
        public void ToEnumTest()
        {
        }

        /// <summary>The to exception test.</summary>
        [Fact]
        public void ToExceptionTest()
        {
        }

        #endregion
    }
}