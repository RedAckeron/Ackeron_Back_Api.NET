using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICharacterRepo
    {
        CharacterLoc GetCharacterLoc(int idChar);
        CharacterStat GetCharacterStat(int idChar);
        CharacterLoc AddCharacterLoc(int IdChar, int LocU, int LocS, int LocP, int LocA, int LocA_X, int LocA_Y);


    }
}
