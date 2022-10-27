using System.Data;
using System.Data.SqlClient;

namespace ToolBox
{
    public class ToolDb
    {
        private string _connectionString;

        public void Read()
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    /*
                    cmd.CommandText = "insert into CharacterResist values(@IdChar,@Eau,@Feu,@Air,@Terre,@Lumiere,@Tenebre,@Tranchant,@Ecrasant,@Percant,@Poison);";
                    cmd.Parameters.AddWithValue("IdChar", CRes.IdChar);
                    cmd.Parameters.AddWithValue("Eau", CRes.Eau);
                    cmd.Parameters.AddWithValue("Feu", CRes.Feu);
                    cmd.Parameters.AddWithValue("Air", CRes.Air);
                    cmd.Parameters.AddWithValue("Terre", CRes.Terre);
                    cmd.Parameters.AddWithValue("Lumiere", CRes.Lumiere);
                    cmd.Parameters.AddWithValue("Tenebre", CRes.Tenebre);
                    cmd.Parameters.AddWithValue("Tranchant", CRes.Tranchant);
                    cmd.Parameters.AddWithValue("Ecrasant", CRes.Ecrasant);
                    cmd.Parameters.AddWithValue("Percant", CRes.Percant);
                    cmd.Parameters.AddWithValue("Poison", CRes.Poison);
                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    
                    return ;
                */
                    }
            }








           
        }
        public DataSet SingleRead()
        {
            DataSet ds = new DataSet();

            return ds;
        }
        public DataSet Update()
        {
            DataSet ds = new DataSet();

            return ds;
        }
        public int Delete()
        {

            return 1;
        }
    }
}
