namespace Ustilz.Sql
{
    using JetBrains.Annotations;

    /// <summary>The constantes. </summary>
    internal static class Constantes
    {
        #region Champs et constantes statiques

        /// <summary>The egal. </summary>
        internal const string Egal = " = ";

        /// <summary>The space. </summary>
        internal const string Space = " ";

        /// <summary>The virgule space. </summary>
        internal const string VirguleSpace = ", ";

        #endregion

        #region Nested type: SQL

        /// <summary>The sql. </summary>
        internal static class SQL
        {
            #region Champs et constantes statiques

            /// <summary>The al l_ columns. </summary>
            internal const string AllColumns = "*";

            #endregion

            #region Nested type: Keyword

            /// <summary>The keyword. </summary>
            internal static class Keyword
            {
                #region Champs et constantes statiques

                /// <summary>The from. </summary>
                internal const string From = "from";

                /// <summary>The select. </summary>
                internal const string Select = "select";

                #endregion

                #region Nested type: Join

                /// <summary>The join. </summary>
                internal static class Joinning
                {
                    #region Champs et constantes statiques

                    /// <summary>The cross. </summary>
                    internal const string Cross = "cross";

                    /// <summary>The full. </summary>
                    internal const string Full = "full";

                    /// <summary>The inner. </summary>
                    internal const string Inner = "inner";

                    /// <summary>The join. </summary>
                    internal const string Join = "join";

                    /// <summary>The left. </summary>
                    internal const string Left = "left";

                    /// <summary>The natural. </summary>
                    internal const string Natural = "natural";

                    /// <summary>The on. </summary>
                    internal const string On = " on ";

                    /// <summary>The outer. </summary>
                    internal const string Outer = "outer";

                    /// <summary>The right. </summary>
                    internal const string Right = "right";

                    /// <summary>The self. </summary>
                    internal const string Self = "self";

                    /// <summary>The union. </summary>
                    internal const string Union = "union";

                    #endregion
                }

                #endregion

                #region Nested type: Where

                /// <summary>The where. </summary>
                internal static class Conditions
                {
                    #region Champs et constantes statiques

                    /// <summary>The and. </summary>
                    public const string And = "and";

                    /// <summary>The or. </summary>
                    public const string Or = "or";

                    /// <summary>The where. </summary>
                    internal const string Where = "where";

                    #endregion
                }

                #endregion
            }

            #endregion
        }

        #endregion
    }
}