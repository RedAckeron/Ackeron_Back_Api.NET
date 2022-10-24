using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
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
        /*
        public IEnumerable<Character> GetAllCharacters()
        {
            throw new NotImplementedException();
        }

        public Character GetCharacter(int id)
        {
            throw new NotImplementedException();
        }
        */
        public int AddCharacter(Character C)
        {
        CharacterMapper mapper = new();
        CharacterStat CStat = new();
        CharacterLoc CLoc = new();
        CharacterResist CRes= new();
        CharacterPower CPow= new();
        CStat = mapper.CharacterToCharacterStat(C);
        CLoc = mapper.CharacterToCharacterLoc(C);

        _characterRepo.AddCharacterLoc(CLoc);
        _characterRepo.AddCharacterStat(CStat);

        return 1;
        }
    }
}