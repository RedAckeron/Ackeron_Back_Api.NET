using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
namespace BLL.Services
{
    public class MobService : IMobService
    {
        
        private readonly ILocalisatorRepo _localisatorRepo;
        private readonly IInfoRepo _infoRepo;
        private readonly IStatRepo _statRepo;
        private readonly IPowerRepo _powerRepo;
        private readonly IResistRepo _resistRepo;
        private readonly IMobrepo _mobrepo; 
        public MobService(ILocalisatorRepo localisatorRepo,IInfoRepo infoRepo,IStatRepo statRepo,IPowerRepo powerRepo,IResistRepo resistRepo,IMobrepo mobRepo)
        {
            _localisatorRepo = localisatorRepo;
            _infoRepo = infoRepo;
            _statRepo = statRepo;
            _powerRepo = powerRepo; 
            _resistRepo = resistRepo;   
            _mobrepo = mobRepo;
        }
//####################################################################################################################################################################
        public int Create(Mob M)
        {
            Console.WriteLine("=============================================[ DEBUT CREATION MOB ]=============================================");
            
            //on creez le localisator et on retourne l id qu on attribue au loc id de l objet mob
            Localisator localisator = new Localisator(0, M.Localisator.LocUId, M.Localisator.LocSId, M.Localisator.LocSX, M.Localisator.LocSY, M.Localisator.LocPId, M.Localisator.LocPX, M.Localisator.LocPY, M.Localisator.LocAId, M.Localisator.LocAX, M.Localisator.LocAY, M.Localisator.LocZId, M.Localisator.LocZX, M.Localisator.LocZY);
            localisator.LocalisatorId = _localisatorRepo.Create(localisator);
            Console.WriteLine("LocalisatorId : "+localisator.LocalisatorId);
            
            //on creez linfo et on retourne l id qu on attribue au infoId du mob 
            Info info = new Info(0,M.Info.Name,M.Info.Race,M.Info.Sexe,M.Info.Classe,M.Info.Gold,M.Info.CitizenPlanet,M.Info.Img,"nord");
            info.InfoId=_infoRepo.Create(info);
            Console.WriteLine("InfoId : "+info.InfoId);
            //on creez le stat et on retourne l id qu on attribue au powerid du mob 
            Stat stat = new Stat(0,M.Stat.PtMove,M.Stat.PtMoveMax,M.Stat.Xp,M.Stat.Pv,M.Stat.PvMax,M.Stat.Pw,M.Stat.PwMax,M.Stat.TimeStampSimul);
            stat.StatId = _statRepo.Create(stat);
            Console.WriteLine("StatId : " + stat.StatId);

            //on creez le power et on retourne l id qu on attribue au powerid du mob 
            Power power = new Power(0,10,10,10,10,10,10,10,10,10,10);
            power.PowerId=_powerRepo.Create(power);
            Console.WriteLine("PowerId : " + power.PowerId);

            //on creez le Resist et on retourne l id qu on attribue au resistid du mob 
            Resist resist = new Resist(0,10,10,10,10,10,10,10,10,10,10);
            resist.ResistId=_resistRepo.Create(resist);
            Console.WriteLine("ResistId : " + resist.ResistId);

            List<Item> inventory = new List<Item>();
            
            List<Spell> spellBook = new List<Spell>();


            //on creez la date d insertion en timestamp
            DateTimeOffset now = (DateTimeOffset)DateTime.UtcNow;
            long TsIn= now.ToUnixTimeSeconds();
                       
            Console.WriteLine("Ts Creation : " + TsIn);

            //et finalement on creez le mob a remonter vers le controler
            Mob mob = new Mob(0, TsIn, info,localisator,0,stat, power, resist, inventory, spellBook);
            mob.Id=_mobrepo.Create(mob);
            Console.WriteLine("Mob ID : "+mob.Id);

            Console.WriteLine("=============================================[  FIN CREATION MOB  ]=============================================");
            return mob.Id;
        }
//####################################################################################################################################################################
        public Mob Read(int IdMob) {
            Info info;
            Localisator localisator;
            Stat stat;

            Power power;
            Resist resist;
            
            List<Spell> spellbook = new();
            List<Item> inventory = new();
            
            //recuperation et reconstruction du mob
            Mob mob ;
            mob = _mobrepo.Read(IdMob);
            
            info = _infoRepo.Read(mob.Info.InfoId);
            mob.Info = info;
            
            localisator = _localisatorRepo.Read(mob.Localisator.LocalisatorId);
            mob.Localisator = localisator;
            
            stat = _statRepo.Read(mob.Stat.StatId);
            mob.Stat = stat;
            
            power = _powerRepo.Read(mob.Power.PowerId);
            mob.Power = power;
            
            resist = _resistRepo.Read(mob.Resist.ResistId);
            mob.Resist = resist;


            //Console.WriteLine(JsonSerializer.Serialize(mob));


            // public Mob(int id,long tsin,Info info,Localisator localisator,int mobGabaritId,Stat stat, Power power, Resist resist, List<Item> inventory, List<Spell> spellBook)
            //: base(id, tsin, info, localisator)

            return mob;
        }
        //####################################################################################################################################################################
        public List<Mob> ReadAllOfPlanet(int IdPlanet)
        {
            List<int> Idmob = _mobrepo.ReadAllOfPlanet(IdPlanet);
            List<Mob> Mobs = new(); 
            Console.WriteLine("Recuperation du nombre mobs de la planet "+IdPlanet+" : "+Idmob.Count());
            
            
            foreach (var idmob in Idmob)
            {
                Info info;
                Localisator localisator;
                Stat stat;

                Power power;
                Resist resist;

                List<Spell> spellbook = new();
                List<Item> inventory = new();

                //recuperation et reconstruction du mob
                Mob mob;
                mob = _mobrepo.Read(idmob);

                info = _infoRepo.Read(mob.Info.InfoId);
                mob.Info = info;

                localisator = _localisatorRepo.Read(mob.Localisator.LocalisatorId);
                mob.Localisator = localisator;

                stat = _statRepo.Read(mob.Stat.StatId);
                mob.Stat = stat;

                power = _powerRepo.Read(mob.Power.PowerId);
                mob.Power = power;

                resist = _resistRepo.Read(mob.Resist.ResistId);
                mob.Resist = resist;

                Mobs.Add(mob);
            };
            return Mobs;
        }
        //####################################################################################################################################################################
        public int Update(Mob M) {
            return 0;
        }
//####################################################################################################################################################################
        public int Delete(int id) {
            return 0;
        }
//####################################################################################################################################################################

    }
}
