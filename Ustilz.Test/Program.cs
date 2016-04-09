namespace Ustilz.Test
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using Ustilz.Extensions;

    #endregion

    /// <summary>The program.</summary>
    internal class Program
    {
        /// <summary>The main.</summary>
        /// <param name="args">The args.</param>
        private static void Main(string[] args)
        {
            string[] ss = { "1", "3", "TT" };
            ss.DumpConsole();

            List<Version> vv = new List<Version>() { new Version("8.8.9.8"), new Version("9.0.7.6") };
            vv.DumpConsole();
        }
    }
}