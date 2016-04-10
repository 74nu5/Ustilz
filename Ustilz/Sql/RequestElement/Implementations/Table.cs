namespace Ustilz.Sql.RequestElement.Implementations
{
    /// <summary>The table. </summary>
    internal sealed class Table : ITable
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Table"/> class. Initialise une nouvelle instance de la classe<see cref="Table"/>.
        ///     Initializes a new instance of the <see cref="Table"/> class. Initialise une nouvelle instance de la classe<see cref="Table"/>.</summary>
        /// <param name="name">The name.</param>
        /// <param name="alias">The alias.</param>
        public Table(string name, string alias = null)
        {
            this.Name = name;
            this.Alias = alias;
        }

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Gets the alias. </summary>
        /// <value>The alias.</value>
        public string Alias { get; private set; }

        /// <summary>Gets a value indicating whether has alias.</summary>
        /// <value>The has alias.</value>
        public bool HasAlias => !string.IsNullOrEmpty(this.Alias);

        /// <summary>Gets the name. </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        public override string ToString()
        {
            return this.HasAlias ? $"{this.Name} {this.Alias}" : this.Name;
        }

        #endregion
    }
}