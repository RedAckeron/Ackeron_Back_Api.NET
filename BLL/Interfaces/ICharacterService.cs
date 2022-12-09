using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICharacterService
    {
    //public IEnumerable<Character> GetAllCharacters();
    //public Character GetCharacter(int id);
    int AddCharacter(Character c);
    Localisator GetLocalisator(int id);
    bool UpdateLocalisator(int Id,Localisator Loc);
    Character GetOneCharacter(int id);
    bool UpdateCharacter(Character c);
    }
}
