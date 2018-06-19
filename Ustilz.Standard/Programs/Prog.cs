namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    using JetBrains.Annotations;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    #endregion

    /// <summary>The programme.</summary>
    [PublicAPI]
    public sealed class Prog
    {
        #region Champs

        /// <summary>Gets the actions to launch.</summary>
        private Action[] actionsToLaunch;

        /// <summary>Gets a value indicating whether has exit.</summary>
        private bool hasExit;

        /// <summary>The service provider.</summary>
        private ServiceProvider serviceProvider;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Prevents a default instance of the <see cref="Prog"/> class from being created. Initializes a new instance of
        ///     the <see cref="Prog"/> class.</summary>
        private Prog()
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Prog"/> class.</summary>
        /// <param name="actions">The actions.</param>
        /// <param name="hasExit">The has exit.</param>
        /// <param name="provider">The provider.</param>
        private Prog(
            Action[] actions,
            bool hasExit,
            ServiceProvider provider)
        {
            this.actionsToLaunch = actions;
            this.hasExit = hasExit;
            this.serviceProvider = provider;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>The builder.</summary>
        /// <value>A builder.</value>
        public static ProgBuilder Builder
            => new ProgBuilder();

        #endregion

        #region Méthodes publiques

        /// <summary>The console write info.</summary>
        /// <param name="message">The message.</param>
        public static void Error(
            string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        /// <summary>The console write info.</summary>
        /// <param name="message">The message.</param>
        public static void Info(
            string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        /// <summary>The console write info.</summary>
        /// <param name="message">The message.</param>
        public static void Warn(
            string message)
        {
            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }

        /// <summary>The get required service.</summary>
        /// <typeparam name="T">Type de retour</typeparam>
        /// <returns>The <see cref="T"/>.</returns>
        public T GetRequiredService<T>()
            => this.serviceProvider.GetRequiredService<T>();

        /// <summary>The get service.</summary>
        /// <typeparam name="T">Type de retour</typeparam>
        /// <returns>The <see cref="T"/>.</returns>
        public T GetService<T>()
            => this.serviceProvider.GetService<T>();

        /// <summary>
        ///     Méthode utilitaire qui propose de lancer les méthodes passer en paramètre.
        ///     Un choix pour quitter l'application est afficher lorsque le paramètre withExit est à true.
        /// </summary>
        public void Run()
        {
            IList<Action> enumerable = this.actionsToLaunch.ToList();
            do
            {
                Info(" ________________________________________________________________________________ ");
                Info("|                                                                                |");
                Info("|    Choisissez la méthode à lancer                                              |");

                var i = 1;
                const int TotalWidth = 81;

                foreach (var action in this.actionsToLaunch)
                {
                    Info($"{$"|    - {i++}) {action.GetMethodInfo().Name}".PadRight(TotalWidth)}|");
                }

                if (this.hasExit)
                {
                    Info($"{$"|    - {i}) Exit".PadRight(TotalWidth)}|");
                    enumerable.Add(() => Environment.Exit(-1));
                }

                Info("|________________________________________________________________________________|");

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

                    if (!isChoixNumerique || choix <= enumerable.Count && choix > 0)
                    {
                        enumerable[choix - 1].Invoke();
                    }
                }
            }
            while (true);
        }

        #endregion

        #region Nested type: ProgBuilder

        /// <summary>The prog builder.</summary>
        [PublicAPI]
        public sealed class ProgBuilder
        {
            #region Champs

            /// <summary>The configuration builder.</summary>
            private readonly ConfigurationBuilder configurationBuilder;

            /// <summary>Gets the logger factory.</summary>
            private readonly ILoggerFactory loggerFactory = new LoggerFactory();

            /// <summary>Gets the services.</summary>
            private readonly ServiceCollection services = new ServiceCollection();

            /// <summary>The actions to launch.</summary>
            private Action[] actionsToLaunch;

            /// <summary>Gets or sets the configuration.</summary>
            private IConfigurationRoot configuration;

            /// <summary>The has exit.</summary>
            private bool hasExit;

            /// <summary>The service provider.</summary>
            private ServiceProvider serviceProvider;

            #endregion

            #region Constructeurs et destructeurs

            /// <summary>Initializes a new instance of the <see cref="ProgBuilder"/> class.</summary>
            internal ProgBuilder()
            {
                this.configurationBuilder = new ConfigurationBuilder();
                this.configurationBuilder.SetBasePath(Path.Combine(AppContext.BaseDirectory));
            }

            #endregion

            #region Méthodes publiques

            /// <summary>The actions.</summary>
            /// <param name="actions">Les méthodes à lancer.</param>
            /// <returns>The <see cref="Prog"/>.</returns>
            public ProgBuilder Actions(
                [NotNull] params Action[] actions)
            {
                this.actionsToLaunch = actions;
                return this;
            }

            /// <summary>The add services.</summary>
            /// <param name="action">The action.</param>
            /// <returns>The <see cref="Prog"/>.</returns>
            public ProgBuilder AddServices(
                Action<IServiceCollection> action)
            {
                action(this.services);
                this.serviceProvider = this.services.BuildServiceProvider();
                return this;
            }

            /// <summary>The build.</summary>
            /// <returns>The <see cref="Prog"/>.</returns>
            public Prog Build()
                => new Prog(this.actionsToLaunch, this.hasExit, this.serviceProvider);

            /// <summary>The use app settings json.</summary>
            /// <typeparam name="TOptions">Type d'options</typeparam>
            /// <returns>The <see cref="Prog"/>.</returns>
            /// <exception cref="ArgumentNullException">
            ///     Lève une exception lorsque la variable d'environnement ASPNETCORE_ENVIRONMENT n'est pas trouvée.
            /// </exception>
            public ProgBuilder UseAppSettingsJson<TOptions>()
                where TOptions : class
            {
                this.services.AddOptions();

                // Set up configuration sources.
                this.configurationBuilder.AddJsonFile("appsettings.json", true);
                this.configurationBuilder.AddJsonFile(
                    Path.Combine(AppContext.BaseDirectory, string.Format("..{0}..{0}..{0}", Path.DirectorySeparatorChar), "appsettings.Development.json"), true);

                this.services.Configure<TOptions>(this.configuration);

                return this;
            }

            /// <summary>The use config.</summary>
            /// <param name="action">The action.</param>
            /// <returns>The <see cref="ProgBuilder"/>.</returns>
            public ProgBuilder UseConfig(
                Action<IConfigurationBuilder> action)
            {
                this.services.AddOptions();
                var builder = new ConfigurationBuilder();
                builder.SetBasePath(Path.Combine(AppContext.BaseDirectory));
                action(builder);
                this.configuration = this.configurationBuilder.Build();
                this.services.AddSingleton<IConfiguration>(this.configuration);

                return this;
            }

            /// <summary>The use logger.</summary>
            /// <param name="action">The func.</param>
            /// <returns>The <see cref="Prog"/>.</returns>
            public ProgBuilder UseLogger(
                Action<ILoggerFactory, IConfigurationRoot> action)
            {
                action(this.loggerFactory, this.configuration);
                return this;
            }

            /// <summary>The ut f 8.</summary>
            /// <returns>The <see cref="Prog"/>.</returns>
            public ProgBuilder UTF8()
            {
                Console.InputEncoding = Encoding.UTF8;
                Console.OutputEncoding = Encoding.UTF8;
                return this;
            }

            /// <summary>The with exit.</summary>
            /// <returns>The <see cref="Prog"/>.</returns>
            public ProgBuilder WithExit()
            {
                this.hasExit = true;
                return this;
            }

            #endregion
        }

        #endregion
    }
}