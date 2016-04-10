namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The programme.</summary>
    [PublicAPI]
    public static class Programme
    {
        #region Méthodes publiques

        /// <summary>The with choice.</summary>
        /// <param name="actions">The actions.</param>
        public static void WithChoice(params Action[] actions)
        {
            WithChoice(false, actions);
        }

        /// <summary>The with choice.</summary>
        /// <param name="withExit">The with exit.</param>
        /// <param name="actions">The actions.</param>
        public static void WithChoice(bool withExit, params Action[] actions)
        {
            IList<Action> enumerable = actions.ToList();
            do
            {
                var i = 1;
                foreach (var action in actions)
                {
                    Console.WriteLine("{0}) {1}", i++, action.Method.Name);
                }

                if (withExit)
                {
                    Console.WriteLine("{0}) Exit", i);
                    enumerable.Add(() => Environment.Exit(-1));
                }

                var entry = Console.ReadLine();
                if (enumerable.Count == 0)
                {
                    return;
                }

                int choix;
                var isChoixNumerique = int.TryParse(entry, out choix);

                if (!isChoixNumerique || (choix <= enumerable.Count && choix > 0))
                {
                    enumerable[choix - 1].Invoke();
                }
            }
            while (true);
        }

        #endregion
    }
}