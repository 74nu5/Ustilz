namespace Ustilz.Json.Test
{
    #region Usings

    using Ustilz.Test.Models;

    using Xunit;

    #endregion

    /// <summary>
    /// The test class of JsonExtensions.
    /// </summary>
    public sealed class JsonExtensionsTest
    {
        /// <summary>
        /// The from json test.
        /// </summary>
        [Fact]
        public void FromJsonTest()
        {
            const string Input = "{\"Prenom\":\"John\",\"Nom\":\"Smith\"}";

            var expected = new Personne { Prenom = "John", Nom = "Smith" };

            var result = Input.FromJson<Personne>();

            Assert.Equal(expected, result, new PersonneComparer());
        }

        [Fact]
        public void ToJsonFormattedTest()
        {
            const string Expected =
                @"{
  ""Prenom"": ""John"",
  ""Nom"": ""Smith""
}";

            var p = new Personne { Prenom = "John", Nom = "Smith" };
            var result = p.ToJsonFormatted();

            Assert.Equal(Expected, result);
        }

        [Fact]
        public void ToJsonTest()
        {
            const string Expected = "{\"Prenom\":\"John\",\"Nom\":\"Smith\"}";

            var p = new Personne { Prenom = "John", Nom = "Smith" };
            var result = p.ToJson();

            Assert.Equal(Expected, result);
        }
    }
}
