using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Power
    {
        public Power(int powerId, int eau, int feu, int air, int terre, int lumiere, int tenebre, int tranchant, int ecrasant, int percant, int poison)
        {
            PowerId = powerId;
            Eau = eau;
            Feu = feu;
            Air = air;
            Terre = terre;
            Lumiere = lumiere;
            Tenebre = tenebre;
            Tranchant = tranchant;
            Ecrasant = ecrasant;
            Percant = percant;
            Poison = poison;
        }

        public int PowerId { get; set; }
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
