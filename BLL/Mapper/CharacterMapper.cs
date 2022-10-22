using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Mapper
{
    public class CharacterMapper
    {
        public CharacterLoc CharacterToCharacterLoc(Character C)
        {
            CharacterLoc CLoc = new();
            CLoc.Id = C.Id;
            CLoc.LocU = C.Loc_U;
            CLoc.LocS = C.Loc_S;
            CLoc.LocP = C.Loc_P;
            CLoc.LocA = C.Loc_A;
            CLoc.LocA_X = C.LocA_X;
            CLoc.LocA_Y = C.LocA_Y;
            return CLoc;
        }
        public CharacterStat CharacterToCharacterStat(Character C)
        {
            CharacterStat CStat = new();
            CStat.Id = C.Id;
            CStat.Name = C.Name;
            return CStat;
        }

    }
  
}
