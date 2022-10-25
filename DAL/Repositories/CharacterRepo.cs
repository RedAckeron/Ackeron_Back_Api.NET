using DAL.Interfaces;
using DAL.Models;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace DAL.Repositories

{
    public class CharacterRepo:ICharacterRepo
    {
        private string _connectionString;
        private readonly IDbConnection _connection;

        public CharacterRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }

        public int AddCharacterInfo(CharacterInfo CInfo)
        {
        using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
            using (SqlCommand cmd = cnx.CreateCommand())
            {
                cmd.CommandText = "Insert into [dbo].[Character] (Name,Race,Sexe,Classe,CitizenPlanet,TsIn)output inserted.Id values(@Name,@Race,@Sexe,@Classe,@CitizenPlanet,@TsIn);";
                cmd.Parameters.AddWithValue("Name", CInfo.Name);
                cmd.Parameters.AddWithValue("Race", CInfo.Race);
                cmd.Parameters.AddWithValue("Sexe", CInfo.Sexe);
                cmd.Parameters.AddWithValue("Classe", CInfo.Classe);
                cmd.Parameters.AddWithValue("CitizenPlanet", CInfo.CitizenPlanet);
                cmd.Parameters.AddWithValue("TsIn", CInfo.TsIn);
                cnx.Open();
                return (int)(cmd.ExecuteScalar());
                cnx.Close(); 
            }
        }
    }
        public int AddCharacterLoc(CharacterLoc CLoc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterLoc(IdChar,LocU,LocS,LocP,LocA,LocA_X,LocA_Y)values(@IdChar,@LocU,@LocS,@LocP,@LocU,@LocA_X,@LocA_Y);";
                    cmd.Parameters.AddWithValue("IdChar", CLoc.IdChar);
                    cmd.Parameters.AddWithValue("LocU", CLoc.LocU);
                    cmd.Parameters.AddWithValue("LocS", CLoc.LocS);
                    cmd.Parameters.AddWithValue("LocP", CLoc.LocP);
                    cmd.Parameters.AddWithValue("LocA", CLoc.LocA);
                    cmd.Parameters.AddWithValue("LocA_X", CLoc.LocA_X);
                    cmd.Parameters.AddWithValue("LocA_Y", CLoc.LocA_Y);
                    cnx.Open();
                    return (cmd.ExecuteNonQuery());
                    cnx.Close();
                }
            }
        }
        public int AddCharacterStat(CharacterStat CStat)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterStat values(@IdChar,@TimestampSimul,@PtMove,@PtMoveMax,@Xp,@Gold,@Pv,@PvMax,@Pw,@PwMax);";
                    cmd.Parameters.AddWithValue("IdChar", CStat.IdChar);
                    cmd.Parameters.AddWithValue("TimestampSimul", CStat.TimestampSimul);
                    cmd.Parameters.AddWithValue("PtMove", CStat.PtMove);
                    cmd.Parameters.AddWithValue("PtMoveMax", CStat.PtMoveMax);
                    cmd.Parameters.AddWithValue("Xp", CStat.Xp);
                    cmd.Parameters.AddWithValue("Gold", CStat.Gold);
                    cmd.Parameters.AddWithValue("Pv", CStat.Pv);
                    cmd.Parameters.AddWithValue("PvMax", CStat.PvMax);
                    cmd.Parameters.AddWithValue("Pw", CStat.Pw);
                    cmd.Parameters.AddWithValue("PwMax", CStat.PwMax);

                    cnx.Open();
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    return 1;
                }
            }
        }
        public int AddCharacterPower(CharacterPower CPow)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                cmd.CommandText = "insert into CharacterPower values(@IdChar,@Eau,@Feu,@Air,@Terre,@Lumiere,@Tenebre,@Tranchant,@Ecrasant,@Percant,@Poison);";
                cmd.Parameters.AddWithValue("IdChar", CPow.IdChar);
                cmd.Parameters.AddWithValue("Eau", CPow.Eau);
                cmd.Parameters.AddWithValue("Feu", CPow.Feu);
                cmd.Parameters.AddWithValue("Air", CPow.Air);
                cmd.Parameters.AddWithValue("Terre", CPow.Terre);
                cmd.Parameters.AddWithValue("Lumiere", CPow.Lumiere);
                cmd.Parameters.AddWithValue("Tenebre", CPow.Tenebre);
                cmd.Parameters.AddWithValue("Tranchant", CPow.Tranchant);
                cmd.Parameters.AddWithValue("Ecrasant", CPow.Ecrasant);
                cmd.Parameters.AddWithValue("Percant", CPow.Percant);
                cmd.Parameters.AddWithValue("Poison", CPow.Poison);
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                return 1;
                }
            }
        }
        public int AddCharacterResist(CharacterResist CRes)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
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
                    return 1;
                }
            }
        }
    }
}