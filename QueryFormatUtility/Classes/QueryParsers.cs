using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace QueryFormatUtility.Classes
{
    public class QueryParsers
    {
        public static IList<ParseError> ParseErrors { get; set; }


        /// <summary>
        /// Format SQL off one line to indented into many lines
        /// </summary>
        /// <param name="query">SQL statement to format</param>
        /// <returns>Formatted SQL</returns>
        public static string Format(string query)
        {
            TSql120Parser parser = new(false);

            var parsedQuery = parser.Parse(
                new StringReader(query),
                out var errors);


            

            if (errors.Count > 0)
            {
                ParseErrors = errors;
            }

            var generator = new Sql120ScriptGenerator(new SqlScriptGeneratorOptions()
            {
                KeywordCasing = KeywordCasing.Uppercase,
                IncludeSemicolons = true,
                NewLineBeforeFromClause = true,
                NewLineBeforeOrderByClause = true,
                NewLineBeforeWhereClause = true,
                AlignClauseBodies = false
            });

            generator.GenerateScript(parsedQuery, out var formattedQuery);

            return formattedQuery;

        }


        /// <summary>
        /// Get each parameter for WHERE clause
        /// </summary>
        /// <param name="sql">SQL with parameters</param>
        /// <returns></returns>
        public static (List<string> list, List<string> exceptions) GetVariables(string sql)
        {
            List<TSqlParserToken> queryTokens = TokenizeSql(sql, out var errors);

            if (errors != null)
            {
                return (null, errors);
            }

            var parameters = new List<string>();

            parameters.AddRange(queryTokens
                .Where(token => token.TokenType == TSqlTokenType.Variable)
                .Select(token => token.Text)
                .ToList());

            return (parameters, null);
        }

        private static List<TSqlParserToken> TokenizeSql(string sql, out List<string> parserErrors)
        {
            using TextReader textReader = new StringReader(sql);
            var parser = new TSql120Parser(true);


            var queryTokens = parser.GetTokenStream(textReader, out var errors);
            parserErrors = errors.Any()
                ? errors.Select(e => $"Error: {e.Number}; Line: {e.Line}; Column: {e.Column}; Offset: {e.Offset};  Message: {e.Message};").ToList()
                : null;
            return queryTokens.ToList();
        }

        /// <summary>
        /// Provides the ability to run a script with GO statements
        /// </summary>
        /// <param name="script"></param>
        public static void RunWithGo(string script)
        {
            var writer = new DebuggerWriter();
            using TextReader reader = new StringReader(script);

            TSqlParser parser = new TSql110Parser(true);
            IList<ParseError> errors;

            TSqlFragment fragment = parser.Parse(reader, out errors);

            if (errors is { Count: > 0 })
            {
                foreach (ParseError error in errors)
                {
                    Debug.WriteLine("Line: {0}, Column: {1}: {2}", error.Line, error.Column, error.Message);
                    return;
                }
            }

            SqlScriptGenerator sqlScriptGenerator = new Sql110ScriptGenerator();

            TSqlScript sqlScript = fragment as TSqlScript;

            if (sqlScript == null)
            {
                sqlScriptGenerator.GenerateScript(fragment, writer); // TODO execute the script
            }
            else
            {
                foreach (var sqlBatch in sqlScript.Batches)
                {
                    Debug.WriteLine("-- ");
                    sqlScriptGenerator.GenerateScript(sqlBatch, writer); // TODO execute the script
                }
            }
        }

    }
}
