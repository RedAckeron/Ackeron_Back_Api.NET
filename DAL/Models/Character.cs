using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class CharacterInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class CharacterLoc
    {
        public int LocX { get; set; }
        public int LocY { get; set; }
    }
}