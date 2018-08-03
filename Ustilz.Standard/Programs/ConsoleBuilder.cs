namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Text;

    using Microsoft.Extensions.DependencyInjection;

    #endregion

    public class ConsoleBuilder : ProgBuilder<ConsoleBuilder, Cons>
    {
        #region Champs

        /// <summary>The actions to launch.</summary>
        private Action[] actionsToLaunch;

        /// <summary>The has exit.</summary>
        private bool hasExit;

        #endregion

        #region Méthodes publiques

        /// <summary>The actions.</summary>
        /// <param name="actions">Les méthodes à lancer.</param>
        /// <returns>The <see cref="Prog" />.</returns>
        public ConsoleBuilder Actions(params Action[] actions)
        {
            this.actionsToLaunch = actions;
            return this;
        }

        /// <summary>The build.</summary>
        /// <returns>The <see cref="Prog" />.</returns>
        /// <typeparam name="T">Type de programme.</typeparam>
        public override Cons Build()
            => new Cons(this.actionsToLaunch, this.hasExit, this.services.BuildServiceProvider(), this.logAction);

        /// <summary>The ut f 8.</summary>
        /// <returns>The <see cref="Prog" />.</returns>
        public ConsoleBuilder UTF8()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            return this;
        }

        /// <summary>The with exit.</summary>
        /// <returns>The <see cref="Prog" />.</returns>
        public ConsoleBuilder WithExit()
        {
            this.hasExit = true;
            return this;
        }

        #endregion
    }
}
