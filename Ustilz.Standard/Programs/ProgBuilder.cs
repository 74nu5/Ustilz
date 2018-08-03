namespace Ustilz.Programs
{
    #region Usings

    using System;
    using System.IO;

    using JetBrains.Annotations;

    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    #endregion


    /// <summary>The prog builder.</summary>
    [PublicAPI]
    public abstract class ProgBuilder<TBuilder, TProg>
    {
        #region Champs

        /// <summary>The configuration builder.</summary>
        private readonly ConfigurationBuilder configurationBuilder;

        /// <summary>Gets the logger factory.</summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>Gets the services.</summary>
        protected readonly ServiceCollection services;


        /// <summary>Gets or sets the configuration.</summary>
        private IConfigurationRoot configuration;


        protected Action<string>[] logAction;

        #endregion

        #region Constructeurs et destructeurs

        internal ProgBuilder()
        {
            this.configurationBuilder = new ConfigurationBuilder();
            this.services = new ServiceCollection();
            this.loggerFactory = new LoggerFactory();
            this.configurationBuilder.SetBasePath(Path.Combine(AppContext.BaseDirectory));
        }

        #endregion

        #region Méthodes publiques

        public ProgBuilder<TBuilder, TProg> AddScoped<T>()
            where T : class
        {
            this.services.AddScoped<T>();
            return this;
        }

        public ProgBuilder<TBuilder, TProg> AddScoped<TType, TImplementation>()
            where TType : class
            where TImplementation : class, TType
        {
            this.services.AddScoped<TType, TImplementation>();
            return this;
        }


        public ProgBuilder<TBuilder, TProg> AddSingleton<T>()
            where T : class
        {
            this.services.AddSingleton<T>();
            return this;
        }

        public ProgBuilder<TBuilder, TProg> AddSingleton<TType, TImplementation>()
            where TType : class
            where TImplementation : class, TType
        {
            this.services.AddSingleton<TType, TImplementation>();
            return this;
        }

        public ProgBuilder<TBuilder, TProg> AddTransient<T>()
            where T : class
        {
            this.services.AddTransient<T>();
            return this;
        }

        public ProgBuilder<TBuilder, TProg> AddTransient<TType, TImplementation>()
            where TType : class
            where TImplementation : class, TType
        {
            this.services.AddTransient<TType, TImplementation>();
            return this;
        }

        /// <summary>The build.</summary>
        /// <returns>The <see cref="Prog" />.</returns>
        /// <typeparam name="T">Type de programme.</typeparam>
        public abstract TProg Build();

        /// <summary>The use app settings json.</summary>
        /// <typeparam name="TOptions">Type d'options</typeparam>
        /// <returns>The <see cref="Prog" />.</returns>
        /// <exception cref="ArgumentNullException">
        ///     Lève une exception lorsque la variable d'environnement ASPNETCORE_ENVIRONMENT n'est pas trouvée.
        /// </exception>
        public ProgBuilder<TBuilder, TProg> UseAppSettingsJson<TOptions>()
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

        /// <summary>
        ///     Méthode pour ajouter une action basique de log.
        /// </summary>
        /// <param name="logMessageActions">Actions de log.</param>
        /// <returns>Retourne le builder.</returns>
        public ProgBuilder<TBuilder, TProg> UseBasicLogger(params Action<string>[] logMessageActions)
        {
            this.logAction = logMessageActions;
            return this;
        }

        /// <summary>The use config.</summary>
        /// <param name="action">The action.</param>
        /// <returns>The <see cref="ProgBuilder" />.</returns>
        public ProgBuilder<TBuilder, TProg> UseConfig(Action<IConfigurationBuilder> action)
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
        /// <returns>The <see cref="Prog" />.</returns>
        public ProgBuilder<TBuilder, TProg> UseLogger(Action<ILoggerFactory, IConfigurationRoot> action)
        {
            action(this.loggerFactory, this.configuration);
            return this;
        }

        #endregion
    }
}
