using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class HeroService:IHeroService
    {
        private readonly ILocalisatorRepo _localisatorRepo;
        private readonly IInfoRepo _infoRepo;
        private readonly IStatRepo _statRepo;
        private readonly IPowerRepo _powerRepo;
        private readonly IResistRepo _resistRepo;
        private readonly ICharacterRepo _characterRepo;
        public HeroService(ILocalisatorRepo localisatorRepo, IInfoRepo infoRepo, IStatRepo statRepo, IPowerRepo powerRepo, IResistRepo resistRepo, ICharacterRepo characterRepo)
        {
            _localisatorRepo = localisatorRepo;
            _infoRepo = infoRepo;
            _statRepo = statRepo;
            _powerRepo = powerRepo;
            _resistRepo = resistRepo;
            _characterRepo = characterRepo;
        }

        public int Create(Hero H)
        {
            Console.WriteLine("=============================================[ DEBUT CREATION HERO ]=============================================");

            //on creez le localisator et on retourne l id qu on attribue au loc id de l objet mob
            Localisator localisator = new Localisator(0, H.Localisator.LocUId, H.Localisator.LocSId, H.Localisator.LocSX, H.Localisator.LocSY, H.Localisator.LocPId, H.Localisator.LocPX, H.Localisator.LocPY, H.Localisator.LocAId, H.Localisator.LocAX, H.Localisator.LocAY, H.Localisator.LocZId, H.Localisator.LocZX, H.Localisator.LocZY);
            localisator.LocalisatorId = _localisatorRepo.Create(localisator);
            Console.WriteLine("LocalisatorId : " + localisator.LocalisatorId);

            //on creez linfo et on retourne l id qu on attribue au infoId du mob 
            Info info = new Info(0, H.Info.Name, H.Info.Race, H.Info.Sexe, H.Info.Classe, H.Info.Gold, H.Info.CitizenPlanet, H.Info.Img, "nord");
            info.InfoId = _infoRepo.Create(info);
            Console.WriteLine("InfoId : " + info.InfoId);
            //on creez le stat et on retourne l id qu on attribue au powerid du mob 
            Stat stat = new Stat(0, H.Stat.PtMove, H.Stat.PtMoveMax,0,0, H.Stat.Xp, H.Stat.Pv, H.Stat.PvMax, H.Stat.Pw, H.Stat.PwMax, H.Stat.TimeStampSimul);
            stat.StatId = _statRepo.Create(stat);
            Console.WriteLine("StatId : " + stat.StatId);

            //on creez le power et on retourne l id qu on attribue au powerid du mob 
            Power power = new Power(0, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);
            power.PowerId = _powerRepo.Create(power);
            Console.WriteLine("PowerId : " + power.PowerId);

            //on creez le Resist et on retourne l id qu on attribue au resistid du mob 
            Resist resist = new Resist(0, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10);
            resist.ResistId = _resistRepo.Create(resist);
            Console.WriteLine("ResistId : " + resist.ResistId);

            List<Item> inventory = new List<Item>();

            List<Spell> spellBook = new List<Spell>();


            //on creez la date d insertion en timestamp
            DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
            long TsIn = now.ToUnixTimeSeconds();
            int coolDown = 1000;
            Console.WriteLine("Ts Creation : " + TsIn);

            //et finalement on creez le mob a remonter vers le controler
            Hero hero = new Hero(0, TsIn, coolDown, info, localisator, stat, power, resist, inventory, spellBook);
            hero.Id = _characterRepo.CreateHero(hero);
            Console.WriteLine("Hero ID : " + hero.Id);

            Console.WriteLine("=============================================[  FIN CREATION HERO  ]=============================================");
            return hero.Id;
        }

        public Hero Read(int IdHero)
        {

            Info info;
            Localisator localisator;
            Stat stat;

            Power power;
            Resist resist;

            List<Spell> spellbook = new();
            List<Item> inventory = new();

            //recuperation et reconstruction du hero
            Hero hero;
            hero = _characterRepo.ReadHero(IdHero);

            info = _infoRepo.Read(hero.Info.InfoId);
            hero.Info = info;

            localisator = _localisatorRepo.Read(hero.Localisator.LocalisatorId);
            hero.Localisator = localisator;

            stat = _statRepo.Read(hero.Stat.StatId);
            hero.Stat = stat;

            power = _powerRepo.Read(hero.Power.PowerId);
            hero.Power = power;

            resist = _resistRepo.Read(hero.Resist.ResistId);
            hero.Resist = resist;


            //Console.WriteLine(JsonSerializer.Serialize(mob));


            // public Mob(int id,long tsin,Info info,Localisator localisator,int mobGabaritId,Stat stat, Power power, Resist resist, List<Item> inventory, List<Spell> spellBook)
            //: base(id, tsin, info, localisator)

            return hero;
        }
        public Localisator Move(int idchar, char orientation)
        {
            //on recupere l id du localisator du joueur 
            int Idloc=_localisatorRepo.GetCharLocalisator(idchar);



            Localisator loc = _localisatorRepo.Read(Idloc);

            Console.WriteLine(loc.LocPId + " : " + loc.LocAX + "/" + loc.LocAY);

            //on recupere le localisator du char 

            //SP_Map_CheckAreaWalkable
            // on calcule si la position d arriver est libre
            // on valide la nouvelle position et on met a jours
            //on retourne le localisator update

            return loc;

        }


        /*
         public Localisator ReadLocalisator(int id)
         {
             Localisator datacharloc = new();
             datacharloc = _localisatorRepo.ReadLocalisator(id);
             return datacharloc;
         }
         public bool UpdateLocalisator(int Id, Localisator Loc)
         {
            // CharacterMapper mapper = new();
             //CLoc = mapper.CharacterToCharacterLoc(CLoc);
             bool loc = (_localisatorRepo.UpdateLocalisator(Id,Loc) == 1);
             return loc;
         }
        */
        /*
        public Character GetById(int id)
        {
            //on creez l objet
            //Character C = new Character();
            Hero H = new Hero();
            Localisator datacharloc = new();
            Stat datacharstat = new();
            Power datacharpow = new();
            Resist datacharres = new();

            //List<Item>inventory = new List<Item>();
            //List<Spell>spellbook = new List<Spell>();
            //List<Quest>questbook= new List<Quest>();

            //datacharinfo = _characterRepo.GetCharacterInfo(id);
            datacharloc = _localisatorRepo.ReadLocalisator(id);
            datacharstat = _characterRepo.GetCharacterStat(id);
            datacharpow = _characterRepo.GetCharacterPower(id);
            datacharres = _characterRepo.GetCharacterResist(id);

            //on rempli l objet char avec ses sous objets
            //C.Info = datacharinfo;

            C.Localisator = datacharloc;
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
            //Info CInfo;
            Hero CStat;
            Localisator CLoc;
            Power CPow;
            Resist CRes;
            
            CInfo = mapper.CharacterToCharacterInfo(C);
            int IdChar = _characterRepo.AddCharacterInfo(CInfo);

            CStat = mapper.CharacterToCharacterStat(C);
            CStat.IdChar = IdChar;
            _characterRepo.AddCharacterStat(CStat);

            CLoc = mapper.CharacterToCharacterLoc(C);
            //CLoc.IdChar = IdChar;
            _characterRepo.AddCharacterLoc(C.Id, CLoc);

            CPow = mapper.CharacterToCharacterPower(C);
            CPow.IdChar = IdChar;
            _characterRepo.AddCharacterPower(CPow);

            CRes = mapper.CharacterToCharacterResist(C);
            CRes.IdChar = IdChar;
            _characterRepo.AddCharacterResist(CRes);

            return IdChar;
            
        }
        public bool UpdateCharacter(Character C)
        {
            CharacterMapper mapper = new();
            LocalisatorMapper locMapper = new();
            
            Hero CStat;
            Localisator CLoc;
            Power CPow;
            Resist CRes;

            CInfo = mapper.CharacterToCharacterInfo(C);
            bool info = (_characterRepo.UpdateCharacterInfo(C.Id, CInfo) == 1);

            CLoc = mapper.CharacterToCharacterLoc(C);
            //CLoc.IdChar = C.Id;
            bool loc = (_localisatorRepo.UpdateLocalisator(C.Id, CLoc) == 1);

            CStat = mapper.CharacterToCharacterStat(C);
            CStat.IdChar = C.Id;
            bool stat = (_characterRepo.UpdateCharacterStat(CStat) == 1);

            CPow = mapper.CharacterToCharacterPower(C);
            CPow.IdChar = C.Id;
            bool power = (_characterRepo.UpdateCharacterPower(CPow) == 1);

            CRes = mapper.CharacterToCharacterResist(C);
            CRes.IdChar = C.Id;
            bool resist = (_characterRepo.UpdateCharacterResist(CRes) == 1);

            return (info || loc || stat || power || resist);
        }
        public bool DeleteCharacter(int id)
        {
            return true;
        }
        */
    }
}
