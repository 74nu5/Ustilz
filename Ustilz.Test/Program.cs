namespace Ustilz.Test
{
    using System;
    using System.Diagnostics;

    using Ustilz.Programs;
    using Ustilz.Test.Enums;

    public class Program
    {
        private static void Main(string args)
        {
            var c = Batch.Builder.Build();

            var prog = Cons.Builder
                .Actions(Print1337, Print24, Print42, Print51)
                .UTF8()
                .AddSingleton<EnumHelperTest>()
                .UseBasicLogger(s => Debug.WriteLine(s))
                .Build();

            var helperTest = prog.Get<EnumHelperTest>();

            prog.Run();
        }

        private static void Print42() => Console.WriteLine(42);

        private static void Print1337() => Console.WriteLine(1337);

        private static void Print51() => Console.WriteLine(51);

        private static void Print24() => Console.WriteLine(24);
    }
}
