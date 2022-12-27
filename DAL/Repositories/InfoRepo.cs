using DAL.Interfaces;
using DAL.Mapper;
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
    public class InfoRepo:IInfoRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public InfoRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }
//####################################################################################################################################################################
        public int Create(Info info)
        {
        using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Info (Name,Race,Sexe,Classe,Gold,CitizenPlanet) output inserted.id values(@Name,@Race,@Sexe,@Classe,@Gold,@CitizenPlanet);";

                    cmd.Parameters.AddWithValue("Name", info.Name);
                    cmd.Parameters.AddWithValue("Race", info.Race);
                    cmd.Parameters.AddWithValue("Sexe", info.Sexe);
                    cmd.Parameters.AddWithValue("Classe", info.Classe);
                    cmd.Parameters.AddWithValue("Gold", info.Gold);
                    cmd.Parameters.AddWithValue("CitizenPlanet", info.CitizenPlanet);
                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        //####################################################################################################################################################################
        public Info Read(int InfoId)
        {
            InfoMapper mapper = new InfoMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM info where id = " + InfoId;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.DataToInfo(reader);
                        }
                    }
                }
            }
            return null;
        }

    }
}
