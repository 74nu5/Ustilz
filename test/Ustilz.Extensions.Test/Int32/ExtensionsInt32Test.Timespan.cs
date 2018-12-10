namespace Ustilz.Extensions.Test.Int32
{
    #region Usings

    using System;

    using Ustilz.Extensions.Int32;

    using Xunit;

    #endregion

    /// <summary>The extensions int 32.</summary>
    public sealed partial class ExtensionsInt32Test
    {
        #region Méthodes publiques

        /// <summary>The days.</summary>
        [Fact]
        public void DaysTest() => Assert.Equal(TimeSpan.FromDays(5), 5.Days());

        /// <summary>The hours.</summary>
        [Fact]
        public void HoursTest() => Assert.Equal(TimeSpan.FromHours(5), 5.Hours());

        /// <summary>The milliseconds.</summary>
        [Fact]
        public void MillisecondsTest() => Assert.Equal(TimeSpan.FromMilliseconds(5), 5.Milliseconds());

        /// <summary>The minutes.</summary>
        [Fact]
        public void MinutesTest() => Assert.Equal(TimeSpan.FromMinutes(5), 5.Minutes());

        /// <summary>The seconds.</summary>
        [Fact]
        public void SecondsTest() => Assert.Equal(TimeSpan.FromSeconds(5), 5.Seconds());

        /// <summary>The ticks test.</summary>
        [Fact]
        public void TicksTest() => Assert.Equal(TimeSpan.FromTicks(5), 5.Ticks());

        #endregion
    }
}
