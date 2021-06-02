namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    /// <summary>Classe représentant l'objet Cons, permettant de configurer une application console.</summary>
    public sealed class Cons : Prog<ConsoleBuilder, Cons>
    {
        private readonly Action[] actionsToLaunch;

        private readonly bool hasExit;

        /// <summary>Initialise une nouvelle instance de la classe <see cref="Cons" />.</summary>
        /// <param name="actions">Les actions à effectuer dans l'application console.</param>
        /// <param name="hasExit">True si un choix de sortie doit être ajouter au menu, False sinon.</param>
        /// <param name="provider">Fournisseur de services.</param>
        /// <param name="logAction">Liste d'action à effectuer lors du log.</param>
        internal Cons(Action[] actions, bool hasExit, ServiceProvider provider, ICollection<Action<string>> logAction)
            : base(provider, logAction)
        {
            this.actionsToLaunch = actions;
            this.hasExit = hasExit;
        }

        /// <summary>Méthode utilitaire qui propose de lancer les méthodes passer en paramètre. Un choix pour quitter l'application est afficher lorsque le paramètre withExit est à true.</summary>
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
                    this.Info($"{$"|    - {i++}) {action.GetMethodInfo().Name}",TotalWidth}|");
                }

                if (this.hasExit)
                {
                    this.Info($"{$"|    - {i}) Exit",TotalWidth}|");
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
                    var isChoixNumérique = int.TryParse(entry, out var choix);

                    if (!isChoixNumérique || (choix <= enumerable.Count && choix > 0))
                    {
                        enumerable[choix - 1].Invoke();
                    }
                }
            }
            while (true);
        }
    }
}
