using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IInventoryService
    {
        int Add(int IdItem,int IdChar,int Qt);
        List<Item> Get(int IdChar);
    }
}
