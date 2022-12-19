using BLL.Interfaces;
using BLL.Mapper;
using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MobService : IMobService
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
        public Mob Read(int id) {
            return null;
        }
        public int Update(Mob M) {
            return 0;
        }
        public int Delete(int id) {
            return 0;
        }

    }
}
