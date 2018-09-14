namespace Ustilz.Programs
{
    #region Usings

    using System;

    using JetBrains.Annotations;

    using Microsoft.Extensions.DependencyInjection;

    using Ustilz.Extensions.Enumerables;

    #endregion

    /// <summary>The programme.</summary>
    [PublicAPI]
    public abstract class Prog<TBuilder>
        where TBuilder : new()
    {
        #region Champs

        private readonly Action<string>[] logAction;

        /// <summary>The service provider.</summary>
        private readonly ServiceProvider serviceProvider;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>
        ///     Prevents a default instance of the <see cref="Prog" /> class from being created. Initializes a new instance of
        ///     the <see cref="Prog" /> class.
        /// </summary>
        private Prog()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Prog" /> class.</summary>
        /// <param name="provider">The provider.</param>
        /// <param name="logAction">The logs actions</param>
        internal Prog(ServiceProvider provider, Action<string>[] logAction)
        {
            this.serviceProvider = provider;
            this.logAction = logAction;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>
        ///     Gets the builder.
        /// </summary>
        public static TBuilder Builder
            => new TBuilder();

        #endregion

        #region Méthodes publiques

        /// <summary>The console write info.</summary>
        /// <param name="message">The message.</param>
        public void Error(string message)
        {
            var formatMessage = $"[Error] {message}";
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(formatMessage);
            Console.ForegroundColor = color;
            this.logAction?.ForEach(action => action?.Invoke(formatMessage));
        }

        /// <summary>The get service.</summary>
        /// <typeparam name="T">Type de retour</typeparam>
        /// <returns>The <see cref="T" />.</returns>
        public T Get<T>()
            => this.serviceProvider.GetService<T>();

        /// <summary>The get required service.</summary>
        /// <typeparam name="T">Type de retour</typeparam>
        /// <returns>The <see cref="T" />.</returns>
        public T GetRequiredService<T>()
            => this.serviceProvider.GetRequiredService<T>();

        /// <summary>The console write info.</summary>
        /// <param name="message">The message.</param>
        public void Info(string message)
        {
            var formatMessage = $"[Info] {message}";
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(formatMessage);
            Console.ForegroundColor = color;
            this.logAction?.ForEach(action => action?.Invoke(formatMessage));
        }


        /// <summary>The console write info.</summary>
        /// <param name="message">The message.</param>
        public void Warn(string message)
        {
            var formatMessage = $"[Warn] {message}";
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(formatMessage);
            Console.ForegroundColor = color;
            this.logAction?.ForEach(action => action?.Invoke(formatMessage));
        }

        #endregion
    }
}
