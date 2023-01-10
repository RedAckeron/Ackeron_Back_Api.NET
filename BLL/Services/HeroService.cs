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
        private readonly IHeroRepo _herorepo;
        public HeroService(ILocalisatorRepo localisatorRepo, IInfoRepo infoRepo, IStatRepo statRepo, IPowerRepo powerRepo, IResistRepo resistRepo, IHeroRepo heroRepo)
        {
            _localisatorRepo = localisatorRepo;
            _infoRepo = infoRepo;
            _statRepo = statRepo;
            _powerRepo = powerRepo;
            _resistRepo = resistRepo;
            _herorepo = heroRepo;
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
            hero.Id = _herorepo.Create(hero);
            Console.WriteLine("Hero ID : " + hero.Id);

            Console.WriteLine("=============================================[  FIN CREATION HERO  ]=============================================");
            return hero.Id;
        }
    }
}
