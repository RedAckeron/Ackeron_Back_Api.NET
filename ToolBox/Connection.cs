using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolBox.Mapper;
using ToolBox.Models;

namespace ToolBox
{
    public abstract class Connection : DataToModel
    {
        private readonly string _connectionString;
        public Connection(IConfiguration config)
        {
            _connectionString = config.GetConnectionString("default");
        }

        private SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = _connectionString;
            return connection;
        }

        public virtual IEnumerable<T> ExecuteReader<T> (Command command) where T : new()
        {
            using (SqlConnection cnx = GetConnection())
            {
                using (SqlCommand cmd = CreateCommand(cnx, command))
                {
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        return GetList<T>(reader);
                    }
                }
            }
        }

        public virtual int ExecuteNonQuery(Command command)
        {
            using(SqlConnection cnx = GetConnection())
            {
                using(SqlCommand cmd = CreateCommand(cnx, command))
                {
                    cnx.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public virtual int ExecuteScalar(Command command)
        {
            using (SqlConnection cnx = GetConnection())
            {
                using (SqlCommand cmd = CreateCommand(cnx, command))
                {
                    cnx.Open();

                    return int.Parse(cmd.ExecuteScalar().ToString());
                }
            }
        }

        private SqlCommand CreateCommand(SqlConnection cnx, Command command)
        {
            SqlCommand cmd = cnx.CreateCommand();
            cmd.CommandText = command.Query;

            if (command.IsStoredProcedure)
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
            }
            foreach (KeyValuePair<string, object> param in command.Parameters)
            {
                cmd.Parameters.AddWithValue(param.Key, param.Value);
            }
            return cmd;
        }
    }
}