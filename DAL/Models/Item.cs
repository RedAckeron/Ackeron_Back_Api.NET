using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models
{
    public class Item
    {
        public int IdItem { get; set; }
		public string Name { get; set; }
        public string Description { get; set; }
		public int Qt { get; set; }
		public string Type { get; set; }
        public string SubType { get; set; }
		public int Quality { get; set; }
		public int Price { get; set; }
		public string Img { get; set; }
		public string Color{ get; set; }
		public int LvlItem { get; set; }
		public int QtProduction { get; set; }
		public int TimeProduction { get; set; }
		public int TimeDelete { get; set; }
		public string MainTrigger { get; set; }
		public string SubTrigger { get; set; }
	}
}