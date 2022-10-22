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
        CharacterStat AddCharacterStat(CharacterStat CStat);
        CharacterLoc AddCharacterLoc(CharacterLoc CLoc);
    }
}
