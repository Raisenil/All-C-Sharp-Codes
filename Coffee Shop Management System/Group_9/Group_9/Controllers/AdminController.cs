using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_9.Models;

namespace Group_9.Controllers
{
    public class AdminController
    {
        static Database db = new Database();
        public static Admin AuthenticateAdmin(string username, string password)
        {
            return db.Admins.AuthenticateAdmin(username, password);
        }
        public static bool AddAdmin(dynamic u)
        {
            Admin admin = new Admin();
            admin.Name = u.Name;
            admin.Username = u.Username;
            admin.Password = u.Password;
            admin.Shop_id = u.Shop_id;

            return db.Admins.AddAdmin(admin);
        }
        public static Admin GetAdmin(string username)
        {
            return db.Admins.GetAdmin(username);
        }
        public static bool UpdateAdmin(dynamic u)
        {
            Admin admin = new Admin();
            admin.Name = u.Name;
            admin.Username = u.Username;
            return db.Admins.UpdateAdmin(admin);
        }
        public static bool DeleteAdmin(string username)
        {
            return db.Admins.DeleteAdmin(username);
        }
        public static ArrayList GetAllAdmins()
        {
            return db.Admins.GetAllAdmins();
        }
    }
}
