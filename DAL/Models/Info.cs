﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Info
    {
        public Info(int infoId,string name, int race, int sexe, int classe, int gold,int citizenPlanet,string img,string orientation)
        {
            InfoId=infoId;
            Name = name;
            Race = race;
            Sexe = sexe;
            Classe = classe;
            Gold = gold;
            CitizenPlanet = citizenPlanet;
            Img = img;
            Orientation=orientation;
        }
        public int InfoId { get; set; }
        public string Name { get; set; }
        public int Race { get; set; }
        public int Sexe{ get; set; }
        public int Classe{ get; set; }
        public int Gold { get; set; }
        public int CitizenPlanet { get; set; }
        public string Img { get; set; }
        public string Orientation { get; set; }

    }
}
