using BLL.Interfaces;
using BLL.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class InventoryService:IInventoryService
    {

        private readonly IInventoryRepo _inventoryRepo;
        private readonly IItemRepo _itemRepo;
        public InventoryService(IInventoryRepo inventoryRepo,IItemRepo itemRepo)
        {
            _inventoryRepo = inventoryRepo;
            _itemRepo = itemRepo;
        }
        public int Add(int IdItem,int IdChar,int Qt)
        {
            return _inventoryRepo.Add(IdItem, IdChar, Qt);
        }
        public List<Item> Get(int IdChar) 
        {
            return _inventoryRepo.Get(IdChar,_itemRepo);

        }

    }
}
