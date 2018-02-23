namespace Ustilz.Test.Enums
{
    #region Usings

    using System;
    using System.ComponentModel.DataAnnotations;

    using Ustilz.Enums;

    using Xunit;

    #endregion

    /// <summary>The enum helper.</summary>
    public sealed class EnumHelperTest
    {
        #region TestEnum enum

        /// <summary>The test enum.</summary>
        private enum TestEnum
        {
            /// <summary>The valeur 1.</summary>
            [Display]
            Valeur1,

            /// <summary>The valeur 2.</summary>
            Valeur2,

            /// <summary>The valeur 3.</summary>
            [Display(Description = "Troisième valeur")]
            Valeur3
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The test get enum description.</summary>
        [Fact]
        public void TestGetEnumDescriptionEmpty()
        {
            var descriptionValeur1 = EnumHelper.GetEnumDescription(TestEnum.Valeur1);
            Assert.Equal(string.Empty, descriptionValeur1);
        }

        /// <summary>The test get enum description without display.</summary>
        [Fact]
        public void TestGetEnumDescriptionWithoutDisplay()
        {
            var descriptionValeur2 = EnumHelper.GetEnumDescription(TestEnum.Valeur2);
            Assert.Equal("Valeur2", descriptionValeur2);
        }

        /// <summary>The test get enum description nominal.</summary>
        [Fact]
        public void TestGetEnumDescriptionNominal()
        {
            var descriptionValeur3 = EnumHelper.GetEnumDescription(TestEnum.Valeur3);
            Assert.Equal("Troisième valeur", descriptionValeur3);
        }

        /// <summary>The test get enum description not enum.</summary>
        [Fact]
        public void TestGetEnumDescriptionNotEnum()
        {
            var classe = new TestClasse();
            Assert.Throws<ArgumentException>("value", () => EnumHelper.GetEnumDescription(classe));
        }

        /// <summary>The test to description dictionary nominal.</summary>
        [Fact]
        public void TestToDescriptionDictionaryNominal()
        {
            var descriptionDictionary = EnumHelper.GetDescriptionDictionary<TestEnum>();
            Assert.NotEmpty(descriptionDictionary);
            Assert.Equal(3, descriptionDictionary.Count);
            Assert.Equal(string.Empty, descriptionDictionary["Valeur1"]);
            Assert.Null(descriptionDictionary["Valeur2"]);
            Assert.Equal("Troisième valeur", descriptionDictionary["Valeur3"]);
        }

        /// <summary>The test to description dictionary not enum.</summary>
        [Fact]
        public void TestToDescriptionDictionaryNotEnum() => Assert.Throws<ArgumentException>("T", () => EnumHelper.GetDescriptionDictionary<TestClasse>());

        #endregion

        #region Nested type: TestClasse

        /// <summary>The test classe.</summary>
        private class TestClasse
        {
        }

        #endregion
    }
}
