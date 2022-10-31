using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class CharacterMapper
    {
        public CharacterInfo CharacterToCharacterInfo(Character C)
        {
            CharacterInfo CInfo = new CharacterInfo();
            CInfo.IdChar = C.Id;
            CInfo.Name=C.Info.Name;
            CInfo.Race = C.Info.Race;
            CInfo.Sexe = C.Info.Sexe;
            CInfo.Classe=C.Info.Classe;
            CInfo.CitizenPlanet = C.Info.CitizenPlanet;
            CInfo.TsIn = C.Info.TsIn;
            return CInfo;
        }
        public CharacterLoc CharacterToCharacterLoc(Character C)
        {
            CharacterLoc CLoc = new();
            CLoc.IdChar = C.Id;
            CLoc.LocU = C.Loc.LocU;
            CLoc.LocS = C.Loc.LocS;
            CLoc.LocP = C.Loc.LocP;
            CLoc.LocA = C.Loc.LocA;
            CLoc.LocA_X = C.Loc.LocA_X;
            CLoc.LocA_Y = C.Loc.LocA_Y;
            return CLoc;
        }
        public CharacterStat CharacterToCharacterStat(Character C)
        {
            CharacterStat CStat = new();
            CStat.IdChar = C.Id;
            CStat.TimestampSimul = C.Stat.TimestampSimul;
            CStat.PtMove = C.Stat.PtMove;
            CStat.PtMoveMax = C.Stat.PtMoveMax;
            CStat.Xp = C.Stat.Xp;
            CStat.Gold = C.Stat.Gold;
            CStat.Pv = C.Stat.Pv;
            CStat.PvMax = C.Stat.PvMax;
            CStat.Pw = C.Stat.Pw;
            CStat.PwMax = C.Stat.PwMax;
            return CStat;
        }
        public CharacterPower CharacterToCharacterPower(Character C)
        {
            CharacterPower CPow = new();
            CPow.IdChar = C.Id;
            CPow.Eau = C.Power.Eau;
            CPow.Feu = C.Power.Terre;
            CPow.Air = C.Power.Air;
            CPow.Terre = C.Power.Terre;
            CPow.Lumiere = C.Power.Lumiere;
            CPow.Tenebre = C.Power.Tenebre;
            CPow.Tranchant = C.Power.Tranchant;
            CPow.Ecrasant = C.Power.Ecrasant;
            CPow.Percant = C.Power.Percant;
            CPow.Poison = C.Power.Poison;
            return CPow;
        }
        public CharacterResist CharacterToCharacterResist(Character C)
        {
            CharacterResist CRes = new();
            CRes.IdChar = C.Id;
            CRes.Eau = C.Resist.Eau;
            CRes.Feu = C.Resist.Terre;
            CRes.Air = C.Resist.Air;
            CRes.Terre = C.Resist.Terre;
            CRes.Lumiere = C.Resist.Lumiere;
            CRes.Tenebre = C.Resist.Tenebre;
            CRes.Tranchant = C.Resist.Tranchant;
            CRes.Ecrasant = C.Resist.Ecrasant;
            CRes.Percant = C.Resist.Percant;
            CRes.Poison = C.Resist.Poison;
            return CRes;
        }
    }
}
