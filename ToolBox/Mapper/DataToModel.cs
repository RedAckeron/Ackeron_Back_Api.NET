using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.Mapper
{
    public abstract class DataToModel
    {
        public virtual List<T> GetList<T>(IDataReader reader)where T:new()
        {
            List<T> list = new List<T>();
            while (reader.Read())
            {
                var type = typeof(T);
                T obj = (T)Activator.CreateInstance(type);
                foreach (var prop in type.GetProperties())
                {
                    var propType = prop.PropertyType;
                    if(propType == typeof(DateOnly))
                    {
                        prop.SetValue(obj, Convert.ChangeType(DateOnly.Parse(reader[prop.Name].ToString().Substring(0,8)), propType));
                    }
                    else
                    {
                        prop.SetValue(obj, Convert.ChangeType(reader[prop.Name].ToString(), propType));
                    }
                }
                list.Add(obj);
            }

            return list;
        }
    }
}
