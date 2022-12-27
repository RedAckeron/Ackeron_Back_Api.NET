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
        protected Character(int id, long tsIn, Info info, Localisator localisator)
        {
            Id = id;
            TsIn = tsIn;
            Info = info;
            Localisator = localisator;
        }

        public int Id { get; set; }
        public long TsIn { get; set; }
        public Info Info { get; set; }
        public Localisator Localisator { get; set; }
    }
}