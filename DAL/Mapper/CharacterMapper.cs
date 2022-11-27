using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class CharacterMapper
    {
        public CharacterInfo CharacterInfoMapper(IDataReader reader)
        {
            CharacterInfo CInfo = new CharacterInfo();
            //CInfo.IdChar = (int)reader[0];
            CInfo.Name= (string)reader[1];
            CInfo.Race = (int)reader[2];
            CInfo.Sexe = (int)reader[3];
            CInfo.Classe= (int)reader[4];
            CInfo.CitizenPlanet= (int)reader[5];
            CInfo.TsIn= (int)reader[6];
            return CInfo;
        }
        public CharacterStat CharacterStatMapper(IDataReader reader)
        {
            CharacterStat CStat = new CharacterStat();
            //CStat.IdChar = (int)reader[1];
            CStat.TimestampSimul = (int)reader[2];
            CStat.PtMove = (int)reader[3];
            CStat.PtMoveMax = (int)reader[4];
            CStat.Xp = (int)reader[5];
            CStat.Pv = (int)reader[6];
            CStat.PvMax = (int)reader[7];
            CStat.Pw = (int)reader[8];
            CStat.PwMax = (int)reader[9];
            CStat.Gold = (int)reader[10];
            return CStat;
        }
        public CharacterLoc CharacterLocMapper(IDataReader reader)
        {
            CharacterLoc CLoc = new CharacterLoc();
            CLoc.IdChar = (int)reader[1];
            CLoc.LocU = (int)reader[2];
            CLoc.LocS = (int)reader[3];
            CLoc.LocP = (int)reader[4];
            CLoc.LocA = (int)reader[5];
            CLoc.LocA_X = (int)reader[6];
            CLoc.LocA_Y = (int)reader[7];
            Console.WriteLine("IdChar:" + CLoc.IdChar + " => " + CLoc.LocA_X + "/" + CLoc.LocA_Y);
            return CLoc;
            
        }
        public CharacterPower CharacterPowerMapper(IDataReader reader)
        {
            CharacterPower CPow = new CharacterPower();
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
        public CharacterResist CharacterResistMapper(IDataReader reader)
        {
            CharacterResist CRes = new CharacterResist();
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