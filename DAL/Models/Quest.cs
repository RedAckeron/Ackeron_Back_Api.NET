using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Quest
    {
        public int IdQuest;
        public string Name;
        public string Description;
        public bool Validate;
        public List<Step> StepBook { get; set; }
    }
}