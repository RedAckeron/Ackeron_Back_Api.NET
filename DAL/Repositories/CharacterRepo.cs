﻿using BLL.Models;
using DAL.Interfaces;
using DAL.Mapper;
using DAL.Mapper.Map;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace BLL.Repositories
{
    public class CharacterRepo:ICharacterRepo
    {
        private string _connectionString;
        //private readonly IDbConnection _connection;
        public CharacterRepo(IConfiguration config, IDbConnection connection)
        {
            _connectionString = config.GetConnectionString("default");
            //_connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Ackeron;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //_connection = connection;
        }
        /*
        public int AddCharacterInfo(Info CInfo)
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
                    //cnx.Close(); 
                }
            }
        }
        */
        public int AddCharacterLoc(int IdChar,Localisator CLoc)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterLoc(IdChar,LocU,LocS,LocP,LocA,LocA_X,LocA_Y)values(@IdChar,@LocU,@LocS,@LocP,@LocU,@LocA_X,@LocA_Y);";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);
                    cmd.Parameters.AddWithValue("LocU", CLoc.LocUId);
                    cmd.Parameters.AddWithValue("LocS", CLoc.LocSId);
                    cmd.Parameters.AddWithValue("LocP", CLoc.LocPId);
                    cmd.Parameters.AddWithValue("LocA", CLoc.LocAId);
                    cmd.Parameters.AddWithValue("LocA_X", CLoc.LocAX);
                    cmd.Parameters.AddWithValue("LocA_Y", CLoc.LocAY);
                    cnx.Open();
                    return (cmd.ExecuteNonQuery());
                    //cnx.Close();
                }
            }
        }
        public int AddCharacterStat(Stat CStat)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "insert into CharacterStat values(@IdChar,@TimestampSimul,@PtMove,@PtMoveMax,@Xp,@Gold,@Pv,@PvMax,@Pw,@PwMax);";
                    cmd.Parameters.AddWithValue("PtMove", CStat.PtMove);
                    cmd.Parameters.AddWithValue("PtMoveMax", CStat.PtMoveMax);
                    cmd.Parameters.AddWithValue("Xp", CStat.Xp);
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
        public int AddCharacterPower(Power CPow)
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
        public int AddCharacterResist(Resist CRes)
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
        /*
        public Info GetCharacterInfo(int id)
        {
            //StatMapper mapper = new StatMapper();
            InfoMapper mapper = new InfoMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM Character where id = "+id;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.CharacterInfoMapper(reader);
                        }
                    }
                }
            }
            return null;
        }
        */
        public Stat GetCharacterStat(int id)
        {
            StatMapper mapper = new StatMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CharacterStat where idChar = " + id;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.CharacterStatMapper(reader);
                        }
                    }
                }
            }
            return null;
        }

        public Power GetCharacterPower(int id)
        {
            //StatMapper mapper = new StatMapper();
            PowerMapper mapper = new PowerMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CharacterPower where idChar = " + id;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.CharacterPowerMapper(reader);
                        }
                    }
                }
            }
            return null;
        }
        public Resist GetCharacterResist(int id)
        {
            //StatMapper mapper = new StatMapper();
            ResistMapper mapper = new ResistMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CharacterResist where idChar = " + id;
                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return mapper.CharacterResistMapper(reader);
                        }

                    }
                }
            }
            return null;
        }
        public List<Item> GetCharacterInventory(int id)
        {
            List <Item> Inventory = new List<Item>();
            // CharacterMapper mapper = new CharacterMapper();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CharacterItem where idChar = @IdChar";
                    cmd.Parameters.AddWithValue("IdChar", id);

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Item item = new Item();
                            item.IdItem = (int)reader["IdItem"];
                            //item.Qt = (int)reader["Qt"];

                            Inventory.Add(item);
                        }
                        return Inventory;
                    }
                }
            }
        }
        public List<Spell> GetCharacterSpell(int id)
        {
            List<Spell> Spellbook = new List<Spell>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM CharacterSpell where idChar = @IdChar";
                    cmd.Parameters.AddWithValue("IdChar", id);

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Spell spell = new Spell();
                            spell.IdSpell = (int)reader["IdSpell"];
                            Spellbook.Add(spell);
                        }
                        return Spellbook;
                    }
                }
            }
        }
        public List<Quest> GetCharacterQuest(int id)
        {
            List<Quest> Questbook = new List<Quest>();
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    //cmd.CommandText = "SELECT * FROM CharacterQuest where idChar = @IdChar";
                    cmd.CommandText = "SELECT * FROM CharacterQuest as CQ INNER JOIN Quest as Q ON CQ.IdQuest = Q.id where CQ.IdChar = @IdChar;";
                    cmd.Parameters.AddWithValue("IdChar", id);

                    cnx.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Quest quest = new Quest();
                            
                            quest.IdQuest = (int)reader["IdQuest"];
                            quest.Name = (string)reader["Name"];
                            quest.Validate = (bool)reader["Validate"];
                            Questbook.Add(quest);
                        }
                        return Questbook;
                    }
                }
            }
        }
        
        public int UpdateCharacter(int IdChar,Character C)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "UPDATE [dbo].[Character] SET Name=@Name,Race=@Race,Sexe=@Sexe,Classe=@Classe,CitizenPlanet=@CitizenPlanet,TsIn=@TsIn WHERE Id = @IdChar;";
                    cmd.Parameters.AddWithValue("IdChar", IdChar);
                    cmd.Parameters.AddWithValue("Name", C.Name);
                    cmd.Parameters.AddWithValue("Race", C.Race);
                    cmd.Parameters.AddWithValue("Sexe", C.Sexe);
                    cmd.Parameters.AddWithValue("Classe", C.Classe);
                    cmd.Parameters.AddWithValue("CitizenPlanet", C.CitizenPlanet);
                    cmd.Parameters.AddWithValue("TsIn", C.TsIn);
                    cnx.Open();
                    return (cmd.ExecuteNonQuery());
                    //cnx.Close();
                }
            }
        }
       
        public int UpdateCharacterStat(Stat CStat)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "UPDATE CharacterStat SET TimestampSimul=@TimestampSimul,PtMove=@PtMove,PtMoveMax=@PtMoveMax,Xp=@Xp,Gold=@Gold,Pv=@Pv,PvMax=@PvMax,Pw=@Pw,PwMax=@PwMax WHERE IdChar=@IdChar;";
                    cmd.Parameters.AddWithValue("PtMove", CStat.PtMove);
                    cmd.Parameters.AddWithValue("PtMoveMax", CStat.PtMoveMax);
                    cmd.Parameters.AddWithValue("Xp", CStat.Xp);
                    cmd.Parameters.AddWithValue("Pv", CStat.Pv);
                    cmd.Parameters.AddWithValue("PvMax", CStat.PvMax);
                    cmd.Parameters.AddWithValue("Pw", CStat.Pw);
                    cmd.Parameters.AddWithValue("PwMax", CStat.PwMax);

                    cnx.Open();
                    return cmd.ExecuteNonQuery();
                    //cnx.Close();
                }
            }
        }
        public int UpdateCharacterPower(Power CPow)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "UPDATE CharacterPower SET Eau=@Eau,Feu=@Feu,Air=@Air,Terre=@Terre,Lumiere=@Lumiere,tenebre=@Tenebre,Tranchant=@Tranchant,Ecrasant=@Ecrasant,Percant=@Percant,Poison=@Poison WHERE IdChar=@IdChar;";
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
                    return cmd.ExecuteNonQuery();
                    //cnx.Close();
                    
                }
            }
        }
        public int UpdateCharacterResist(Resist CRes)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = cnx.CreateCommand())
                {
                    cmd.CommandText = "UPDATE CharacterResist SET Eau=@Eau,Feu=@Feu,Air=@Air,Terre=@Terre,Lumiere=@Lumiere,tenebre=@Tenebre,Tranchant=@Tranchant,Ecrasant=@Ecrasant,Percant=@Percant,Poison=@Poison WHERE IdChar=@IdChar;";
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
