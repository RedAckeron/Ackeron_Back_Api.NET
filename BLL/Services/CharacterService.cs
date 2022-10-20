using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public class CharacterService:ICharacterService
    {
        private readonly ICharacterRepo _characterRepo;

        public CharacterService(ICharacterRepo characterRepo)
        { 
            _characterRepo = characterRepo;
        }

        IEnumerable<Character> GetAllCharacters()
        {

            throw new NotImplementedException();
        }

        Character GetCharacter(int id)
        {
            throw new NotImplementedException();
        }

        int AddCharacter(string Name, int LocX, int LocY)
        {
            throw new NotImplementedException();
        }
    }
}