namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    public class Cons : Prog<ConsoleBuilder>
    {
        #region Champs

        /// <summary>Gets the actions to launch.</summary>
        private readonly Action[] actionsToLaunch;

        /// <summary>Gets a value indicating whether has exit.</summary>
        private readonly bool hasExit;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Prog" /> class.</summary>
        /// <param name="actions">The actions.</param>
        /// <param name="hasExit">The has exit.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="logAction">The logs actions</param>
        public Cons(Action[] actions, bool hasExit, ServiceProvider provider, Action<string>[] logAction)
            : base(provider, logAction)
        {
            this.actionsToLaunch = actions;
            this.hasExit = hasExit;
        }

        #endregion

        #region Méthodes publiques

        /// <summary>
        ///     Méthode utilitaire qui propose de lancer les méthodes passer en paramètre.
        ///     Un choix pour quitter l'application est afficher lorsque le paramètre withExit est à true.
        /// </summary>
        public void Run()
        {
            IList<Action> enumerable = this.actionsToLaunch.ToList();
            do
            {
                this.Info(" ________________________________________________________________________________ ");
                this.Info("|                                                                                |");
                this.Info("|    Choisissez la méthode à lancer                                              |");

                var i = 1;
                const int TotalWidth = 81;

                foreach (var action in this.actionsToLaunch)
                {
                    this.Info($"{$"|    - {i++}) {action.GetMethodInfo().Name}".PadRight(TotalWidth)}|");
                }

                if (this.hasExit)
                {
                    this.Info($"{$"|    - {i}) Exit".PadRight(TotalWidth)}|");
                    enumerable.Add(() => Environment.Exit(-1));
                }

                this.Info("|________________________________________________________________________________|");

                if (enumerable.Count == 0)
                {
                    return;
                }

                var entries = Console.ReadLine();
                if (string.IsNullOrEmpty(entries))
                {
                    continue;
                }

                foreach (var entry in entries.Split(' '))
                {
                    var isChoixNumerique = int.TryParse(entry, out var choix);

                    if (!isChoixNumerique || (choix <= enumerable.Count && choix > 0))
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
