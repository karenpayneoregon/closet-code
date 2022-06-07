using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace QueryFormatUtility.Classes
{
    class QueryParsers1
    {
        public static string StripCommentsFromSQL(string SQL)
        {

            TSql110Parser parser = new TSql110Parser(true);
            IList<ParseError> errors;
            var fragments = parser.Parse(new StringReader(SQL), out errors);

            // clear comments
            string result = string.Join(
                string.Empty,
                fragments.ScriptTokenStream
                    .Where(x => x.TokenType != TSqlTokenType.MultilineComment)
                    .Where(x => x.TokenType != TSqlTokenType.SingleLineComment)
                    .Select(x => x.Text));

            return result;

        }
        public static void Parse(string sql)
        {
            var parsed = ParseSql(sql);
            if (parsed.errors.Any())
            {
                return;
            }

            var visitor = new SelectVisitor();
            parsed.sqlTree.Accept(visitor);

        }
        private static (TSqlFragment sqlTree, IList<ParseError> errors) ParseSql(string procText)
        {
            var parser = new TSql150Parser(true);
            using (var textReader = new StringReader(procText))
            {
                var sqlTree = parser.Parse(textReader, out var errors);

                return (sqlTree, errors);
            }
        }
        internal class SelectVisitor : TSqlFragmentVisitor
        {
            public override void ExplicitVisit(SelectStatement node)
            {
                Debug.WriteLine($"Visiting Select: {node}");
                base.ExplicitVisit(node);
            }

            public override void ExplicitVisit(QueryExpression node)
            {
                Debug.WriteLine($"Visiting QueryExpression: {node}");
            }

            public override void ExplicitVisit(QuerySpecification node)
            {
                Debug.WriteLine($"Visiting QuerySpecification: {node}");
            }

            public override void ExplicitVisit(SelectStarExpression node)
            {
                Debug.WriteLine($"Visiting SelectStarExpression: {node}");
            }
        }
    }
}
