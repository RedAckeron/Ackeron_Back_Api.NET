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
