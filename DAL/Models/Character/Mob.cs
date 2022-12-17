using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Mob:Character
    {
        public int PtMove { get; set; }
        public int PtMoveMax { get; set; }
        public int Xp { get; set; }
        public int Gold { get; set; }
        public int Pv{ get; set; }
        public int PvMax { get; set; }
        public int Pw{ get; set; }
        public int PwMax{ get; set; }

        public Localisator Loc { get; set; }
        public Power Power { get; set; }
        public Resist Resist { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Spell> SpellBook { get; set; }

    }
}