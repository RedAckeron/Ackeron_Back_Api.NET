using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CharacterLoc
    {
        public int Id { get; set; }
        public int IdChar { get; set; }
        public int LocU { get; set; }
        public int LocS { get; set; }
        public int LocP { get; set; }
        public int LocA { get; set; }
        public int LocA_X { get; set; }
        public int LocA_Y { get; set; }
    }
}