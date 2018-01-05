namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The programme.</summary>
    [PublicAPI]
    public static class Programme
    {
        #region Méthodes publiques

        /// <summary>The with choice.</summary>
        /// <param name="actions">The actions.</param>
        public static void WithChoice([NotNull] params Action[] actions) => WithChoice(false, actions);

        /// <summary>The with choice.</summary>
        /// <param name="withExit">The with exit.</param>
        /// <param name="actions">The actions.</param>
        public static void WithChoice(bool withExit, [NotNull] params Action[] actions)
        {
            IList<Action> enumerable = actions.ToList();
            do
            {
                var i = 1;
                foreach (var action in actions)
                {
                    Console.WriteLine("{0}) {1}", i++, action.GetMethodInfo().Name);
                }

                if (withExit)
                {
                    Console.WriteLine("{0}) Exit", i);
                    enumerable.Add(() => Environment.Exit(-1));
                }

                if (enumerable.Count == 0)
                {
                    return;
                }

                var entries = Console.ReadLine();
                foreach (var entry in entries.Split(' '))
                {
                    var isChoixNumerique = int.TryParse(entry, out var choix);

                    if (!isChoixNumerique || choix <= enumerable.Count && choix > 0)
                    {
                        enumerable[choix - 1].Invoke();
                    }
                }
            }
            while (true);
        }

        #endregion
    }
}
