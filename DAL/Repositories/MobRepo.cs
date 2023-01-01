using DAL.Models;
using DAL.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Mapper;

namespace DAL.Repositories
{
    public class MobRepo:IMobrepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public MobRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }
//####################################################################################################################################################################
        public int Create(Mob M)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Mob  (MobGabaritId,TsIn,LocalisatorId,InfoId,StatId,PowerId,ResistId) output inserted.id values(@MobGabaritId,@TsIn,@LocalisatorId,@InfoId,@StatId,@PowerId,@ResistId);";

                    cmd.Parameters.AddWithValue("MobGabaritId", M.MobGabaritId);
                    cmd.Parameters.AddWithValue("TsIn", M.TsIn);
                    cmd.Parameters.AddWithValue("LocalisatorId", M.Localisator.LocalisatorId);
                    cmd.Parameters.AddWithValue("InfoId", M.Info.InfoId);
                    cmd.Parameters.AddWithValue("StatId", M.Stat.StatId);
                    cmd.Parameters.AddWithValue("PowerId", M.Power.PowerId);
                    cmd.Parameters.AddWithValue("ResistId", M.Resist.ResistId);
                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                    //cnx.Close();
                }
            }
        }
//####################################################################################################################################################################
        public Mob Read(int IdMob)
        {
            MobMapper mapper = new MobMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM mob where id = " + IdMob;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.DataToMob(reader);
                        }
                    }
                }
            }
            return null;
        }

//####################################################################################################################################################################
        public List<int> ReadAllOfPlanet(int IdPlanet)
        {
            List<int> IdMob = new List<int>();   
            //MobMapper mapper = new MobMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id FROM MobPlanet where LocPId = " + IdPlanet;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            IdMob.Add(reader.GetInt32(0));
                            
                        }
                    }
                }
            }
            return IdMob;
        }



        //####################################################################################################################################################################
        public int Update(Mob M)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    /*
                    cmd.CommandText = "UPDATE [dbo].[Character] SET Name=@Name,Race=@Race,Sexe=@Sexe,Classe=@Classe,CitizenPlanet=@CitizenPlanet,TsIn=@TsIn WHERE Id = @IdChar;";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);
                    cmd.Parameters.AddWithValue("Name", C.Name);
                    cmd.Parameters.AddWithValue("Race", C.Race);
                    cmd.Parameters.AddWithValue("Sexe", C.Sexe);
                    cmd.Parameters.AddWithValue("Classe", C.Classe);
                    cmd.Parameters.AddWithValue("CitizenPlanet", C.CitizenPlanet);
                    cmd.Parameters.AddWithValue("TsIn", C.TsIn);
                    cnx.Open();
                    return (cmd.ExecuteNonQuery());
                    //cnx.Close();
                    */
                    return 0;
                }
            }
        }
//####################################################################################################################################################################


    }
}
