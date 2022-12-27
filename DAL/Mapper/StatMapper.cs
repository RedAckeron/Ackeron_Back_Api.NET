using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class StatMapper
    {
        public Stat DataToStat(IDataReader reader)
        {
            
            Stat stat = new Stat(
                (int)reader["id"], 
                (int)reader["PtMove"], 
                (int)reader["PtMoveMax"], 
                (int)reader["Xp"], 
                (int)reader["Pv"], 
                (int)reader["PvMax"], 
                (int)reader["Pw"], 
                (int)reader["PwMax"],
                (int)reader["Timestampsimul"]
                );
            
            return stat;
        }      
    }
}