namespace Ustilz.Test.UI
{
    #region Usings

    using Ustilz.UI;

    using Xunit;

    #endregion

    /// <summary>The color utils test.</summary>
    public class ColorUtilsTest
    {
        #region Méthodes publiques

        /// <summary>The generer couleurs test.</summary>
        [Fact]
        public void GenererCouleursTest()
        {
            var couleur = ColorUtils.GenererCouleur();
            Assert.Equal(6, couleur.Length);
        }

        /// <summary>The get color from nom test nominal.</summary>
        /// <param name="nom">The nom.</param>
        [Theory]
        [InlineData("123")]
        [InlineData("1234")]
        [InlineData("FFDGZZ")]
        [InlineData("dfDFe")]
        public void GetColorFromNomTestNominal(
            string nom)
        {
            var colorFromNom = ColorUtils.GetColorFromNom(nom);
            Assert.Equal(7, colorFromNom.Length);
        }

        #endregion
    }
}