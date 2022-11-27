using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MapService:IMapService
    {
        private readonly IMapRepo _mapRepo;

        public MapService(IMapRepo mapRepo)
        {
            _mapRepo = mapRepo;
        }

        public bool ChkTargetWalking(CharacterLoc CLoc) {
            return _mapRepo.ChkTargetWalking(CLoc);

            
        }
    }
}