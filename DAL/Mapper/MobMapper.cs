using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class MobMapper
    {
        public Mob DataToMob(IDataReader reader)
        {
            Power power = new Power((int)reader["PowerId"], 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Resist resist = new Resist((int)reader["ResistId"], 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            Stat stat = new Stat((int)reader["StatId"], 0, 0, 0, 0, 0, 0, 0, 0);
            Info info = new Info((int)reader["InfoId"], "",0,0,0,0,0,"","nord");
            Localisator localisator = new Localisator((int)reader["LocalisatorId"], 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            List<Spell> spellbook = new List<Spell>();
            List<Item> inventory = new List<Item>();

            Mob mob = new Mob(
                (int)reader["Id"],
                (int)reader["TsIn"],
                (int)reader["CoolDown"],
                info,
                localisator,
                (int)reader["MobGabaritId"],
                stat,
                power,
                resist,
                inventory,
                spellbook
                );
            
            return mob;
        }
    }
}
