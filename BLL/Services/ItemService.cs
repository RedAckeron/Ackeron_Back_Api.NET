using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ItemService:IItemService
    {
        
        private readonly IItemRepo _itemRepo;
        public ItemService(IItemRepo itemRepo)
        {
            _itemRepo = itemRepo;
        }
        
        public Item GetItem(int id)
        {
            return _itemRepo.GetItem(id);
        }

        public int AddItem(Item I)
        {
            return _itemRepo.AddItem(I);
        }
       
    }
}
