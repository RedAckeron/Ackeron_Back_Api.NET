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
        public Resist CharacterResistMapper(IDataReader reader)
        {
            Resist CRes = new Resist();
            //CRes.IdChar = (int)reader[1];
            CRes.Eau = (int)reader[2];
            CRes.Feu = (int)reader[3];
            CRes.Air = (int)reader[4];
            CRes.Terre = (int)reader[5];
            CRes.Lumiere = (int)reader[6];
            CRes.Tenebre = (int)reader[7];
            CRes.Tranchant = (int)reader[8];
            CRes.Ecrasant = (int)reader[9];
            CRes.Percant = (int)reader[10];
            CRes.Poison = (int)reader[11];
            return CRes;
        }
    }
}
