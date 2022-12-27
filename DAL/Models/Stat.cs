using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Stat
    {
        public int StatId { get; set; }=0;
        public int PtMove { get; set; } = 5;
        public int PtMoveMax { get; set; } = 20;
        public int Xp { get; set; } = 0;
        public int Pv { get; set; } = 100;
        public int PvMax { get; set; } = 100;
        public int Pw { get; set; } = 100;  
        public int PwMax { get; set; } = 100;
        public int TimeStampSimul { get; set; } = 1;
        public Stat(int statId, int ptMove, int ptMoveMax, int xp, int pv, int pvMax, int pw, int pwMax, int timeStampSimul)
        {
            StatId = statId;
            PtMove = ptMove;
            PtMoveMax = ptMoveMax;
            Xp = xp;
            Pv = pv;
            PvMax = pvMax;
            Pw = pw;
            PwMax = pwMax;
            TimeStampSimul = timeStampSimul;
        }
    }
}