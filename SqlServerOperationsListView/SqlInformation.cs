using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using SqlServerOperations.Classes;

namespace SqlServerOperations
{
    public class SqlInformation 
    {

        public Dictionary<string, List<ServerTableItem>> TableDependencies()
        {

            var informationTable = new DataTable();

            var selectStatement = @"
                SELECT	syso.name [Table],
		                sysc.name [Field], 
		                sysc.colorder [FieldOrder], 
		                syst.name [DataType], 
		                sysc.[length] [Length], 
		                CASE WHEN sysc.prec IS NULL THEN 'NULL' ELSE CAST(sysc.prec AS VARCHAR) END [Precision],
                CASE WHEN sysc.scale IS null THEN '-' ELSE sysc.scale END [Scale], 
                CASE WHEN sysc.isnullable = 1 THEN 'True' ELSE 'False' END [AllowNulls], 
                CASE WHEN sysc.[status] = 128 THEN 'True' ELSE 'False' END [Identity], 
                CASE WHEN sysc.colstat = 1 THEN 'True' ELSE 'False' END [PrimaryKey],
                CASE WHEN fkc.parent_object_id is NULL THEN 'False' ELSE 'True' END [ForeignKey], 
                CASE WHEN fkc.parent_object_id is null THEN '(none)' ELSE obj.name  END [RelatedTable],
                CASE WHEN ep.value is NULL THEN '(none)' ELSE CAST(ep.value as NVARCHAR(500)) END [Description]
                FROM [sys].[sysobjects] AS syso
                JOIN [sys].[syscolumns] AS sysc on syso.id = sysc.id
                LEFT JOIN [sys].[systypes] AS syst ON sysc.xtype = syst.xtype and syst.name != 'sysname'
                LEFT JOIN [sys].[foreign_key_columns] AS fkc on syso.id = fkc.parent_object_id and 
                    sysc.colid = fkc.parent_column_id    
                LEFT JOIN [sys].[objects] AS obj ON fkc.referenced_object_id = obj.[object_id]
                LEFT JOIN [sys].[extended_properties] AS ep ON syso.id = ep.major_id and sysc.colid = 
                    ep.minor_id and ep.name = 'MS_Description'
                WHERE syso.type = 'U' AND  syso.name != 'sysdiagrams'
                ORDER BY [Table], FieldOrder, Field;";

            using (var cn = new SqlConnection() {ConnectionString = ConnectionString})
            {
                using (var cmd = new SqlCommand() {Connection = cn})
                {
                    cmd.CommandText = selectStatement;
                    cn.Open();

                    informationTable.Load(cmd.ExecuteReader());
                }
            }

            var result = 
                from row in informationTable.AsEnumerable()
                group row by row.Field<string>("Table") into grp
                select new
                {
                    TableName = grp.Key,
                    Rows = grp,
                    Count = grp.Count() 
                };

            var tableDictionary = new Dictionary<string, List<ServerTableItem>>();

            foreach (var topItem in result)
            {

                if (!tableDictionary.ContainsKey(topItem.TableName))
                {
                    tableDictionary[topItem.TableName] = new List<ServerTableItem>();
                }

                foreach (var row in topItem.Rows)
                {
                    tableDictionary[topItem.TableName].Add(new ServerTableItem()
                    {
                        Table = topItem.TableName,
                        Field = row.Field<string>("Field"),
                        FieldOrder = row.Field<short>("FieldOrder"),
                        DataType = row.Field<string>("DataType"),
                        Length = row.Field<short>("Length"),
                        Precision = row.Field<string>("Precision"),
                        Scale = row.Field<int>("Scale"),
                        AllowNulls = row.Field<string>("AllowNulls"),
                        Identity = row.Field<string>("Identity"),
                        PrimaryKey = row.Field<string>("PrimaryKey"),
                        ForeignKey = row.Field<string>("ForeignKey"),
                        RelatedTable = row.Field<string>("RelatedTable"),
                        Description = row.Field<string>("Description")
                    });
                }
            }

            return tableDictionary;
        }

        public string ConnectionString 
            => "Server=.\\SQLEXPRESS;Database=NorthWind2020;Integrated Security=true";


    }
}
