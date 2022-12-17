using DAL.Models;
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
        public string Name { get; set; }
        public int Race { get; set; }
        public int Sexe { get; set; }
        public int Classe { get; set; }
        public int CitizenPlanet { get; set; }
        public int Gold { get; set; }
        public int TsIn { get; set; }
    }
}