using DAL.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
   
    public interface ILocalisatorRepo
    {
        Localisator GetLocalisator(int id);
        int UpdateLocalisator(int Id, Localisator Loc);

    }
}
