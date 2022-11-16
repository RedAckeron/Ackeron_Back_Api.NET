using BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IItemRepo
    {
        int AddItem(Item item);
        Item GetItem(int id);

    }
}
