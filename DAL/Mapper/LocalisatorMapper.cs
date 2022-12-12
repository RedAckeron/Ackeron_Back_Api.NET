using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class LocalisatorMapper
    {
        public Localisator LocMapper(IDataReader reader)
        {
            Localisator Loc = new Localisator();
            Loc.LocUId = (int)reader["LocUId"];
            Loc.LocSId = (int)reader["LocSId"];
            Loc.LocSX = (int)reader["LocSX"];
            Loc.LocSY = (int)reader["LocSY"];
            Loc.LocPId = (int)reader["LocPId"];
            Loc.LocPX = (int)reader["LocPX"];
            Loc.LocPY = (int)reader["LocPY"];
            Loc.LocAId = (int)reader["LocAId"];
            Loc.LocAX = (int)reader["LocAX"];
            Loc.LocAY = (int)reader["LocAY"];
            Loc.LocZId = (int)reader["LocZId"];
            Loc.LocZX = (int)reader["LocZX"];
            Loc.LocZY = (int)reader["LocZY"];
            return Loc;
        }
    }
}