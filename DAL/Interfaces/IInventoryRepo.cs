using BLL.Models;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IInventoryRepo
    {
        int Add(int IdItem, int IdChar, int Qt);
        List<Item> Get(int IdChar,IItemRepo _itemRepo);
    }
}
