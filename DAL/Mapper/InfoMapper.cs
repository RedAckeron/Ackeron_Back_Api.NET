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
        public Info CharacterInfoMapper(IDataReader reader)
        {
            Info CInfo = new Info();
            //CInfo.IdChar = (int)reader[0];
            CInfo.Name = (string)reader[1];
            CInfo.Race = (int)reader[2];
            CInfo.Sexe = (int)reader[3];
            CInfo.Classe = (int)reader[4];
            CInfo.CitizenPlanet = (int)reader[5];
            CInfo.TsIn = (int)reader[6];
            return CInfo;
        }
    }
}
