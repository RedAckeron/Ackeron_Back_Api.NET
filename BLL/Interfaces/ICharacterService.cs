using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ICharacterService
    {
    public IEnumerable<Character> GetAllCharacters();
    public Character GetCharacter(int id);
    public int AddCharacter(Character c);
    }
}
