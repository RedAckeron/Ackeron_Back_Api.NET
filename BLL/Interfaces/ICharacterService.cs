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
    IEnumerable<Character> GetAllCharacters();
    Character GetCharacter(int id);
    int AddCharacter(Character c);
    }
}
