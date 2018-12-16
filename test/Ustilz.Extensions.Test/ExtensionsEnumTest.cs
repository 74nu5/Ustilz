namespace Ustilz.Extensions.Test
{
    #region Usings

    using System.ComponentModel.DataAnnotations;

    using JetBrains.Annotations;

    using Xunit;

    #endregion

    /// <summary>The extensions enum.</summary>
    [PublicAPI]
    public sealed class ExtensionsEnumTest
    {
        #region Champs et constantes statiques

        /// <summary>The item.</summary>
        private const Test Item = Test.Item1;

        #endregion

        #region Méthodes publiques

        /// <summary>The in false test.</summary>
        [Fact]
        public void InFalseTest() => Assert.False(ExtensionsEnumTest.Item.In(Test.Item2, Test.Item3));

        /// <summary>The in true test.</summary>
        [Fact]
        public void InTrueTest() => Assert.True(ExtensionsEnumTest.Item.In(Test.Item1, Test.Item2, Test.Item3));

        /// <summary>The in test.</summary>
        [Fact]
        public void InVideTest() => Assert.False(ExtensionsEnumTest.Item.In());

        /// <summary>The test get enum description.</summary>
        [Fact]
        public void TestGetEnumDescriptionEmpty()
        {
            var descriptionValeur1 = TestEnum.Valeur1.GetEnumDescription();
            Assert.Equal(string.Empty, descriptionValeur1);
        }

        /// <summary>The test get enum description nominal.</summary>
        [Fact]
        public void TestGetEnumDescriptionNominal()
        {
            var descriptionValeur3 = TestEnum.Valeur3.GetEnumDescription();
            Assert.Equal("Troisième valeur", descriptionValeur3);
        }

        /// <summary>The test get enum description without display.</summary>
        [Fact]
        public void TestGetEnumDescriptionWithoutDisplay()
        {
            var descriptionValeur2 = TestEnum.Valeur2.GetEnumDescription();
            Assert.Equal("Valeur2", descriptionValeur2);
        }

        /// <summary>The test to description dictionary nominal.</summary>
        [Fact]
        public void TestToDescriptionDictionaryNominal()
        {
            var descriptionDictionary = ExtensionsEnum.GetDescriptionDictionary<TestEnum>();
            Assert.NotEmpty(descriptionDictionary);
            Assert.Equal(3, descriptionDictionary.Count);
            Assert.Equal(string.Empty, descriptionDictionary["Valeur1"]);
            Assert.Null(descriptionDictionary["Valeur2"]);
            Assert.Equal("Troisième valeur", descriptionDictionary["Valeur3"]);
        }

        #endregion

        /// <summary>The test.</summary>
        private enum Test
        {
            /// <summary>The item 1.</summary>
            Item1,

            /// <summary>The item 2.</summary>
            Item2,

            /// <summary>The item 3.</summary>
            Item3
        }

        /// <summary>The test enum.</summary>
        private enum TestEnum
        {
            /// <summary>The valeur 1.</summary>
            [Display] Valeur1,

            /// <summary>The valeur 2.</summary>
            Valeur2,

            /// <summary>The valeur 3.</summary>
            [Display(Description = "Troisième valeur")]
            Valeur3
        }
    }
}
