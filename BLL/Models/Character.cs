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
        public int LocX { get; set; }
        public int LocY { get; set; }
    }
}