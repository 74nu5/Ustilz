namespace Ustilz.Test.Extensions
{
    #region Usings

    using JetBrains.Annotations;
    using Ustilz.Extensions;
    using Xunit;

    #endregion

    /// <summary>The extensions enum.</summary>
    [PublicAPI]
    public static class ExtensionsEnumTest
    {
        #region Champs et constantes statiques

        /// <summary>The item.</summary>
        private const Test Item = Test.Item1;

        #endregion

        #region Test enum

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

        #endregion

        #region Méthodes publiques

        /// <summary>The in test.</summary>
        [Fact]
        public static void InVideTest() => Assert.False(Item.In());

        /// <summary>The in true test.</summary>
        [Fact]
        public static void InTrueTest() => Assert.True(Item.In(Test.Item1, Test.Item2, Test.Item3));

        /// <summary>The in false test.</summary>
        [Fact]
        public static void InFalseTest() => Assert.False(Item.In(Test.Item2, Test.Item3));

        #endregion
    }
}