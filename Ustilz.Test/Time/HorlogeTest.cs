﻿namespace Ustilz.Test.Time
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
        #region Méthodes publiques

        /// <summary>The maintenant test.</summary>
        [Fact]
        public void MaintenantTest()
        {
            var now = DateTime.Now;
            var maintenant = Horloge.Maintenant;

            Assert.Equal(now.Day, maintenant.Day);
            Assert.Equal(now.Hour, maintenant.Hour);
            Assert.Equal(now.Month, maintenant.Month);
            Assert.Equal(now.Minute, maintenant.Minute);
            Assert.Equal(now.Year, maintenant.Year);
            Assert.Equal(now.Second, maintenant.Second);
        }

        /// <summary>The fonction maintenant test.</summary>
        [Fact]
        public void FonctionMaintenantTest()
        {
            Horloge.SetFonctionMaintenant = () => new DateTime(2018, 1, 07);
            var maintenant = Horloge.Maintenant;

            Assert.Equal(7, maintenant.Day);
            Assert.Equal(0, maintenant.Hour);
            Assert.Equal(1, maintenant.Month);
            Assert.Equal(0, maintenant.Minute);
            Assert.Equal(2018, maintenant.Year);
            Assert.Equal(0, maintenant.Second);

            Horloge.SetFonctionMaintenant = null;

            var now = DateTime.Now;
            maintenant = Horloge.Maintenant;

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
            Horloge.SetFonctionMaintenant = () => new DateTime(2018, 1, 07);
            var maintenant = Horloge.Maintenant;

            Assert.Equal(7, maintenant.Day);
            Assert.Equal(0, maintenant.Hour);
            Assert.Equal(1, maintenant.Month);
            Assert.Equal(0, maintenant.Minute);
            Assert.Equal(2018, maintenant.Year);
            Assert.Equal(0, maintenant.Second);

            Horloge.Reset();

            var now = DateTime.Now;
            maintenant = Horloge.Maintenant;

            Assert.Equal(now.Day, maintenant.Day);
            Assert.Equal(now.Hour, maintenant.Hour);
            Assert.Equal(now.Month, maintenant.Month);
            Assert.Equal(now.Minute, maintenant.Minute);
            Assert.Equal(now.Year, maintenant.Year);
            Assert.Equal(now.Second, maintenant.Second);
        }

        /// <inheritdoc />
        /// <summary>The dispose.</summary>
        public void Dispose() => Horloge.Reset();

        #endregion
    }
}