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
using DAL.Mapper.Map;
using DAL.Mapper;

namespace DAL.Repositories
{
    public class ResistRepo:IResistRepo
    {

        private string _connectionString;
        public ResistRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }
//####################################################################################################################################################################
        public int Create(Resist Res)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Resist output inserted.id values(@Eau,@Feu,@Air,@Terre,@Lumiere,@Tenebre,@Tranchant,@Ecrasant,@Percant,@Poison);";
                    cmd.Parameters.AddWithValue("Eau", Res.Eau);
                    cmd.Parameters.AddWithValue("Feu", Res.Feu);
                    cmd.Parameters.AddWithValue("Air", Res.Air);
                    cmd.Parameters.AddWithValue("Terre", Res.Terre);
                    cmd.Parameters.AddWithValue("Lumiere", Res.Lumiere);
                    cmd.Parameters.AddWithValue("Tenebre", Res.Tenebre);
                    cmd.Parameters.AddWithValue("Tranchant", Res.Tranchant);
                    cmd.Parameters.AddWithValue("Ecrasant", Res.Ecrasant);
                    cmd.Parameters.AddWithValue("Percant", Res.Percant);
                    cmd.Parameters.AddWithValue("Poison", Res.Poison);
                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                    ;
                }
            }
        }
//####################################################################################################################################################################
        public Resist Read(int ResistId)
        {
            ResistMapper mapper = new ResistMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM resist where id = " + ResistId;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.DataToResist(reader);
                        }
                    }
                }
            }
            return null;
        }
    }
}
