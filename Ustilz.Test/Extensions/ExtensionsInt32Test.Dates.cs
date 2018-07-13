namespace Ustilz.Test.Extensions
{
    #region Usings

    using System;
    using Ustilz.Extensions.Date;
    using Ustilz.Extensions.Int32;

    using Xunit;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public partial class ExtensionsInt32Test
    {
        #region Méthodes publiques

        /// <summary>The août test.</summary>
        [Fact]
        public void JanvierTest()
        {
            var date = 15.Janvier(1987);
            var dateRef = new DateTime(1987, 1, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The février test.</summary>
        [Fact]
        public void FévrierTest()
        {
            var date = 15.Février(1987);
            var dateRef = new DateTime(1987, 2, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The mars test.</summary>
        [Fact]
        public void MarsTest()
        {
            var date = 15.Mars(1987);
            var dateRef = new DateTime(1987, 3, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The avril test.</summary>
        [Fact]
        public void AvrilTest()
        {
            var date = 15.Avril(1987);
            var dateRef = new DateTime(1987, 4, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The mai test.</summary>
        [Fact]
        public void MaiTest()
        {
            var date = 15.Mai(1987);
            var dateRef = new DateTime(1987, 5, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The juin test.</summary>
        [Fact]
        public void JuinTest()
        {
            var date = 15.Juin(1987);
            var dateRef = new DateTime(1987, 6, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The juillet test.</summary>
        [Fact]
        public void JuilletTest()
        {
            var date = 15.Juillet(1987);
            var dateRef = new DateTime(1987, 7, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The août test.</summary>
        [Fact]
        public void AoûtTest()
        {
            var date = 15.Août(1987);
            var dateRef = new DateTime(1987, 8, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The septembre test.</summary>
        [Fact]
        public void SeptembreTest()
        {
            var date = 15.Septembre(1987);
            var dateRef = new DateTime(1987, 9, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The octobre test.</summary>
        [Fact]
        public void OctobreTest()
        {
            var date = 15.Octobre(1987);
            var dateRef = new DateTime(1987, 10, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The novembre test.</summary>
        [Fact]
        public void NovembreTest()
        {
            var date = 15.Novembre(1987);
            var dateRef = new DateTime(1987, 11, 15);
            Assert.Equal(dateRef, date);
        }

        /// <summary>The décembre test.</summary>
        [Fact]
        public void DécembreTest()
        {
            var date = 15.Décembre(1987);
            var dateRef = new DateTime(1987, 12, 15);
            Assert.Equal(dateRef, date);
        }

        #endregion
    }
}