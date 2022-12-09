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
            //CLoc.IdChar = (int)reader[1];
            Loc.LocUId = (int)reader["LocUId"];
            Loc.LocSId = (int)reader["LocSId"];
            Loc.LocPId = (int)reader["LocPId"];
            Loc.LocAId = (int)reader["LocAId"];
            Loc.LocAX = (int)reader["LocAX"];
            Loc.LocAY = (int)reader["LocAY"];
            Loc.LocZId = (int)reader["LocZId"];
            //Console.WriteLine("IdChar:" + CLoc.IdChar + " => " + CLoc.LocAX + "/" + CLoc.LocAY);
            return Loc;
        }
    }
}