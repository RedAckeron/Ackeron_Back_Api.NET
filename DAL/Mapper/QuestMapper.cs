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
    public class QuestMapper
    {
        public Quest DataToQuest(IDataReader reader)
        {
            Quest quest = new Quest();
           

            quest.IdQuest = (int)reader[2];
            quest.Name = (string)reader[3];
            quest.Description=(string)reader[4];

            return quest;
       
        }
    }
}