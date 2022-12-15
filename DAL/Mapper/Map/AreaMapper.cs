using DAL.Models;
using DAL.Models.Map;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper.Map
{
    public class AreaMapper {
        public Area DataToArea(IDataReader reader)
        {
            Localisator loc=new Localisator();
            Area area = new Area();
            area.IdArea = (int)reader[0];
            area.Name = (string)reader[1];
            area.Localisator.LocAX = (int)reader[6];
            area.Localisator.LocAY = (int)reader[7];
            area.MainTrigger = (string)reader[8];
            area.SubTrigger = (string)reader[9];
            area.ImgItem = (string)reader[10];
            area.Reachable = (bool)reader[11];
            return area;
        }
    }
}