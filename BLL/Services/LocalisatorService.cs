using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class LocalisatorService:ILocalisatorService
    {
        private readonly ILocalisatorRepo _localisatorRepo;
        public LocalisatorService(ILocalisatorRepo localisatorRepo)
        {
            _localisatorRepo = localisatorRepo;
        }
        public Localisator ReadLocalisator(int id)
        {
            Localisator datalocalisator = new();
            datalocalisator = _localisatorRepo.ReadLocalisator(id);
            return datalocalisator;
        }
    }
}