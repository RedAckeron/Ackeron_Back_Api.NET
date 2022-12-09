using DAL.Models;

namespace BLL.Interfaces
{
    public interface IQuestService
    {
        List<Quest> GetCharacterAllQuest(int IdChar);
        
        
    }
}
