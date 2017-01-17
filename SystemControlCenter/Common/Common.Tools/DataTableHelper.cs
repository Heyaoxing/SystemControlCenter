using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Tools
{
    public class DataTableHelper
    {
        /// <summary>
        /// DataTable转换为实体对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static T GetEntity<T>(DataTable table) where T : new()
        {
            T entity = new T();
            foreach (DataRow row in table.Rows)
            {
                foreach (var item in entity.GetType().GetProperties())
                {
                    if (row.Table.Columns.Contains(item.Name))
                    {
                        if (DBNull.Value != row[item.Name])
                        {
                            item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                        }

                    }
                }
            }

            return entity;
        }

        /// <summary>
        /// DataTable转换为实体对象集合
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="table"></param>
        /// <returns></returns>
        public static List<T> GetEntities<T>(DataTable table) where T : new()
        {
            var entities = new List<T>();
            foreach (DataRow row in table.Rows)
            {
                T entity = new T();
                foreach (var item in entity.GetType().GetProperties())
                {
                    try
                    {
                        item.SetValue(entity, Convert.ChangeType(row[item.Name], item.PropertyType), null);
                    }
                    catch
                    {
                    }
                }
                entities.Add(entity);
            }
            return entities;
        }
    }
}
