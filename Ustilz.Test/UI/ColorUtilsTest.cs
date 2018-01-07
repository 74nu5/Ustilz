using System;
using System.Collections.Generic;
using System.Text;

namespace Ustilz.Test.UI
{
    using Ustilz.UI;
    using Xunit;

    public class ColorUtilsTest
    {
        [Fact]
        public void GenererCouleursTest()
        {
            var couleur = ColorUtils.GenererCouleur();
            Assert.Equal(6, couleur.Length);
        }

        [Theory]
        [InlineData("123")]
        [InlineData("1234")]
        [InlineData("FFDGZZ")]
        [InlineData("dfDFe")]
        public void GetColorFromNomTestNominal(string nom)
        {
            var colorFromNom = ColorUtils.GetColorFromNom(nom);
            Assert.Equal(7, colorFromNom.Length);
        }
    }
}
