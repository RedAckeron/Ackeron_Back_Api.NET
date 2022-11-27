using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using System;
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
        public CharacterLoc GetCharacterLoc(int id)
        {
            CharacterLoc datacharloc = new();
            datacharloc = _characterRepo.GetCharacterLoc(id);
            return datacharloc;
        }
        public bool UpdateCharacterLoc(CharacterLoc CLoc)
        {
           // CharacterMapper mapper = new();
            //CLoc = mapper.CharacterToCharacterLoc(CLoc);
            bool loc = (_characterRepo.UpdateCharacterLoc(CLoc) == 1);
            return loc; 
        }
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
            //List<Item>inventory = new List<Item>();
            //List<Spell>spellbook = new List<Spell>();
            //List<Quest>questbook= new List<Quest>();

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
            C.Inventory = _characterRepo.GetCharacterInventory(id);
            C.SpellBook = _characterRepo.GetCharacterSpell(id);
            C.QuestBook = _characterRepo.GetCharacterQuest(id);
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
        public bool UpdateCharacter(Character C)
        {
            CharacterMapper mapper = new();
            CharacterInfo CInfo;
            CharacterStat CStat;
            CharacterLoc CLoc;
            CharacterPower CPow;
            CharacterResist CRes;

            CInfo = mapper.CharacterToCharacterInfo(C);
            bool info =(_characterRepo.UpdateCharacterInfo(CInfo)==1);
            
            CLoc = mapper.CharacterToCharacterLoc(C);
            CLoc.IdChar = C.Id;
            bool loc = (_characterRepo.UpdateCharacterLoc(CLoc)==1);

            CStat = mapper.CharacterToCharacterStat(C);
            CStat.IdChar = C.Id;
            bool stat = (_characterRepo.UpdateCharacterStat(CStat)==1);

            CPow = mapper.CharacterToCharacterPower(C);
            CPow.IdChar = C.Id;
            bool power = (_characterRepo.UpdateCharacterPower(CPow)==1);

            CRes = mapper.CharacterToCharacterResist(C);
            CRes.IdChar = C.Id;
            bool resist = (_characterRepo.UpdateCharacterResist(CRes)==1);
            
            return (info || loc || stat || power ||resist);
        }
    }
}