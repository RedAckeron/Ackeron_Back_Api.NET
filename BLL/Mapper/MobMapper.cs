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
    public class MobMapper
    {
        /*
        public Info CharacterToCharacterInfo(Character C)
        {
            CInfo.IdChar = C.Id;
            CInfo.Name=C.Info.Name;
            CInfo.Race = C.Info.Race;
            CInfo.Sexe = C.Info.Sexe;
            CInfo.Classe=C.Info.Classe;
            CInfo.CitizenPlanet = C.Info.CitizenPlanet;
            CInfo.TsIn = C.Info.TsIn;
            return CInfo;
        }
        */
        /*
        public Localisator CharacterToCharacterLoc(Character C)
        {
            Localisator Loc = new();
            //CLoc.IdChar = C.Id;
            Loc.LocUId = C.Loc.LocUId;
            Loc.LocSId = C.Loc.LocSId;
            Loc.LocPId = C.Loc.LocPId;
            Loc.LocAId = C.Loc.LocAId;
            Loc.LocZId = C.Loc.LocZId;
            return Loc;
        }
        */
        /*
        public Stat CharacterToCharacterStat(Character C)
        {
            Stat CStat = new();
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
        public Power CharacterToCharacterPower(Character C)
        {
            Power CPow = new();
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
        public Resist CharacterToCharacterResist(Character C)
        {
            Resist CRes = new();
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
        */
    }
}
