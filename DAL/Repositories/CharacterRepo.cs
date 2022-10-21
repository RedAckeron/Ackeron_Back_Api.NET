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
        public int AddCharacterLoc(CharacterLoc c)
        {
        using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterLoc @id";
                    cmd.Parameters.AddWithValue("id", c.Id);
                    
                    cnx.Open();
                return cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }

            
        }
        public CharacterStat GetCharacterStat(int id)
        { 
        return null;
        }

        public int AddCharacterLoc(int IdChar, int LocU, int LocS, int LocP, int LocA, int LocA_X, int LocA_Y)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterLoc(IdChar,LocU,LocS,LocP,LocA,LocA_X,LocA_Y)values(@IdChar,@LocU,@LocS,@LocP,@LocU,@LocA_X,@LocA_Y);";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);
                    cmd.Parameters.AddWithValue("LocU", IdChar);
                    cmd.Parameters.AddWithValue("LocS", IdChar);
                    cmd.Parameters.AddWithValue("LocP", IdChar);
                    cmd.Parameters.AddWithValue("LocA", IdChar);
                    cmd.Parameters.AddWithValue("LocA_X", IdChar);
                    cmd.Parameters.AddWithValue("LocA_Y", IdChar);
                    cnx.Open();
                    return cmd.ExecuteNonQuery();
                    cnx.Close();
                }
            }


            
        }







        /*
        public int AddCharacter(string Name, int LocX, int LocY)
        {
            return 0;
        }
        public CharacterLoc GetCharacter(int id)
        {
            return null;
        }
        public IEnumerable<CharacterLoc> GetAllCharacters()
        {
            return null;
        }
        */

    }
}
