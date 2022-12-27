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
            Localisator loc=new Localisator(0,0,0,0,0,0,0,0,0,0,0,0,0,0);
            loc.LocAId= (int)reader["Id"];
            loc.LocAX = (int)reader["LocAX"];
            loc.LocAY = (int)reader["LocAY"];
            loc.LocPId = (int)reader["LocPId"];

            Area area = new Area();
            area.IdArea = (int)reader["Id"];
            area.Localisator = loc;
            area.Name = (string)reader["Name"];
            area.Owner = (int)reader["Owner"];
            area.MainTrigger = (string)reader["MainTrigger"];
            area.SubTrigger = (string)reader["SubTrigger"];
            area.ImgItem = (string)reader["ImgItem"];
            area.Reachable = (bool)reader["Reachable"];
            area.Lvl = (int)reader["Lvl"];
            area.Refresh = (int)reader["Refresh"];
            return area;
        }
    }
}