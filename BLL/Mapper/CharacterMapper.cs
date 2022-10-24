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
            CLoc.LocU = C.Loc.U;
            CLoc.LocS = C.Loc.S;
            CLoc.LocP = C.Loc.P;
            CLoc.LocA = C.Loc.A;
            CLoc.LocA_X = C.Loc.A_X;
            CLoc.LocA_Y = C.Loc.A_Y;
            return CLoc;
        }
        public CharacterStat CharacterToCharacterStat(Character C)
        {
            CharacterStat CStat = new();
            CStat.Id = C.Id;
            CStat.Name = C.Info.Name;
            return CStat;
        }


    }
  
}
