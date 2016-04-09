namespace Ustilz.Sql
{
    /// <summary>The constantes. </summary>
    internal class Constantes
    {
        #region Champs statiques

        /// <summary>The egal. </summary>
        internal const string Egal = " = ";

        /// <summary>The space. </summary>
        internal const string Space = " ";

        /// <summary>The virgule space. </summary>
        internal const string VirguleSpace = ", ";

        #endregion

        #region Nested type: SQL

        /// <summary>The sql. </summary>
        internal class SQL
        {
            #region Champs statiques

            /// <summary>The al l_ columns. </summary>
            internal const string ALL_COLUMNS = "*";

            #endregion

            #region Nested type: Keyword

            /// <summary>The keyword. </summary>
            internal class Keyword
            {
                #region Champs statiques

                /// <summary>The from. </summary>
                internal const string FROM = "from";

                /// <summary>The select. </summary>
                internal const string SELECT = "select";

                #endregion

                #region Nested type: Join

                /// <summary>The join. </summary>
                internal class Join
                {
                    #region Champs statiques

                    /// <summary>The cross. </summary>
                    internal const string CROSS = "cross";

                    /// <summary>The full. </summary>
                    internal const string FULL = "full";

                    /// <summary>The inner. </summary>
                    internal const string INNER = "inner";

                    /// <summary>The join. </summary>
                    internal const string JOIN = "join";

                    /// <summary>The left. </summary>
                    internal const string LEFT = "left";

                    /// <summary>The natural. </summary>
                    internal const string NATURAL = "natural";

                    /// <summary>The on. </summary>
                    internal const string ON = " on ";

                    /// <summary>The outer. </summary>
                    internal const string OUTER = "outer";

                    /// <summary>The right. </summary>
                    internal const string RIGHT = "right";

                    /// <summary>The self. </summary>
                    internal const string SELF = "self";

                    /// <summary>The union. </summary>
                    internal const string UNION = "union";

                    #endregion
                }

                #endregion

                #region Nested type: Where

                /// <summary>The where. </summary>
                internal class Where
                {
                    #region Champs statiques

                    /// <summary>The and. </summary>
                    public const string AND = "and";

                    /// <summary>The or. </summary>
                    public const string OR = "or";

                    /// <summary>The where. </summary>
                    internal const string WHERE = "where";

                    #endregion
                }

                #endregion
            }

            #endregion
        }

        #endregion
    }
}