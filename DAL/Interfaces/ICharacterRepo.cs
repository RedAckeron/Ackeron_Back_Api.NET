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
        int AddCharacterInfo(CharacterInfo CInfo);
        int AddCharacterStat(CharacterStat CStat);
        int AddCharacterLoc(CharacterLoc CLoc);
        int AddCharacterPower(CharacterPower CPow);
        int AddCharacterResist(CharacterResist CRes);
    }
}
