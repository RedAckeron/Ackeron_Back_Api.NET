using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IMobrepo
    {
        int Create(Mob M);
        Mob Read(int IdMob);
        List<int> ReadAllOfPlanet(int IdPlanet);
        int Update(Mob M);
    }
}
