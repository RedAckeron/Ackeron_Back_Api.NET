using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public abstract class Character
    {
        protected Character(int id, long tsIn,int coolDown, Info info, Localisator localisator)
        {
            Id = id;
            TsIn = tsIn;
            CoolDown = coolDown;
            Info = info;
            Localisator = localisator;
        }

        public int Id { get; set; }
        public long TsIn { get; set; }
        public int CoolDown { get; set; } = 1000;
        public Info Info { get; set; }
        public Localisator Localisator { get; set; }
    }
}