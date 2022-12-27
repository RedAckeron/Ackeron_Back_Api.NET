using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class InfoMapper
    {
        public Info DataToInfo(IDataReader reader)
        {
            Info info = new Info(
                (int)reader["id"],
                (string)reader["Name"],
                (int)reader["race"],
                (int)reader["sexe"],
                (int)reader["classe"],
                (int)reader["gold"],
                (int)reader["CitizenPlanet"]
                );
        return info;
        }
    }
}
