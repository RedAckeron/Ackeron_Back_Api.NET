using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IHeroService
    {
        int Create(Hero hero);
        Hero Read(int id);
        Localisator Move(int idchar, char orientation);

    }
}