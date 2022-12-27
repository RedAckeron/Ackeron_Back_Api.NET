using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public  interface ILocalisatorRepo
    {
        int Create(Localisator Loc);
        Localisator Read(int IdLoc);
        bool Update(Localisator Loc);
        bool Delete(int IdLoc);
    }
}
