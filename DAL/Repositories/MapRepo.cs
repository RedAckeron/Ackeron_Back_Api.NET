﻿using BLL.Models;
using DAL.Interfaces;
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
            {
                using (SqlConnection cnx = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = cnx.CreateCommand())
                    {
                        /*
                        cmd.CommandText = "insert into Item values(@Name,@Description,@Type,@SubType,@Quality,@Price,@Img,@Color,@LvlItem,@QtProduction,@TimeProduction,@TimeDelete,@MainTrigger,@SubTrigger);";
                        cmd.Parameters.AddWithValue("Name", I.Name);
                        cmd.Parameters.AddWithValue("Description", I.Description);
                        cmd.Parameters.AddWithValue("Type", I.Type);
                        cmd.Parameters.AddWithValue("SubType", I.SubType);
                        cmd.Parameters.AddWithValue("Quality", I.Quality);
                        cmd.Parameters.AddWithValue("Price", I.Price);
                        cmd.Parameters.AddWithValue("Img", I.Img);
                        cmd.Parameters.AddWithValue("Color", I.Color);
                        cmd.Parameters.AddWithValue("LvlItem", I.LvlItem);
                        cmd.Parameters.AddWithValue("QtProduction", I.QtProduction);
                        cmd.Parameters.AddWithValue("TimeProduction", I.TimeProduction);
                        cmd.Parameters.AddWithValue("TimeDelete", I.TimeDelete);
                        cmd.Parameters.AddWithValue("MainTrigger", I.MainTrigger);
                        cmd.Parameters.AddWithValue("SubTrigger", I.SubTrigger);

                        cnx.Open();
                        cmd.ExecuteNonQuery();
                        cnx.Close();
                        */
                        return true;
                        
                    }
                }
            }




            //public bool ChkTargetWalking(CharacterLoc CLoc) {
            //    return true;
            //}

        }
    }
}