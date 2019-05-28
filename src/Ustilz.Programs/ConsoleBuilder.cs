namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Text;

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    /// <summary>
    ///     Classe de builder de l'objet <see cref="Cons" />.
    /// </summary>
    public sealed class ConsoleBuilder : ProgBuilder<ConsoleBuilder, Cons>
    {
        #region Champs

        /// <summary>The actions to launch.</summary>
        private Action[] actionsToLaunch = new Action[0];

        /// <summary>The has exit.</summary>
        private bool hasExit;

        #endregion

        #region Méthodes publiques

        /// <summary>The actions.</summary>
        /// <param name="actions">Les méthodes à lancer.</param>
        /// <returns>The <see cref="ConsoleBuilder" />.</returns>
        public ConsoleBuilder Actions(params Action[] actions)
        {
            this.actionsToLaunch = actions;
            return this;
        }

        /// <summary>The build.</summary>
        /// <returns>The <see cref="Cons" />.</returns>
        public override Cons Build()
            => new Cons(this.actionsToLaunch, this.hasExit, this.Services.BuildServiceProvider(), this.LogAction);

        /// <summary>The ut f 8.</summary>
        /// <returns>The <see cref="Cons" />.</returns>
        public ConsoleBuilder UTF8()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            return this;
        }

        /// <summary>The with exit.</summary>
        /// <returns>The <see cref="Cons" />.</returns>
        public ConsoleBuilder WithExit()
        {
            this.hasExit = true;
            return this;
        }

        #endregion
    }
}
