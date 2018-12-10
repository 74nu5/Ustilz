namespace Ustilz.Extensions.Test.Enumerables
{
    #region Usings

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    using JetBrains.Annotations;

    using Ustilz.Extensions.Enumerables;

    using Xunit;

    #endregion

    /// <summary>The extensions i enumerable.</summary>
    [PublicAPI]
    public class ExtensionsIEnumerableTest
    {
        #region Méthodes publiques

        /// <summary>The for each test.</summary>
        [Fact]
        public void ForEachTest()
        {
            IEnumerable<int> listeIn = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var listeTemp = new List<int>();
            IEnumerable<int> listeOut = new[] { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            listeIn.ForEach(i => listeTemp.Add(++i));
            Assert.Equal(listeOut, listeTemp);
        }

        /// <summary>The to hex string test.</summary>
        [Fact]
        public void ToHexStringTest()
        {
            byte[] tab = { 255, 255, 255 };
            Assert.Equal("FFFFFF", tab.ToHexString());
        }

        /// <summary>The to read only test.</summary>
        [Fact]
        public void ToReadOnlyTest()
        {
            IEnumerable<int> l = new List<int> { 1, 2, 3 };
            var ro = l.ToReadOnly();
            Assert.IsType<ReadOnlyCollection<int>>(ro);
        }

        #endregion
    }
}
