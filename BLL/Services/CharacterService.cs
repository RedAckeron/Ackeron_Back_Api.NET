using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using System.Data;
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
        */
        public Character GetOneCharacter(int id)
        {
            //on creez l objet
            Character C = new Character();

            //on recupere les dataset
            CharacterInfo datacharinfo = new();
            CharacterLoc datacharloc = new();
            CharacterStat datacharstat = new();
            CharacterPower datacharpow = new();
            CharacterResist datacharres = new();
            datacharinfo = _characterRepo.GetCharacterInfo(id);
            datacharloc = _characterRepo.GetCharacterLoc(id);
            datacharstat = _characterRepo.GetCharacterStat(id);
            datacharpow = _characterRepo.GetCharacterPower(id);
            datacharres = _characterRepo.GetCharacterResist(id);
            //on rempli l objet char avec ses sous objets
            C.Info = datacharinfo;
            C.Loc = datacharloc;
            C.Stat = datacharstat;
            C.Power = datacharpow;
            C.Resist = datacharres;

            return C;
        }
        
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
        public int UpdateCharacter(Character C)
        {

            CharacterMapper mapper = new();
            CharacterInfo CInfo;
            CharacterStat CStat;
            CharacterLoc CLoc;
            CharacterPower CPow;
            CharacterResist CRes;

            CInfo = mapper.CharacterToCharacterInfo(C);
            int CharInfo= _characterRepo.UpdateCharacterInfo(CInfo);
            
            CStat = mapper.CharacterToCharacterStat(C);
            int CharStat = _characterRepo.UpdateCharacterStat(CStat);
            /*
            CLoc = mapper.CharacterToCharacterLoc(C);
            CLoc.IdChar = IdChar;
            _characterRepo.AddCharacterLoc(CLoc);

            CPow = mapper.CharacterToCharacterPower(C);
            CPow.IdChar = IdChar;
            _characterRepo.AddCharacterPower(CPow);

            CRes = mapper.CharacterToCharacterResist(C);
            CRes.IdChar = IdChar;
            _characterRepo.AddCharacterResist(CRes);
            */
            return CharInfo+CharStat;

        }
    }
}