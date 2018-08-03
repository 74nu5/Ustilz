namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using JetBrains.Annotations;

    #endregion

    /// <summary>The columns. </summary>
    [PublicAPI]
    internal sealed class Columns : List<IColumn>, IColumns
    {
        #region Champs et constantes statiques

        /// <summary>The ms g_ no m_ colonn e_ nulle. </summary>
        private const string MsgNomColonneNulle = "Le nom de la colonne ne doit pas être nulle.";

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Columns" /> class. Initialise une nouvelle instance de la classe<see cref="Columns" />.</summary>
        /// <param name="ownerTable">The owner Table.</param>
        public Columns([NotNull] ITable ownerTable) => this.OwnerTable = ownerTable;

        #endregion

        #region Propriétés et indexeurs

        /// <summary>Gets the owner table. </summary>
        /// <value>The owner table.</value>
        public ITable OwnerTable { get; private set; }

        #endregion

        #region Méthodes publiques

        /// <summary>The add.</summary>
        /// <param name="nomColumn">The nom column.</param>
        [ContractAnnotation("nomColumn:null => halt")]
        public void Add(string nomColumn)
        {
            if (string.IsNullOrEmpty(nomColumn))
            {
                throw new ArgumentNullException(nameof(nomColumn), MsgNomColonneNulle);
            }

            this.Add(new Column(this.OwnerTable, nomColumn));
        }

        /// <summary>The add.</summary>
        /// <param name="nomColumn">The nom column.</param>
        /// <param name="alias">The alias.</param>
        public void Add(string nomColumn, string alias)
        {
            if (string.IsNullOrEmpty(nomColumn))
            {
                throw new ArgumentNullException(nameof(nomColumn), MsgNomColonneNulle);
            }

            this.Add(new Column(this.OwnerTable, nomColumn, alias));
        }

        /// <summary>The to string array. </summary>
        /// <returns>The <see cref="string" />. </returns>
        public string[] ToStringArray()
        {
            return this.Select(column => column.ToString()).ToArray();
        }

        #endregion
    }
}
