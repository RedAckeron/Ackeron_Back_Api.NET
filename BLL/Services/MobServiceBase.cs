using BLL.Mapper;
using DAL.Models;

namespace BLL.Services
{
    public class MobServiceBase
    {
        public int Create(Mob M)
        {
            CharacterMapper mapper = new();
            Stat MStat;
            Localisator MLoc;
            Power MPow;
            Resist MRes;

            //CInfo = mapper.CharacterToCharacterInfo(C);
            //int IdChar = _characterRepo.AddCharacterInfo(CInfo);
            /*
            CStat = mapper.CharacterToCharacterStat(C);
            CStat.IdChar = IdChar;
            _characterRepo.AddCharacterStat(CStat);

            CLoc = mapper.CharacterToCharacterLoc(C);
            //CLoc.IdChar = IdChar;
            _characterRepo.AddCharacterLoc(C.Id, CLoc);

            CPow = mapper.CharacterToCharacterPower(C);
            CPow.IdChar = IdChar;
            _characterRepo.AddCharacterPower(CPow);

            CRes = mapper.CharacterToCharacterResist(C);
            CRes.IdChar = IdChar;
            _characterRepo.AddCharacterResist(CRes);
            */
            return 0;
        }
    }
}