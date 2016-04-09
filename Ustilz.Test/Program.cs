namespace Ustilz.Test
{
    #region Usings

    using System;
    using System.Collections.Generic;

    using Ustilz.Extensions;
    using Ustilz.Programs;
    using Ustilz.Sql;
    using Ustilz.Sql.RequestElement;
    using Ustilz.Sql.RequestType;

    #endregion

    /// <summary>The program.</summary>
    internal static class Program
    {
        /// <summary>The main.</summary>
        /// <param name="args">The args.</param>
        private static void Main(string[] args)
        {
            Programme.WithChoice(true, TestDump, TestSqlMaker);
        }

        /// <summary>The test sql maker.</summary>
        private static void TestSqlMaker()
        {
            List<IRequest> requetesList = new List<IRequest>();

            ISelectRequest sr = FactoryRequest.GetSelectRequest("TABLE_TEST", "tt");

            // TODO Retourner les mots clés en majuscule
            //// selectRequest.UpperSQL = true;
            sr.AddSelectColumn("colonne1");
            sr.AddSelectColumn("colonne2", "toto");
            sr.AddSelectColumn("colonne3");
            sr.AddSelectColumn("colonne4");

            ITable t1 = FactoryRequestElement.CreateTable("Table_1", "T1");
            IColumn c = FactoryRequestElement.CreateColumn(t1, "ff");
            IColumn c2 = FactoryRequestElement.CreateColumn(sr.PrincipalTable, "ff");
            /*
            Condition cond = new Condition(c, c2);
            sr.AddFirstWhereClause(cond);


            // sr.WhereClause.FirstCondition;
            
            Table t2 = new Table("Table_2", "T2");
            
            /*bool b = c == c2;

            sr.AddJoin(TypeJoin.InnerJoin, "T1colonne2", t1, "colonne2");
            sr.AddJoin(TypeJoin.InnerJoin, "T2colonne9", t2, "colonne2");*/

            requetesList.Add(sr);

            foreach (IRequest request in requetesList)
            {
                request.ToSql().DumpConsole();
            }
        }

        /// <summary>The test dump.</summary>
        private static void TestDump()
        {
            string[] ss = { "1", "3", "TT" };
            ss.DumpConsole();

            List<Version> vv = new List<Version>() { new Version("8.8.9.8"), new Version("9.0.7.6") };
            vv.DumpConsole();
        }
    }
}