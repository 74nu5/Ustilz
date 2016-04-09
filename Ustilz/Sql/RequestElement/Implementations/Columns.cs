namespace Ustilz.Sql.RequestElement.Implementations
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Ustilz.Annotations;

    #endregion

    /// <summary>The columns. </summary>
    [PublicAPI]
    internal sealed class Columns : List<IColumn>, IColumns
    {
        #region Champs statiques

        /// <summary>The ms g_ no m_ colonn e_ nulle. </summary>
        private const string MSG_NOM_COLONNE_NULLE = "Le nom de la colonne ne doit pas être nulle.";

        #endregion

        #region Constructeurs et destructeurs

        /// <summary>Initializes a new instance of the <see cref="Columns"/> class. Initialise une nouvelle instance de la classe<see cref="Columns"/>.</summary>
        /// <param name="ownerTable">The owner Table.</param>
        public Columns([NotNull] ITable ownerTable)
        {
            this.OwnerTable = ownerTable;
        }

        /// <summary>Initializes a new instance of the <see cref="Columns"/> class. Initialise une nouvelle instance de la classe<see cref="Columns"/> qui est vide et a la capacité initiale
        ///     spécifiée.</summary>
        /// <param name="capacity">Nombre d'éléments que la nouvelle liste peut initialement stocker.</param>
        /// <exception cref="T:System.ArgumentOutOfRangeException"><paramref name="capacity"/> est inférieur à 0.</exception>
        private Columns(int capacity)
            : base(capacity)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="Columns"/> class. Initialise une nouvelle instance de la classe<see cref="Columns"/> qui contient des éléments copiés à
        ///     partir de la collection spécifiée et qui possède une capacité suffisante pour accepter le nombre d'éléments copiés.</summary>
        /// <param name="collection">Collection dont les éléments sont copiés dans la nouvelle liste.</param>
        /// <exception cref="T:System.ArgumentNullException"><paramref name="collection"/> est null.</exception>
        private Columns([NotNull] IEnumerable<IColumn> collection)
            : base(collection)
        {
        }

        #endregion

        #region Propriétés publiques, Indexeurs

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
                throw new ArgumentNullException("nomColumn", MSG_NOM_COLONNE_NULLE);
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
                throw new ArgumentNullException("nomColumn", MSG_NOM_COLONNE_NULLE);
            }

            this.Add(new Column(this.OwnerTable, nomColumn, alias));
        }

        /// <summary>The to string array. </summary>
        /// <returns>The <see cref="string"/>. </returns>
        public string[] ToStringArray()
        {
            return this.Select(column => column.ToString()).ToArray();
        }

        #endregion
    }
}