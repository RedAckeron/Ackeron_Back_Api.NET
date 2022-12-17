using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class StatMapper
    {
        public Stat CharacterStatMapper(IDataReader reader)
        {
            Stat CStat = new Stat();
            //CStat.IdChar = (int)reader[1];
            CStat.PtMove = (int)reader[3];
            CStat.PtMoveMax = (int)reader[4];
            CStat.Xp = (int)reader[5];
            CStat.Pv = (int)reader[6];
            CStat.PvMax = (int)reader[7];
            CStat.Pw = (int)reader[8];
            CStat.PwMax = (int)reader[9];
            return CStat;
        }      
    }
}