using System;
using System.Collections.Generic;
using System.Text;

namespace Ustilz.Test.Time
{
    using Ustilz.Time;
    using Xunit;

    public class HorlogeTest
    {
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

        [Fact]
        public void FonctionMaintenantTest()
        {
            Horloge.FonctionMaintenant = () => new DateTime(2018, 1, 07);
            var maintenant = Horloge.Maintenant;

            Assert.Equal(7, maintenant.Day);
            Assert.Equal(0, maintenant.Hour);
            Assert.Equal(1, maintenant.Month);
            Assert.Equal(0, maintenant.Minute);
            Assert.Equal(2018, maintenant.Year);
            Assert.Equal(0, maintenant.Second);

            Horloge.FonctionMaintenant = null;

            var now = DateTime.Now;
            maintenant = Horloge.Maintenant;

            Assert.Equal(now.Day, maintenant.Day);
            Assert.Equal(now.Hour, maintenant.Hour);
            Assert.Equal(now.Month, maintenant.Month);
            Assert.Equal(now.Minute, maintenant.Minute);
            Assert.Equal(now.Year, maintenant.Year);
            Assert.Equal(now.Second, maintenant.Second);
        }

        [Fact]
        public void ResetTest()
        {
            Horloge.FonctionMaintenant = () => new DateTime(2018, 1, 07);
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
    }
}
