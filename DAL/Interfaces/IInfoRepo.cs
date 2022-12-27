using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInfoRepo
    {
        int Create(Info info);
        Info Read(int InfoId);
    }
}
