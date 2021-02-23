using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Group_9.Models
{
    class Database
    {
        public Admins Admins { get; set; }
        public Employees Employees { get; set; }
        public Customers Customers { get; set; }
        public Orders Orders { get; set; }
        public Inventorys Inventorys { get; set; }
        public Database()
        {
            string connString = "Server=DESKTOP-S8F6A9P;Integrated Security=true;Database=Coffee_Shop_Management_System";
            SqlConnection conn = new SqlConnection(connString);
            Admins = new Admins(conn);
            Employees = new Employees(conn);
            Customers = new Customers(conn);
            Orders = new Orders(conn);
            Inventorys = new Inventorys(conn);
        }

    }
}
