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
    /// <typeparam name="TBuilder">Type du builder.</typeparam>
    /// <typeparam name="TProg">Type de programme.</typeparam>
    [PublicAPI]
    public abstract class ProgBuilder<TBuilder, TProg>
    {
        #region Champs

        /// <summary>The configuration builder.</summary>
        private readonly ConfigurationBuilder configurationBuilder;

        /// <summary>Gets the logger factory.</summary>
        private readonly ILoggerFactory loggerFactory;

        /// <summary>Gets or sets the configuration.</summary>
        private IConfigurationRoot configuration;

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>
        /// Initialise une nouvelle instance de la classe <see cref="ProgBuilder{TBuilder, TProg}"/>.
        /// </summary>
        internal ProgBuilder()
        {
            this.configurationBuilder = new ConfigurationBuilder();
            this.Services = new ServiceCollection();
            this.loggerFactory = new LoggerFactory();
            this.configurationBuilder.SetBasePath(Path.Combine(AppContext.BaseDirectory));
            this.LogAction = new Action<string>[0];
            this.configuration = this.configurationBuilder.Build();
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Obtient ou définit l'action du log.</summary>
        protected Action<string>[] LogAction { get; set; }

        /// <summary>Obtient les services.</summary>
        protected ServiceCollection Services { get; }

        #endregion

        #region Méthodes publiques

        /// <summary>The add scoped.</summary>
        /// <typeparam name="T">Type à ajouter.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}" />.</returns>
        public ProgBuilder<TBuilder, TProg> AddScoped<T>()
            where T : class
        {
            this.Services.AddScoped<T>();
            return this;
        }

        /// <summary>The add scoped.</summary>
        /// <typeparam name="TType">Type à ajouter.</typeparam>
        /// <typeparam name="TImplementation">Implémentation du type à ajouter.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}"/>.</returns>
        public ProgBuilder<TBuilder, TProg> AddScoped<TType, TImplementation>()
            where TType : class
            where TImplementation : class, TType
        {
            this.Services.AddScoped<TType, TImplementation>();
            return this;
        }

        /// <summary>The add singleton.</summary>
        /// <typeparam name="T">Type à ajouter.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}" />.</returns>
        public ProgBuilder<TBuilder, TProg> AddSingleton<T>()
            where T : class
        {
            this.Services.AddSingleton<T>();
            return this;
        }

        /// <summary>The add singleton.</summary>
        /// <typeparam name="TType">Type à ajouter.</typeparam>
        /// <typeparam name="TImplementation">Implémentation du type à ajouter.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}"/>.</returns>
        public ProgBuilder<TBuilder, TProg> AddSingleton<TType, TImplementation>()
            where TType : class
            where TImplementation : class, TType
        {
            this.Services.AddSingleton<TType, TImplementation>();
            return this;
        }

        /// <summary>The add transient.</summary>
        /// <typeparam name="T">Type à ajouter.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}" />.</returns>
        public ProgBuilder<TBuilder, TProg> AddTransient<T>()
            where T : class
        {
            this.Services.AddTransient<T>();
            return this;
        }

        /// <summary>The add transient.</summary>
        /// <typeparam name="TType">Type à ajouter.</typeparam>
        /// <typeparam name="TImplementation">Implémentation du type à ajouter.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}"/>.</returns>
        public ProgBuilder<TBuilder, TProg> AddTransient<TType, TImplementation>()
            where TType : class
            where TImplementation : class, TType
        {
            this.Services.AddTransient<TType, TImplementation>();
            return this;
        }

        /// <summary>Méthode de build.</summary>
        /// <returns>Retourne le programme builder.</returns>
        public abstract TProg Build();

        /// <summary>The use app settings json.</summary>
        /// <typeparam name="TOptions">Type d'options.</typeparam>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}"/>.</returns>
        /// <exception cref="ArgumentNullException">Lève une exception lorsque la variable d'environnement ASPNETCORE_ENVIRONMENT n'est pas trouvée.</exception>
        public ProgBuilder<TBuilder, TProg> UseAppSettingsJson<TOptions>()
            where TOptions : class
        {
            this.Services.AddOptions();

            // Set up configuration sources.
            this.configurationBuilder.AddJsonFile("appsettings.json", true);
            this.configurationBuilder.AddJsonFile(
                Path.Combine(AppContext.BaseDirectory, string.Format("..{0}..{0}..{0}", Path.DirectorySeparatorChar), "appsettings.Development.json"),
                true);

            this.Services.Configure<TOptions>(this.configuration);

            return this;
        }

        /// <summary>Méthode pour ajouter une action basique de log.</summary>
        /// <param name="logMessageActions">Actions de log.</param>
        /// <returns>Retourne le builder.</returns>
        public ProgBuilder<TBuilder, TProg> UseBasicLogger(params Action<string>[] logMessageActions)
        {
            this.LogAction = logMessageActions;
            return this;
        }

        /// <summary>The use config.</summary>
        /// <param name="action">The action.</param>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}"/>.</returns>
        public ProgBuilder<TBuilder, TProg> UseConfig(Action<IConfigurationBuilder> action)
        {
            this.Services.AddOptions();
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Path.Combine(AppContext.BaseDirectory));
            action(builder);
            this.configuration = this.configurationBuilder.Build();
            this.Services.AddSingleton<IConfiguration>(this.configuration);

            return this;
        }

        /// <summary>The use logger.</summary>
        /// <param name="action">The func.</param>
        /// <returns>The <see cref="ProgBuilder{TBuilder, TProg}"/>.</returns>
        public ProgBuilder<TBuilder, TProg> UseLogger(Action<ILoggerFactory, IConfigurationRoot> action)
        {
            action(this.loggerFactory, this.configuration);
            return this;
        }

        #endregion
    }
}
