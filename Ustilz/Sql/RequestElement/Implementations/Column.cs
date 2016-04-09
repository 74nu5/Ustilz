namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using Ustilz.Annotations;

    #endregion

    /// <summary>The column. </summary>
    [CannotApplyEqualityOperator]
    internal sealed class Column : IColumn
    {
        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Column"/> class. Initialise une nouvelle instance de la classe<see cref="Column"/>.</summary>
        /// <param name="table">The table.</param>
        /// <param name="name">The name.</param>
        /// <param name="alias">The alias.</param>
        public Column(ITable table, string name, string alias)
        {
            this.OwnerTable = table;
            this.Name = name;
            this.Alias = alias;
        }

        /// <summary>Initializes a new instance of the <see cref="Column"/> class. Initialise une nouvelle instance de la classe<see cref="Column"/>.</summary>
        /// <param name="table">The table.</param>
        /// <param name="name">The name.</param>
        public Column(ITable table, string name)
            : this(table, name, null)
        {
        }

        #endregion

        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the alias. </summary>
        /// <value>The alias.</value>
        public string Alias { get; private set; }

        /// <summary>Gets a value indicating whether has alias. </summary>
        /// <value>The has alias.</value>
        public bool HasAlias
        {
            get
            {
                return !string.IsNullOrEmpty(this.Alias);
            }
        }

        /// <summary>Gets the name. </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>Gets the owner table. </summary>
        /// <value>The owner table.</value>
        public ITable OwnerTable { get; private set; }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel. </summary>
        /// <returns><see cref="T:System.String"/> qui représente le <see cref="T:System.Object"/> actuel.</returns>
        public override string ToString()
        {
            return this.HasAlias ? string.Format("{0} as {1}", this.Name, this.Alias) : this.Name;
        }

        /// <summary>The to string condition. </summary>
        /// <returns>The <see cref="string"/>. </returns>
        public string ToStringCondition()
        {
            return this.OwnerTable.HasAlias ? string.Format("{0}.{1}", this.OwnerTable.Alias, this.Name) : this.Name;
        }

        #endregion
    }
}