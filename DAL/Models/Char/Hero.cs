﻿using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Hero:Character
    {
        public Stat Stat { get; set; }
        public Power Power { get; set; }
        public Resist Resist { get; set; }
        public List<Item> Inventory { get; set; }
        public List<Spell> SpellBook { get; set; }

        public Hero(int id, long tsin,int coolDown, Info info, Localisator localisator, Stat stat, Power power, Resist resist, List<Item> inventory, List<Spell> spellBook)
            : base(id, tsin, coolDown, info, localisator)
        {
            Stat = stat;
            Power = power;
            Resist = resist;
            Inventory = inventory;
            SpellBook = spellBook;
        }
    }
}