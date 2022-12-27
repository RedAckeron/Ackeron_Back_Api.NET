using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface ILocalisatorService
    {
        int Create(Localisator Loc);
        Localisator Read(int IdLoc);
        bool Update (Localisator Loc);
        bool Delete (int IdLoc);

    }
}
