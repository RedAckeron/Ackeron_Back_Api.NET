using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Quest
    {
        public int IdQuest { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Validate { get; set; }
        //public List<QuestStep> StepBook { get; set; }
    }
}