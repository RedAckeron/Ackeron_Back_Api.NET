using DAL.Interfaces;
using DAL.Mapper;
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
using System.Xml.Linq;

namespace DAL.Repositories
{
    public class QuestRepo:IQuestRepo
    {
        private string _connectionString;
        public QuestRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }
        QuestMapper mapper = new QuestMapper();


        public int Create(Quest quest)
        {
            //List<Quest> TabQuest = new List<Quest>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Quest ()output inserted.id values(@name,@description,@validate);";
                    cmd.Parameters.AddWithValue("@name", quest.Name);
                    Console.WriteLine("QUEST NAME : "+quest.Name);
                    cmd.Parameters.AddWithValue("@description", quest.Description);
                    cmd.Parameters.AddWithValue("@validate", quest.Validate);
                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }





        public List<Quest> GetCharacterAllQuest(int IdChar){
            Console.WriteLine("couche repo");
        List<Quest> TabQuest = new List<Quest>();
        using (SqlConnection cnx = new SqlConnection(_connectionString))
        {
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandText = "select * from CharacterQuest where idchar=@IdChar;";
                cmd.Parameters.AddWithValue("@IdChar", IdChar);
                cnx.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                    TabQuest.Add(mapper.DataToQuest(reader));
                    }
                }
                cnx.Close();
            }
        }
        return TabQuest;
        }

    }
}
