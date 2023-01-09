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
        public int Create(Quest quest) 
        {
            return _questRepo.Create(quest);
        }

        public List<Quest> GetCharacterAllQuest(int IdChar)
        {
            return _questRepo.GetCharacterAllQuest(IdChar);
        }


    }
}
