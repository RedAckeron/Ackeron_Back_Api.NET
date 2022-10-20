using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class CharacterRepo
    {
        private string _connectionString;

        public CharacterRepo(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");
        }
        public void Create(CharacterInfo charInfo,CharacterLoc charloc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO character (Name, Loc_x, Loc_y) VALUES (@Name, @LocX, @LocY)";
                    cmd.Parameters.AddWithValue("Name", charInfo.Name);
                    cmd.Parameters.AddWithValue("LocX", charloc.LocX);
                    cmd.Parameters.AddWithValue("LocY", charloc.LocY);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }
        }
    }
}
