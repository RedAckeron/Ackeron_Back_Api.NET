using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Localisator
    {
        public Localisator(int localisatorId, int locUId, int locSId, int locSX, int locSY, int locPId, int locPX, int locPY, int locAId, int locAX, int locAY, int locZId, int locZX, int locZY)
        {
            LocalisatorId = localisatorId;
            LocUId = locUId;
            LocSId = locSId;
            LocSX = locSX;
            LocSY = locSY;
            LocPId = locPId;
            LocPX = locPX;
            LocPY = locPY;
            LocAId = locAId;
            LocAX = locAX;
            LocAY = locAY;
            LocZId = locZId;
            LocZX = locZX;
            LocZY = locZY;
        }

        public int LocalisatorId { get; set; }
        public int LocUId { get; set; } 
        public int LocSId { get; set; } 
        public int LocSX { get; set; } 
        public int LocSY { get; set; } 
        public int LocPId { get; set; }
        public int LocPX { get; set; } 
        public int LocPY { get; set; } 
        public int LocAId { get; set; }
        public int LocAX { get; set; } 
        public int LocAY { get; set; } 
        public int LocZId { get; set; }
        public int LocZX { get; set; }
        public int LocZY { get; set; }
    }
    
}