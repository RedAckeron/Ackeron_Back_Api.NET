﻿using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IMobService
    {
        int Create(Mob mob);
        Mob Read(int id);
        int Update(Mob mob);    
        int Delete(int id);
    }
}