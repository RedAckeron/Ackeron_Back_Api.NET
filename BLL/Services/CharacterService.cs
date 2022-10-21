using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using System.Data.Common;

namespace BLL.Services
{
    public class CharacterService:ICharacterService
    {
        private readonly ICharacterRepo _characterRepo;
        public CharacterService(ICharacterRepo characterRepo)
        { 
            _characterRepo = characterRepo;
        }

        IEnumerable<Character> ICharacterService.GetAllCharacters()
        {
            throw new NotImplementedException();
            Character c = new Character();
            
        }

        Character ICharacterService.GetCharacter(int id)
        {
            throw new NotImplementedException();
        }

        public int AddCharacter(Character c)
        {
            _characterRepo.AddCharacterLoc(c.Id,c.Loc_U,c.Loc_S,c.Loc_P,c.Loc_A,c.LocA_X,c.LocA_Y);
            throw new NotImplementedException();
        }
    }
}