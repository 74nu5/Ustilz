namespace Ustilz.Test
{
    using System;
    using System.IO;

    using Ustilz.Arguments;
    using Ustilz.Arguments.TestAttributes;

    internal sealed class TestArgument : ArgumentTestable
    {
        [Argument("-u")]
        [NotNull]
        public string Url { get; set; }

        [Argument("-p")]
        [BetweenInt(0, 65556)]
        public int Port { get; set; }

        [Argument("-f", true)]
        public FileInfo CheminFichier { get; set; }

        [Argument("-d")]
        public DateTime Date { get; set; }
    }
}