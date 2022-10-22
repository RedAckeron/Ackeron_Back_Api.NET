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
        public string Name{ get; set; }
        public int Pv { get; set; }
        public int PvMax { get; set; }
        public int Pe { get; set; }
        public int PeMax { get; set; }
        public int Loc_U { get; set; }
        public int Loc_S { get; set; }
        public int Loc_P { get; set; }
        public int Loc_A { get; set; }
        public int LocA_X { get; set; }
        public int LocA_Y { get; set; }
    }

}