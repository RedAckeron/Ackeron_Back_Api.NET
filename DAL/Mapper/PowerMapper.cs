using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper.Map
{
    public class PowerMapper
    {
        public Power CharacterPowerMapper(IDataReader reader)
        {
            Power CPow = new Power();
            //CPow.IdChar = (int)reader[1];
            CPow.Eau = (int)reader[2];
            CPow.Feu = (int)reader[3];
            CPow.Air = (int)reader[4];
            CPow.Terre = (int)reader[5];
            CPow.Lumiere = (int)reader[6];
            CPow.Tenebre = (int)reader[7];
            CPow.Tranchant = (int)reader[8];
            CPow.Ecrasant = (int)reader[9];
            CPow.Percant = (int)reader[10];
            CPow.Poison = (int)reader[11];
            return CPow;
        }
    }
}
