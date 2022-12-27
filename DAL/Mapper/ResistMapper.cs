using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class ResistMapper
    {
        public Resist DataToResist(IDataReader reader)
        {
            Resist Res = new Resist(
                (int)reader["id"],
                (int)reader["eau"],
                (int)reader["feu"],
                (int)reader["air"],
                (int)reader["terre"],
                (int)reader["lumiere"],
                (int)reader["tenebre"],
                (int)reader["tranchant"],
                (int)reader["ecrasant"],
                (int)reader["percant"],
                (int)reader["poison"]
                );
            /*
            Res.ResistId = (int)reader["id"];
            Res.Eau = (int)reader[2];
            Res.Feu = (int)reader[3];
            Res.Air = (int)reader[4];
            Res.Terre = (int)reader[5];
            Res.Lumiere = (int)reader[6];
            Res.Tenebre = (int)reader[7];
            Res.Tranchant = (int)reader[8];
            Res.Ecrasant = (int)reader[9];
            Res.Percant = (int)reader[10];
            Res.Poison = (int)reader[11];
            */
            return Res;
        }
    }
}
