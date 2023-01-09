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
        public LocalisatorRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }
//####################################################################################################################################################################
        public int Create(Localisator loc)
        {
        using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Localisator  (LocUId,LocSId,LocSX,LocSY,LocPId,LocPX,LocPY,LocAId,LocAX,LocAY,LocZId,LocZX,LocZY) output inserted.id values(@LocUId,@LocSId,@LocSX,@LocSY,@LocPId,@LocPX,@LocPY,@LocAId,@LocAX,@LocAY,@LocZId,@LocZX,@LocZY);";
                    
                    cmd.Parameters.AddWithValue("LocUId", loc.LocUId);

                    cmd.Parameters.AddWithValue("LocSId", loc.LocSId);
                    cmd.Parameters.AddWithValue("LocSX", loc.LocSX);
                    cmd.Parameters.AddWithValue("LocSY", loc.LocSY);

                    cmd.Parameters.AddWithValue("LocPId", loc.LocPId);
                    cmd.Parameters.AddWithValue("LocPX", loc.LocPX);
                    cmd.Parameters.AddWithValue("LocPY", loc.LocPY);

                    cmd.Parameters.AddWithValue("LocAId", loc.LocAId);
                    cmd.Parameters.AddWithValue("LocAX", loc.LocAX);
                    cmd.Parameters.AddWithValue("LocAY", loc.LocAY);

                    cmd.Parameters.AddWithValue("LocZId", loc.LocZId);
                    cmd.Parameters.AddWithValue("LocZX", loc.LocZX);
                    cmd.Parameters.AddWithValue("LocZY", loc.LocZY);
                    
                    cnx.Open();
                    
                    return (int)cmd.ExecuteScalar();

                    //cnx.Close();
                }
            }
        }
//####################################################################################################################################################################
        public Localisator Read(int id)
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
//####################################################################################################################################################################
        public bool Update(Localisator Loc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    Console.WriteLine("Mise a jours du localisator "+ Loc.LocalisatorId+" a la loc P" + Loc.LocPId+ " : X"+Loc.LocAX+" / Y"+Loc.LocAY);
                    cmd.CommandText = "UPDATE Localisator SET LocUId=@LocUId,LocSId=@LocSId,LocSX=@LocSX,LocSY=@LocSY,LocPId=@LocPId,LocPX=@LocPX,LocPY=@LocPY,LocAId=@LocAId,LocAX=@LocAX,LocAY=@LocAY,LocZId=@LocZId,LocZX=@LocZX,LocZY=@LocZY WHERE Id=@LocalisatorID;";
                    cmd.Parameters.AddWithValue("LocalisatorID", Loc.LocalisatorId);
                    cmd.Parameters.AddWithValue("LocUId", Loc.LocUId);

                    cmd.Parameters.AddWithValue("LocSId", Loc.LocSId);
                    cmd.Parameters.AddWithValue("LocSX", Loc.LocSX);
                    cmd.Parameters.AddWithValue("LocSY", Loc.LocSY);

                    cmd.Parameters.AddWithValue("LocPId", Loc.LocPId);
                    cmd.Parameters.AddWithValue("LocPX", Loc.LocPX);
                    cmd.Parameters.AddWithValue("LocPY", Loc.LocPY);

                    cmd.Parameters.AddWithValue("LocAId", Loc.LocAId);
                    cmd.Parameters.AddWithValue("LocAX", Loc.LocAX);
                    cmd.Parameters.AddWithValue("LocAY", Loc.LocAY);

                    cmd.Parameters.AddWithValue("LocZId", Loc.LocZId);
                    cmd.Parameters.AddWithValue("LocZX", Loc.LocZX);
                    cmd.Parameters.AddWithValue("LocZY", Loc.LocZY);
                    cnx.Open();
                    return (cmd.ExecuteNonQuery()==1);
                    
                }
            }
        }


      
                  

                  





        //####################################################################################################################################################################
        public bool Delete(int IdLoc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Localisator WHERE Id=@Id;";
                    cmd.Parameters.AddWithValue("Id", IdLoc);
                   
                    cnx.Open();
                    return (cmd.ExecuteNonQuery()==1);
                    //cnx.Close();
                }
            }
        }
    }
}
