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
    public class HeroRepo:IHeroRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public HeroRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
        }
        //####################################################################################################################################################################
        public int Create(Hero h)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into Hero  (TsIn,LocalisatorId,InfoId,StatId,PowerId,ResistId) output inserted.id values(@TsIn,@LocalisatorId,@InfoId,@StatId,@PowerId,@ResistId);";

                    cmd.Parameters.AddWithValue("TsIn", h.TsIn);
                    cmd.Parameters.AddWithValue("CoolDown", h.CoolDown);
                    cmd.Parameters.AddWithValue("LocalisatorId", h.Localisator.LocalisatorId);
                    cmd.Parameters.AddWithValue("InfoId", h.Info.InfoId);
                    cmd.Parameters.AddWithValue("StatId", h.Stat.StatId);
                    cmd.Parameters.AddWithValue("PowerId", h.Power.PowerId);
                    cmd.Parameters.AddWithValue("ResistId", h.Resist.ResistId);
                    cnx.Open();
                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}
