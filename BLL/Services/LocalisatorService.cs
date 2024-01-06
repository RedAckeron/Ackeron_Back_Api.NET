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

        public int Create(Localisator Loc)
        {
            //Localisator datalocalisator = new(1,1,1,1,1,1,1,1,1,1,1,1,1,1);
            return (_localisatorRepo.Create(Loc));
        }

        public bool Delete(int IdLoc)
        {
            throw new NotImplementedException();
        }

        public Localisator Read(int IdLoc)
        {
            Localisator datalocalisator = new Localisator(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
            datalocalisator = _localisatorRepo.Read(IdLoc);
            Console.WriteLine("Localisator read : " + datalocalisator.LocalisatorId + " : " + datalocalisator.LocAX + "/" + datalocalisator.LocAY);
            return datalocalisator;
           

           
        }

        public bool Update(Localisator Loc)
        {
            return (_localisatorRepo.Update(Loc));

        }
    }
}