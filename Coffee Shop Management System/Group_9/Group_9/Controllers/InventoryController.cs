using Group_9.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Controllers
{
    public class InventoryController
    {
        static Database db = new Database();
        public static bool AddInventory(dynamic u)
        {
            Inventory inventory = new Inventory();
            inventory.Item_Name = u.Item_Name;
            inventory.Price = u.Price;

            return db.Inventorys.AddInventory(inventory);
        }
        public static Inventory GetInventory(string username)
        {
            return db.Inventorys.GetInventory(username);
        }
        public static bool UpdateInventory(dynamic u)
        {
            Inventory inventory = new Inventory();
            inventory.Price = u.Price;
            inventory.Item_Name = u.Item_Name;
            return db.Inventorys.UpdateInventory(inventory);
        }
        public static ArrayList GetAllInventory()
        {
            return db.Inventorys.GetAllInventory();
        }
        public static bool DeleteInventory(string username)
        {
            return db.Inventorys.DeleteInventory(username);
        }
    }
}
