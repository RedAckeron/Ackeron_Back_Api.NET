﻿using BLL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using DAL.Models.Map;
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

        public bool ChkAreaReachable(Localisator Loc) {
           
            return _mapRepo.ChkAreaReachable(Loc);
        }
        public List<Area> GetMap(int IdPlanet) {

            return _mapRepo.GetMap(IdPlanet);
        }
    }
}