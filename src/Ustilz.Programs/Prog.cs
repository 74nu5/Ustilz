namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using JetBrains.Annotations;

    using Microsoft.Extensions.DependencyInjection;

    using Ustilz.Extensions.Enumerables;

    #endregion

    /// <summary>The programme.</summary>
    /// <typeparam name="TBuilder">Type du builder.</typeparam>
    /// <typeparam name="TProg">Classe du programme.</typeparam>
    [PublicAPI]
    public abstract class Prog<TBuilder, TProg>
        where TBuilder : ProgBuilder<TBuilder, TProg>, new()
        where TProg : Prog<TBuilder, TProg>
    {
        private readonly ICollection<Action<string>> logAction;

        /// <summary>The service provider.</summary>
        private readonly ServiceProvider serviceProvider;

        /// <summary>Initialise une nouvelle instance de la classe <see cref="Prog{TBuilder, TProg}"/>.</summary>
        /// <param name="provider">Le fournisseur de services.</param>
        /// <param name="logAction">Liste des actions à effectuer lors du log.</param>
        internal Prog(ServiceProvider provider, ICollection<Action<string>> logAction)
        {
            this.serviceProvider = provider;
            this.logAction = logAction;
        }

        /// <summary>Initialise une nouvelle instance de la classe <see cref="Prog{TBuilder, TProg}"/>.</summary>
        private Prog()
        {
            this.serviceProvider = new ServiceCollection().BuildServiceProvider();
            this.logAction = Array.Empty<Action<string>>();
        }

        /// <summary>Obtient the builder.</summary>
        public static TBuilder Builder
            => new TBuilder();

        /// <summary>Méthode d'écriture d'un message d'erreur (en rouge) dans la console. Cette méthode invoque aussi les actions de log préalablement renseignée, s'il y en a.</summary>
        /// <param name="message">Le message à écrire.</param>
        public void Error(string message)
        {
            var formatMessage = $"[Error] {message}";
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(formatMessage);
            Console.ForegroundColor = color;
            this.logAction?.ForEach(action => action?.Invoke(formatMessage));
        }

        /// <summary>Obtient le service de type T.</summary>
        /// <typeparam name="T">Type du service.</typeparam>
        /// <returns>Retourne le service de type T.</returns>
        public T Get<T>()
            => this.serviceProvider.GetService<T>();

        /// <summary>Obtient le service de type T.</summary>
        /// <typeparam name="T">Type du service.</typeparam>
        /// <returns>Retourne le service de type T.</returns>
        /// <exception cref="InvalidOperationException">Lève une exception si le service demandé n'existe pas.</exception>
        public T GetRequiredService<T>()
            => this.serviceProvider.GetRequiredService<T>();

        /// <summary>Méthode d'écriture d'un message d'information (en cyan) dans la console. Cette méthode invoque aussi les actions de log préalablement renseignée, s'il y en a.</summary>
        /// <param name="message">Le message à écrire.</param>
        public void Info(string message)
        {
            var formatMessage = $"[Info] {message}";
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(formatMessage);
            Console.ForegroundColor = color;
            this.logAction?.ForEach(action => action?.Invoke(formatMessage));
        }

        /// <summary>Méthode d'écriture d'un message d'attention (en orange) dans la console. Cette méthode invoque aussi les actions de log préalablement renseignée, s'il y en a.</summary>
        /// <param name="message">Le message à écrire.</param>
        public void Warn(string message)
        {
            var formatMessage = $"[Warn] {message}";
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(formatMessage);
            Console.ForegroundColor = color;
            this.logAction?.ForEach(action => action?.Invoke(formatMessage));
        }
    }
}
