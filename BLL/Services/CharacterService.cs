using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using System;
using System.Data;
using System.Data.Common;

namespace BLL.Services
{
    public class CharacterService:ICharacterService
    {
        private readonly ICharacterRepo _characterRepo;
        private readonly ILocalisatorRepo _localisatorRepo;
        public CharacterService(ICharacterRepo characterRepo,ILocalisatorRepo localisatorRepo)
        {
            _characterRepo = characterRepo;
            _localisatorRepo = localisatorRepo;
        }
       
        public Localisator GetLocalisator(int id)
        {
            Localisator datacharloc = new();
            datacharloc = _localisatorRepo.GetLocalisator(id);
            return datacharloc;
        }
        public bool UpdateLocalisator(int Id, Localisator Loc)
        {
           // CharacterMapper mapper = new();
            //CLoc = mapper.CharacterToCharacterLoc(CLoc);
            bool loc = (_localisatorRepo.UpdateLocalisator(Id,Loc) == 1);
            return loc;
        }
        public Character GetOneCharacter(int id)
        {
            //on creez l objet
            Character C = new Character();
            //on recupere les dataset
            Info datacharinfo = new();
            Localisator datacharloc = new();
            Stat datacharstat = new();
            Power datacharpow = new();
            Resist datacharres = new();
            //List<Item>inventory = new List<Item>();
            //List<Spell>spellbook = new List<Spell>();
            //List<Quest>questbook= new List<Quest>();

            datacharinfo = _characterRepo.GetCharacterInfo(id);
            datacharloc = _localisatorRepo.GetLocalisator(id);
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
            Info CInfo;
            Stat CStat;
            Localisator CLoc;
            Power CPow;
            Resist CRes;
        
            CInfo=mapper.CharacterToCharacterInfo(C);
            int IdChar = _characterRepo.AddCharacterInfo(CInfo);
        
            CStat = mapper.CharacterToCharacterStat(C);
            CStat.IdChar = IdChar;
            _characterRepo.AddCharacterStat(CStat);
           
            CLoc = mapper.CharacterToCharacterLoc(C);
            //CLoc.IdChar = IdChar;
            _characterRepo.AddCharacterLoc(C.Id, CLoc);
        
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
            LocalisatorMapper locMapper = new();    
            Info CInfo;
            Stat CStat;
            Localisator CLoc;
            Power CPow;
            Resist CRes;

            CInfo = mapper.CharacterToCharacterInfo(C);
            bool info =(_characterRepo.UpdateCharacterInfo(C.Id,CInfo)==1);
            
            CLoc = mapper.CharacterToCharacterLoc(C);
            //CLoc.IdChar = C.Id;
            bool loc = (_localisatorRepo.UpdateLocalisator(C.Id,CLoc)==1);

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