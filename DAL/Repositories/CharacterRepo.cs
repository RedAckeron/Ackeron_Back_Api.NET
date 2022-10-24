using DAL.Interfaces;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL.Repositories

{
    public class CharacterRepo:ICharacterRepo
    {
        private string _connectionString;
        private readonly IDbConnection _connection;

        public CharacterRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }
        public int AddCharacter(CharacterStat CStat)
        {
            
            /*
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterStat(IdChar,Name)values(@IdChar,@Name);";
                    cmd.Parameters.AddWithValue("IdChar", CStat.Id);
                    cmd.Parameters.AddWithValue("Name", CStat.Name);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    return 1;
                }
            }
            */
            return 0;
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
        public int AddCharacterStat(CharacterStat CStat)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterStat(IdChar,Name)values(@IdChar,@Name);";
                    cmd.Parameters.AddWithValue("IdChar", CStat.Id);
                    cmd.Parameters.AddWithValue("Name", CStat.Name);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    return 1;
                }
            }
        }
    }
}