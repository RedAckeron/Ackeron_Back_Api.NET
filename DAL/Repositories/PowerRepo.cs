using DAL.Interfaces;
using DAL.Mapper;
using DAL.Mapper.Map;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PowerRepo:IPowerRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public PowerRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
          
        }
//####################################################################################################################################################################
        public int Create(Power Pow)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Power output inserted.id values(@Eau,@Feu,@Air,@Terre,@Lumiere,@Tenebre,@Tranchant,@Ecrasant,@Percant,@Poison);";
                    cmd.Parameters.AddWithValue("Eau", Pow.Eau);
                    cmd.Parameters.AddWithValue("Feu", Pow.Feu);
                    cmd.Parameters.AddWithValue("Air", Pow.Air);
                    cmd.Parameters.AddWithValue("Terre", Pow.Terre);
                    cmd.Parameters.AddWithValue("Lumiere", Pow.Lumiere);
                    cmd.Parameters.AddWithValue("Tenebre", Pow.Tenebre);
                    cmd.Parameters.AddWithValue("Tranchant", Pow.Tranchant);
                    cmd.Parameters.AddWithValue("Ecrasant", Pow.Ecrasant);
                    cmd.Parameters.AddWithValue("Percant", Pow.Percant);
                    cmd.Parameters.AddWithValue("Poison", Pow.Poison);
                    cnx.Open();
                    //cmd.ExecuteNonQuery();
                    //cnx.Close();
                    return (int)cmd.ExecuteScalar();
                    ;
                }
            }
        }
//####################################################################################################################################################################
        public Power Read(int PowerId)
        {
            PowerMapper mapper = new PowerMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM power where id = " + PowerId;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.DataToPower(reader);
                        }
                    }
                }
            }
            return null;
        }
    }
}
