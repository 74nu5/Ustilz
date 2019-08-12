namespace Ustilz.Time.Test
{
    #region Usings

    using System;

    using Ustilz.Time;

    using Xunit;

    #endregion

    /// <inheritdoc />
    /// <summary>The horloge test.</summary>
    public class HorlogeTest : IDisposable
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="HorlogeTest" /> class.</summary>
        public HorlogeTest() => Clock.Reset();

        #endregion

        #region Méthodes publiques

        /// <inheritdoc />
        /// <summary>The dispose.</summary>
        public void Dispose() => Clock.Reset();

        /// <summary>The fonction maintenant test.</summary>
        [Fact]
        public void FonctionMaintenantTest()
        {
            Clock.SetFunctionNow(() => new DateTime(2018, 1, 07));
            var maintenant = Clock.Now;

            Assert.Equal(7, maintenant.Day);
            Assert.Equal(0, maintenant.Hour);
            Assert.Equal(1, maintenant.Month);
            Assert.Equal(0, maintenant.Minute);
            Assert.Equal(2018, maintenant.Year);
            Assert.Equal(0, maintenant.Second);

            Clock.SetFunctionNow(null);

            var now = Clock.Now;
            maintenant = Clock.Now;

            Assert.Equal(now.Day, maintenant.Day);
            Assert.Equal(now.Hour, maintenant.Hour);
            Assert.Equal(now.Month, maintenant.Month);
            Assert.Equal(now.Minute, maintenant.Minute);
            Assert.Equal(now.Year, maintenant.Year);
            Assert.Equal(now.Second, maintenant.Second);
        }

        /// <summary>The maintenant test.</summary>
        [Fact]
        public void MaintenantTest()
        {
            var now = Clock.Now;
            var maintenant = Clock.Now;

            Assert.Equal(now.Day, maintenant.Day);
            Assert.Equal(now.Hour, maintenant.Hour);
            Assert.Equal(now.Month, maintenant.Month);
            Assert.Equal(now.Minute, maintenant.Minute);
            Assert.Equal(now.Year, maintenant.Year);
            Assert.Equal(now.Second, maintenant.Second);
        }

        /// <summary>The reset test.</summary>
        [Fact]
        public void ResetTest()
        {
            Clock.SetFunctionNow(() => new DateTime(2018, 1, 07));
            var maintenant = Clock.Now;

            Assert.Equal(7, maintenant.Day);
            Assert.Equal(0, maintenant.Hour);
            Assert.Equal(1, maintenant.Month);
            Assert.Equal(0, maintenant.Minute);
            Assert.Equal(2018, maintenant.Year);
            Assert.Equal(0, maintenant.Second);

            Clock.Reset();

            var now = Clock.Now;
            maintenant = Clock.Now;

            Assert.Equal(now.Day, maintenant.Day);
            Assert.Equal(now.Hour, maintenant.Hour);
            Assert.Equal(now.Month, maintenant.Month);
            Assert.Equal(now.Minute, maintenant.Minute);
            Assert.Equal(now.Year, maintenant.Year);
            Assert.Equal(now.Second, maintenant.Second);
        }

        #endregion
    }
}
