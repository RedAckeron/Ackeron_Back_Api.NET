﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.Map
{
    public class Area
    {
        public int IdArea { get; set; }
        public Localisator Localisator { get; set; }
        public string Name { get; set; }
        public int Owner { get; set; }
        public string MainTrigger { get; set; }
        public string SubTrigger { get; set; }
        public string ImgItem { get; set; }
        public bool Reachable { get; set; }
        public int Lvl { get; set; }
        public int Refresh { get; set; }
    }
}