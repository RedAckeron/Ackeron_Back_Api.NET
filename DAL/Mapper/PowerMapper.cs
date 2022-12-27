using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper.Map
{
    public class PowerMapper
    {
        public Power DataToPower(IDataReader reader)
        {
            Power Pow = new Power(
                (int)reader["id"],
                (int)reader["eau"],
                (int)reader["feu"],
                (int)reader["air"],
                (int)reader["terre"],
                (int)reader["lumiere"],
                (int)reader["tenebre"],
                (int)reader["tranchant"],
                (int)reader["ecrasant"],
                (int)reader["percant"],
                (int)reader["poison"]
                );
            return Pow;
        }
    }
}
