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

        /// <summary>
        ///     Initializes a new instance of the <see cref="Column" /> class. Initialise une nouvelle instance de la classe
        ///     <see cref="Column" />.
        /// </summary>
        /// <param name="table">The table.</param>
        /// <param name="name">The name.</param>
        /// <param name="alias">The alias.</param>
        public Column(ITable table, string name, string alias = null)
        {
            this.OwnerTable = table;
            this.Name = name;
            this.Alias = alias;
        }

        #endregion

        #region Propriétés publiques, Indexeurs

        /// <summary>Gets the alias. </summary>
        /// <value>The alias.</value>
        public string Alias { get; private set; }

        /// <summary>Gets a value indicating whether has alias. </summary>
        /// <value>The has alias.</value>
        public bool HasAlias => !string.IsNullOrEmpty(this.Alias);

        /// <summary>Gets the name. </summary>
        /// <value>The name.</value>
        public string Name { get; private set; }

        /// <summary>Gets the owner table. </summary>
        /// <value>The owner table.</value>
        public ITable OwnerTable { get; private set; }

        #endregion

        #region Méthodes publiques

        /// <summary>Retourne un <see cref="T:System.String" /> qui représente le <see cref="T:System.Object" /> actuel. </summary>
        /// <returns><see cref="T:System.String" /> qui représente le <see cref="T:System.Object" /> actuel.</returns>
        public override string ToString()
        {
            return this.HasAlias ? $"{this.Name} as {this.Alias}" : this.Name;
        }

        /// <summary>The to string condition. </summary>
        /// <returns>The <see cref="string" />. </returns>
        public string ToStringCondition()
        {
            return this.OwnerTable.HasAlias ? $"{this.OwnerTable.Alias}.{this.Name}" : this.Name;
        }

        #endregion
    }
}