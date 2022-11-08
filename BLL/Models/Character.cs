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
        public CharacterInfo Info { get; set; }
        public CharacterLoc Loc { get; set; }
        public CharacterStat Stat { get; set; }
        public CharacterPower Power { get; set; }
        public CharacterResist Resist { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Spell> SpellBook{ get; set; }
    }
}