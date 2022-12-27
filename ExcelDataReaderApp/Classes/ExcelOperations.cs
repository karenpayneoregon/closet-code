using System.IO;
using ExcelDataReader;
using Newtonsoft.Json;

namespace ExcelDataReaderApp.Classes
{
    public class ExcelOperations
    {
        /// <summary>
        /// Create a json file using the first worksheet
        /// </summary>
        public static void ToJson(string excelFileName, string jsonFileName)
        {
            using (var stream = File.Open(excelFileName, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        UseColumnDataType = true,
                        ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                        {
                            UseHeaderRow = true
                        }
                    });

                    File.WriteAllText(jsonFileName, JsonConvert.SerializeObject(dataSet.Tables[0], Formatting.Indented));
                }
            }
        }
    }
}