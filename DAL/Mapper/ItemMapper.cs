using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class ItemMapper
    {
        public Item DataToItem(IDataReader reader)
        {
            Item item = new Item();
           
            item.IdItem = (int)reader["Id"];
            item.Name = (string)reader["Name"];
            item.Description = (string)reader["Description"];
            item.Type = (string)reader["Type"];
            item.SubType = (string)reader["SubType"];
            item.Quality = (int)reader["Quality"];
            item.Price= (int)reader["Price"];
            item.Img= (string)reader["Img"];
            item.Color= (string)reader["Color"];
            item.LvlItem= (int)reader["LvlItem"];
            item.QtProduction= (int)reader["QtProduction"];
            item.TimeProduction= (int)reader["TimeProduction"];
            item.TimeDelete= (int)reader["TimeDelete"];
            item.MainTrigger= (string)reader["MainTrigger"];
            item.SubTrigger = (string)reader["SubTrigger"];
            
            return item;
        }
    }
}