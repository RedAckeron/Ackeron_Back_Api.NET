using DAL.Models;

namespace BLL.Interfaces
{
    public interface IQuestService
    {
        int Create(Quest quest);
        List<Quest> GetCharacterAllQuest(int IdChar);
        
        
    }
}
