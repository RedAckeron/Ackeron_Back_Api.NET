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
        CharacterInfo CInfo;
        CharacterStat CStat;
        CharacterLoc CLoc;
        CharacterPower CPow;
        CharacterResist CRes;
        
        CInfo=mapper.CharacterToCharacterInfo(C);
        int IdChar = _characterRepo.AddCharacterInfo(CInfo);
        
        CStat = mapper.CharacterToCharacterStat(C);
        CStat.IdChar = IdChar;
        _characterRepo.AddCharacterStat(CStat);
           
        CLoc = mapper.CharacterToCharacterLoc(C);
        CLoc.IdChar = IdChar;
        _characterRepo.AddCharacterLoc(CLoc);
        
        CPow=mapper.CharacterToCharacterPower(C);
        CPow.IdChar = IdChar;
        _characterRepo.AddCharacterPower(CPow);
        
        CRes=mapper.CharacterToCharacterResist(C);
        CRes.IdChar = IdChar;
        _characterRepo.AddCharacterResist(CRes);
        
        return IdChar;
        }
    }
}