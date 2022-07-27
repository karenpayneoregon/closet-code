using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CommonLibrary.LanguageExtensions
{
    public static class Extensions
    {
        /// <summary>
        /// Convert DataTable to List of T
        /// </summary>
        /// <typeparam name="TSource">Type to return from DataTable</typeparam>
        /// <param name="table">DataTable</param>
        /// <returns>List of <see cref="TSource"/>Expected type list</returns>
        public static List<TSource> DataTableToList<TSource>(this DataTable table) where TSource : new()
        {
            List<TSource> list = new();

            var typeProperties = typeof(TSource).GetProperties().Select(propertyInfo => new
            {
                PropertyInfo = propertyInfo,
                Type = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType
            }).ToList();

            foreach (var row in table.Rows.Cast<DataRow>())
            {

                TSource current = new();

                foreach (var typeProperty in typeProperties)
                {
                    object value = row[typeProperty.PropertyInfo.Name];
                    object safeValue = value is null || DBNull.Value.Equals(value) ? 
                        null : 
                        Convert.ChangeType(value, typeProperty.Type!);

                    typeProperty.PropertyInfo.SetValue(current, safeValue, null);
                }

                list.Add(current);

            }

            return list;
        }
    }
}
