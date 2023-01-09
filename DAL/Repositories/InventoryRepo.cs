using BLL.Models;
using DAL.Interfaces;
using DAL.Mapper;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class InventoryRepo : IInventoryRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;

        public InventoryRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }
        //####################################################################################################################################################################
        public int Add(int IdItem, int IdChar, int Qt)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into HeroItem (IdChar,IdItem,Qt) output inserted.id values(@IdChar,@IdItem,@Qt);";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);
                    cmd.Parameters.AddWithValue("IdItem", IdItem);
                    cmd.Parameters.AddWithValue("Qt", Qt);
                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
        //####################################################################################################################################################################
        public List<Item> Get(int IdChar,IItemRepo _itemRepo)
        {
            List<Item> inventory = new List<Item>();
            ItemMapper mapper = new ItemMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "select * from HeroInventory where IdChar = @IdChar;";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item item =_itemRepo.GetItem((int)reader["IdItem"]);
                            inventory.Add(item);
                        }
                    }
                }
            }
            return inventory;
        }
    }
}

