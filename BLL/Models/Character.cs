using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Character
    {
        public int Id { get; set; }
        public Info Info { get; set; }
        public Localisator Loc { get; set; }
        public Stat Stat { get; set; }
        public Power Power { get; set; }
        public Resist Resist { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Spell> SpellBook{ get; set; }
        public List<Quest>QuestBook{ get; set; }
    }
}