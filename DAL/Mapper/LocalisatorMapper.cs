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
            Localisator Loc = new Localisator(
                (int)reader["Id"],
                (int)reader["LocUId"],
                (int)reader["LocSId"],
                (int)reader["LocSX"],
                (int)reader["LocSY"],
                (int)reader["LocPId"],
                (int)reader["LocPX"],
                (int)reader["LocPY"],
                (int)reader["LocAId"],
                (int)reader["LocAX"],
                (int)reader["LocAY"],
                (int)reader["LocZId"],
                (int)reader["LocZX"],
                (int)reader["LocZY"]
                );
          
            return Loc;
        }
    }
}