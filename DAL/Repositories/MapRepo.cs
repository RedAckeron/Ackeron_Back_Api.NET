using BLL.Models;
using DAL.Interfaces;
using DAL.Mapper.Map;
using DAL.Models;
using DAL.Models.Map;
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
    public class MapRepo : IMapRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public MapRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }


        public int CheckExist(Localisator loc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select Id from ViewAreaLoc where LocPId=@LocPId and LocAX=@LocAX and LocAY=@LocAY;";
                    cmd.Parameters.AddWithValue("LocPId", loc.LocPId);
                    cmd.Parameters.AddWithValue("LocAX", loc.LocAX);
                    cmd.Parameters.AddWithValue("LocAY", loc.LocAY);

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("ID "+reader["Id"]);
                        }
                    }
                    cnx.Close();
                }
            }
            return 0;
        }

        public Area Read(int IdArea)
        {
            Area area = new Area();
            AreaMapper mapper = new AreaMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select * from ViewAreaLoc where Id=@LocA;";
                    cmd.Parameters.AddWithValue("LocA", IdArea);

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            area=(mapper.DataToArea(reader));
                        }
                    }
                    cnx.Close();
                }
            }
            return area;
        }
        public bool ChkAreaReachable(Localisator Loc)
        {
        using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
            using (SqlCommand cmd = cnx.CreateCommand())
                {
                cmd.CommandText = "select count(*) from ViewAreaLoc where LocPId=@LocPId and LocAX=@LocAX and LocAY=@LocAY and Reachable=0;";
                cmd.Parameters.AddWithValue("LocPId", Loc.LocPId);
                cmd.Parameters.AddWithValue("LocAX", Loc.LocAX);
                cmd.Parameters.AddWithValue("LocAY", Loc.LocAY);
                cnx.Open();
                
                Int32 count = (Int32)cmd.ExecuteScalar();
                Console.WriteLine("Result count : "+count);
                    return count == 0;
                }
            }
        }

        public List<Area> GetMap(int IdPlanet)
        {
            List<Area> TabArea = new List<Area>();
            AreaMapper mapper = new AreaMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select * from ViewAreaLoc where LocPId=@LocP;";
                    cmd.Parameters.AddWithValue("LocP", IdPlanet);
                    
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TabArea.Add(mapper.DataToArea(reader)); 
                        }
                    }
                    cnx.Close();
                }
            }
            return TabArea;
        }

    }
}