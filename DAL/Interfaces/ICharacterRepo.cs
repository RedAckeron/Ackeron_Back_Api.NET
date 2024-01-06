using BLL.Models;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ICharacterRepo
    {
        int CreateHero(Hero h);
        Hero ReadHero(int IdHero);

        /*
       // int AddCharacterInfo(Info CInfo);
        int AddCharacterStat(Stat CStat);
        int AddCharacterLoc(int IdChar, Localisator CLoc);
        int AddCharacterPower(Power CPow);
        int AddCharacterResist(Resist CRes);
       
        //Info GetCharacterInfo(int id);
        //Localisator GetLocalisator(int id);
        Stat GetCharacterStat(int id);
        Power GetCharacterPower(int id);
        Resist GetCharacterResist(int id);
        List<Item> GetCharacterInventory(int id);
        List<Spell> GetCharacterSpell(int id);
        List<Quest> GetCharacterQuest(int id);

        //int UpdateCharacterInfo(int IdChar,Info CInfo);
        //int UpdateCharacterLoc(int IdChar, Localisator CLoc);
        int UpdateCharacterStat(Stat CStat);
        int UpdateCharacterResist(Resist CStat);
        int UpdateCharacterPower(Power CPow);
        */
    }
}