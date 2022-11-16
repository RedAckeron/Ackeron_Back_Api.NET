using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IItemService
    {
        Item GetItem(int id);
        int AddItem(Item I);
    }
}
