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
    public class LocalisatorRepo:ILocalisatorRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public LocalisatorRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }

        public Localisator ReadLocalisator(int id)
        {
            LocalisatorMapper mapper = new LocalisatorMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Localisator where id = " + id;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.LocMapper(reader);
                        }
                    }
                }
            }
            return null;
        }
        public int UpdateLocalisator(int Id, Localisator Loc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Localisator SET LocUId=@LocU,LocSId=@LocS,LocPId=@LocP,LocAId=@LocA,LocAX=@LocAX,LocAY=@LocAY WHERE Id=@Id;";
                    cmd.Parameters.AddWithValue("Id", Id);
                    cmd.Parameters.AddWithValue("LocU", Loc.LocUId);
                    cmd.Parameters.AddWithValue("LocS", Loc.LocSId);
                    cmd.Parameters.AddWithValue("LocP", Loc.LocPId);
                    cmd.Parameters.AddWithValue("LocA", Loc.LocAId);
                    cmd.Parameters.AddWithValue("LocAX", Loc.LocAX);
                    cmd.Parameters.AddWithValue("LocAY", Loc.LocAY);
                    cnx.Open();
                    return (cmd.ExecuteNonQuery());
                    //cnx.Close();
                }
            }
        }
    }
}
