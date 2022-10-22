using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
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

        public int AddCharacterLoc(CharacterLoc CLoc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterLoc(IdChar,LocU,LocS,LocP,LocA,LocA_X,LocA_Y)values(@IdChar,@LocU,@LocS,@LocP,@LocU,@LocA_X,@LocA_Y);";
                    cmd.Parameters.AddWithValue("IdChar", CLoc.Id);
                    cmd.Parameters.AddWithValue("LocU", CLoc.LocU);
                    cmd.Parameters.AddWithValue("LocS", CLoc.LocS);
                    cmd.Parameters.AddWithValue("LocP", CLoc.LocP);
                    cmd.Parameters.AddWithValue("LocA", CLoc.LocA);
                    cmd.Parameters.AddWithValue("LocA_X", CLoc.LocA_X);
                    cmd.Parameters.AddWithValue("LocA_Y", CLoc.LocA_Y);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    return 1;
                }
            }
        }
        public int AddCharacterStat(int IdChar, string Name)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterStat(IdChar,Name)values(@IdChar,@Name);";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);
                    cmd.Parameters.AddWithValue("Name", Name);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    return 1;
                }
            }
        }
    }
}
