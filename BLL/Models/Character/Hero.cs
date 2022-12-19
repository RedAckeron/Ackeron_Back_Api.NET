using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Hero:Character
    {
        public int TimestampSimul { get; set; }
        public Localisator Loc { get; set; }
        public Power Power { get; set; }
        public Resist Resist { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Spell> SpellBook { get; set; }
        public List<Quest> QuestBook { get; set; }
    }
}