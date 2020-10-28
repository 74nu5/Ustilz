namespace Ustilz.Extensions.Test
{
    #region Usings

    using System;
    using System.Linq;

    using Ustilz.Extensions.Strings;
    using Ustilz.Time;

    using Xunit;

    #endregion

    /// <summary>The extensions t test.</summary>
    public sealed class ExtensionsTTest
    {
        /// <summary>The between test.</summary>
        [Fact]
        public void BetweenTest()
        {
            Assert.True(1.Between(0, 2));
            Assert.True(Clock.Now.Between(DateTime.MinValue, DateTime.MaxValue));
            Assert.False(50.Between(0, 2));
            Assert.False(42.Between(0, 2));
        }

        /// <summary>The chain test.</summary>
        [Fact]
        public void ChainTest()
        {
            var a = new A();

            void Action1(A s1)
                => a.I = 100;

            void Action2(A s2)
                => a.S = "Test";

#pragma warning disable IDE0009 // L'accès au membre doit être qualifié.
            var chain = a.Chain(Action1).Chain(Action2);
#pragma warning restore IDE0009 // L'accès au membre doit être qualifié.
            Assert.Equal(100, a.I);
            Assert.Equal("Test", a.S);
            Assert.Equal(100, chain.I);
            Assert.Equal("Test", chain.S);
        }

        /// <summary>The dump test.</summary>
        [Fact]
        public void DumpTest()
        {
            Assert.Equal(1, 1.Dump());

            var tab = new[] { 1, 2, 3, 4 };

            Assert.Equal(tab, tab.Dump());
        }

        /// <summary>The if null test.</summary>
        [Fact]
        public void IfNullTest()
        {
            string s = null;
            Assert.Equal(string.Empty, s.IfNull(string.Empty));

            s = "Test";
            Assert.Equal(s, s.IfNull(string.Empty));
        }

        /// <summary>The is in test.</summary>
        [Fact]
        public void IsInTest()
        {
            Assert.True(1.IsIn(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Assert.False(10.IsIn(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Assert.True(1.IsIn(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.AsEnumerable()));
            Assert.False(10.IsIn(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.AsEnumerable()));
        }

        /// <summary>The is not in test.</summary>
        [Fact]
        public void IsNotInTest()
        {
            Assert.False(1.IsNotIn(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Assert.True(10.IsNotIn(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Assert.False(1.IsNotIn(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.AsEnumerable()));
            Assert.True(10.IsNotIn(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.AsEnumerable()));
        }

        /// <summary>The if null test.</summary>
        [Fact]
        public void IsNotNullTest()
        {
            string s = null;
            Assert.False(s.IsNotNull());

            s = string.Empty;
            Assert.True(s.IsNotNull());

            s = "Test";
            Assert.True(s.IsNotNull());
        }

        /// <summary>The if null test.</summary>
        [Fact]
        public void IsNullOrEmptyTest()
        {
            Assert.True(string.IsNullOrEmpty(null));

            var s = string.Empty;
            Assert.True(s.IsNullOrEmpty());

            s = "Test";
            Assert.False(s.IsNullOrEmpty());
        }

        /// <summary>The if null test.</summary>
        [Fact]
        public void IsNullTest()
        {
            string s = null;
            Assert.True(s.IsNull());

            s = string.Empty;
            Assert.False(s.IsNull());

            s = "Test";
            Assert.False(s.IsNull());
        }

        /// <summary>
        /// The join test.
        /// </summary>
        [Fact]
        public void JoinTest()
        {
            Assert.False(1.IsNotIn(1, 2, 3, 4, 5, 6, 7, 8, 9));
            Assert.True(10.IsNotIn(1, 2, 3, 4, 5, 6, 7, 8, 9));

            Assert.False(1.IsNotIn(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.AsEnumerable()));
            Assert.True(10.IsNotIn(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }.AsEnumerable()));
        }

        /// <summary>The swap test.</summary>
        [Fact]
        public void SwapTest()
        {
            object tabInt = new[] { 1 };
            object tabString = new[] { "S" };

            1.Swap(ref tabInt, ref tabString);

            Assert.Equal("S", ((string[])tabInt)[0]);
            Assert.Equal(1, ((int[])tabString)[0]);
        }

        /// <summary>The throw if null test.</summary>
        [Fact]
        public void ThrowIfNullTest()
        {
            var s = string.Empty;
            s.ThrowIfNull(nameof(s), "Message d'erreur");
            s = null;
            var exception = Assert.Throws<ArgumentNullException>(() => s.ThrowIfNull(nameof(s), "Message d'erreur"));
            Assert.Equal("Message d'erreur\r\nParameter name: s", exception.Message);
            Assert.Equal(nameof(s), exception.ParamName);

            exception = Assert.Throws<ArgumentNullException>(() => s.ThrowIfNull(nameof(s)));

            Assert.Equal("s can not be null.\r\nParameter name: s", exception.Message);
            Assert.Equal(nameof(s), exception.ParamName);
        }

        /// <summary>The a.</summary>
        private sealed class A
        {
            /// <summary>Gets or sets the i.</summary>
            /// <value>The i.</value>
            public int I { get; set; }

            /// <summary>Gets or sets the s.</summary>
            /// <value>The s.</value>
            public string S { get; set; }
        }
    }
}
