using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CharacterInfo
    {
        public int IdChar { get; set; }
        public string Name { get; set; }
        public int Race { get; set; }
        public int Sexe { get; set; }
        public int Classe { get; set; }
        public int CitizenPlanet { get; set; }
        public int TsIn { get; set; }

    }
}
