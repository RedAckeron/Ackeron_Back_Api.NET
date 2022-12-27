using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Spell
    {
        public int IdSpell { get; set; }
        public int Name { get; set; }
        public int Description { get; set; }
        public int Eau { get; set; }
        public int Feu { get; set; }
        public int Air { get; set; }
        public int Terre { get; set; }
        public int Lumiere { get; set; }
        public int Tenebre { get; set; }
        public int Tranchant { get; set; }
        public int Ecrasant { get; set; }
        public int Percant { get; set; }
        public int Poison { get; set; }
    }
}
