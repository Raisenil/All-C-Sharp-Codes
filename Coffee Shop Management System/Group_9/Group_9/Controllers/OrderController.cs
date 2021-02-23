using Group_9.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Controllers
{
    public class OrderController
    {
        static Database db = new Database();

        public static ArrayList GetAllItem(string username)
        {
            return db.Orders.GetAllItem(username);
        }

        public static ArrayList GetAllUsername(string username)
        {
            return db.Orders.GetAllUsername(username);
        }

        public static ArrayList GetAllOrder()
        {
            return db.Orders.GetAllOrder();
        }
    }
}
