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
        public Loc Loc { get; set; }
        public Stat Stat { get; set; }
        public Power Power { get; set; }
        public Resist Resist { get; set; }
    }
    public class Info
    {
        public string Name { get; set; }
        public int Race { get; set; }
        public int Sexe { get; set; }
        public int Classe { get; set; }
        public int CitizenPlanet { get; set; }
        public int TsIn { get; set; }
    }
    public class Loc
    {
        public int U { get; set; }
        public int S { get; set; }
        public int P { get; set; }
        public int A { get; set; }
        public int A_X { get; set; }
        public int A_Y { get; set; }
    }

    public class Stat
    {
        public int TimestampSimul { get; set; }
        public int PtMove { get; set; }
        public int PtMoveMax { get; set; }
        public int Gold { get; set; }
        public int xp { get; set; }
        public int Pv { get; set; }
        public int PvMax { get; set; }
        public int Pw { get; set; }
        public int PwMax { get; set; }
    }
    public class Resist
    {
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
    public class Power
    {
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