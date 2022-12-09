using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class QuestStep
    {
        public int IdStep { get; set; }
        public string NameStep { get; set; }
        public string DescriptionStep { get; set; }
        public bool Validate { get; set; }
        public List<Item>Loot{ get; set; }
    }
}