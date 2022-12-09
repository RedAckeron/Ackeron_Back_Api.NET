using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;

namespace BLL.Services
{
    public  class QuestService:IQuestService
    {
        private readonly IQuestRepo _questRepo;

        public QuestService(IQuestRepo questRepo)
        {
            _questRepo = questRepo;
        }

        public List<Quest> GetCharacterAllQuest(int IdChar)
        {
            Console.WriteLine("couche service");
            return _questRepo.GetCharacterAllQuest(IdChar);
        }


    }
}
