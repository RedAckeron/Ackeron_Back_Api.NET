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

        public bool ChkTargetWalking(CharacterLoc CLoc)
        {
        using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
            using (SqlCommand cmd = cnx.CreateCommand())
                {
                cmd.CommandText = "select count(*) from MapLocArea where LocU=@LocU and LocS=@LocS and LocP=@LocP and LocX=@LocX and LocY=@LocY and reachable=@Reachable;";
                cmd.Parameters.AddWithValue("LocU", CLoc.LocU);
                cmd.Parameters.AddWithValue("LocS", CLoc.LocS);
                cmd.Parameters.AddWithValue("LocP", CLoc.LocP);
                cmd.Parameters.AddWithValue("LocX", CLoc.LocA_X);
                cmd.Parameters.AddWithValue("LocY", CLoc.LocA_Y);
                cmd.Parameters.AddWithValue("Reachable", 0);
                cnx.Open();
                Int32 count = (Int32)cmd.ExecuteScalar();
                if (count == 0)return true;
                else return false;  
                //cnx.Close(); 
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
                    cmd.CommandText = "select * from MapLocArea where LocP=@LocP;";
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