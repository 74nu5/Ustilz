namespace Ustilz.Extensions.Test.String
{
    #region Usings

    using Ustilz.Extensions.Strings;
    using Ustilz.Test.Models;

    using Xunit;

    #endregion

    /// <summary>The extensions string.</summary>
    public sealed partial class ExtensionsStringTest
    {
        /// <summary>
        /// The fs Ano test.
        /// </summary>
        [Fact]
        public void FsAnoTest()
        {
            const string Expected = "Bonjour John Smith";
            const string Pattern = "Bonjour @{Prenom} @{Nom}";

            var result = Pattern.Fs(new { Prenom = "John", Nom = "Smith" });

            Assert.Equal(Expected, result);
        }

        /// <summary>The fs test.</summary>
        [Fact]
        public void FsDtoTest()
        {
            const string Expected = "Bonjour John Smith";
            const string Pattern = "Bonjour @{Prenom} @{Nom}";

            var p = new Personne { Prenom = "John", Nom = "Smith" };

            var result = Pattern.Fs(p);

            Assert.Equal(Expected, result);
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
    }
}
