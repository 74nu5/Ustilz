namespace Ustilz.Test.Extensions
{
    #region Usings

    using System;
    using Ustilz.Extensions;
    using Ustilz.Time;
    using Xunit;

    #endregion

    /// <summary>The extensions date time test.</summary>
    public class ExtensionsDateTimeTest
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="ExtensionsDateTimeTest"/> class.</summary>
        public ExtensionsDateTimeTest()
        {
            if (DateTime.Now.Month < 5)
            {
                // Pour éviter le mois de février.
                Horloge.SetFonctionMaintenant = () => DateTime.Now.AddMonths(5);
            }
        }

        #endregion

        #region Méthodes publiques

        /// <summary>The readable time stamp for one second test.</summary>
        [Fact]
        public void ReadableTimeStampForOneSecondTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromSeconds(1)).ReadableTimeStamp();
            Assert.Equal("one second ago", readable);
        }

        /// <summary>The readable time stamp for 5 seconds test.</summary>
        [Fact]
        public void ReadableTimeStampFor5SecondsTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromSeconds(5)).ReadableTimeStamp();
            Assert.Equal("5 seconds ago", readable);
        }

        /// <summary>The readable time stamp test.</summary>
        [Fact]
        public void ReadableTimeStampForOneMinuteTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromMinutes(1)).ReadableTimeStamp();
            Assert.Equal("a minute ago", readable);
        }

        /// <summary>The readable time stamp for 40 minutes test.</summary>
        [Fact]
        public void ReadableTimeStampFor40MinutesTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromMinutes(40)).ReadableTimeStamp();
            Assert.Equal("40 minutes ago", readable);
        }

        /// <summary>The readable time stamp for 1 hours test.</summary>
        [Fact]
        public void ReadableTimeStampFor1HoursTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromHours(1)).ReadableTimeStamp();
            Assert.Equal("an hour ago", readable);
        }

        /// <summary>The readable time stamp for 2 hours test.</summary>
        [Fact]
        public void ReadableTimeStampFor2HoursTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromHours(2)).ReadableTimeStamp();
            Assert.Equal("2 hours ago", readable);
        }

        /// <summary>The readable time stamp for yesterday test.</summary>
        [Fact]
        public void ReadableTimeStampForYesterdayTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromDays(1)).ReadableTimeStamp();
            Assert.Equal("yesterday", readable);
        }

        /// <summary>The readable time stamp for 15 days test.</summary>
        [Fact]
        public void ReadableTimeStampFor15DaysTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.Subtract(TimeSpan.FromDays(15)).ReadableTimeStamp();
            Assert.Equal("15 days ago", readable);
        }

        /// <summary>The readable time stamp for 1 months test.</summary>
        [Fact]
        public void ReadableTimeStampFor1MonthsTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.AddMonths(-1).ReadableTimeStamp();
            Assert.Equal("one month ago", readable);
        }

        /// <summary>The readable time stamp for 9 months test.</summary>
        [Fact]
        public void ReadableTimeStampFor9MonthsTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.AddMonths(-9).ReadableTimeStamp();
            Assert.Equal("9 months ago", readable);
        }

        /// <summary>The readable time stamp for 1 year test.</summary>
        [Fact]
        public void ReadableTimeStampFor1YearTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.AddYears(-1).ReadableTimeStamp();
            Assert.Equal("one year ago", readable);
        }

        /// <summary>The readable time stamp for 10 year test.</summary>
        [Fact]
        public void ReadableTimeStampFor10YearTest()
        {
            // Test 1 minute
            var readable = Horloge.Maintenant.AddYears(-10).ReadableTimeStamp();
            Assert.Equal("10 years ago", readable);
        }

        #endregion
    }
}