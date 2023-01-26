using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Mapper;

namespace DAL.Repositories
{
    public class StatRepo:IStatRepo
    {

        private string _connectionString;
        public StatRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }
//####################################################################################################################################################################
        public int Create(Stat stat)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Stat output inserted.id values(@PtMove,@PtMoveMax,@Strenght,@Defence,@Xp,@Pv,@PvMax,@Pw,@PwMax,@TimestampSimul);";
                    cmd.Parameters.AddWithValue("PtMove", stat.PtMove);
                    cmd.Parameters.AddWithValue("PtMoveMax", stat.PtMoveMax);
                    cmd.Parameters.AddWithValue("Strenght", stat.Strenght);
                    cmd.Parameters.AddWithValue("Defence", stat.Defence);
                    cmd.Parameters.AddWithValue("Xp", stat.Xp);
                    cmd.Parameters.AddWithValue("Pv", stat.Pv);
                    cmd.Parameters.AddWithValue("PvMax", stat.PvMax);
                    cmd.Parameters.AddWithValue("Pw", stat.Pw);
                    cmd.Parameters.AddWithValue("PwMax", stat.PwMax);
                    cmd.Parameters.AddWithValue("TimestampSimul", stat.TimeStampSimul);

                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
//####################################################################################################################################################################
        public Stat Read(int StatId)
        {
            StatMapper mapper = new StatMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM stat where id = " + StatId;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.DataToStat(reader);
                        }
                    }
                }
            }
            return null;
        }
    }
}
