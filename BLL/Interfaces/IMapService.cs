using BLL.Models;
using DAL.Models;
using DAL.Models.Map;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IMapService
    {
        int CheckExist(Localisator loc);
        Area Read(int IdArea);
        bool ChkAreaReachable(Localisator Loc);
       
        List<Area> GetMap(int IdPlanet);
    }
}
