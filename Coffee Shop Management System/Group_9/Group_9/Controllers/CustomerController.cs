using Group_9.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Controllers
{
    class CustomerController
    {
        static Database db = new Database();

        public static bool AddCustomer(dynamic u)
        {
            Customer customer = new Customer();
            customer.Customer_name = u.Customer_name;
            customer.Customer_Username = u.Customer_Username;
            customer.Password = u.Password;
            customer.Shop_id = u.Shop_id;
            customer.Phone_no = u.Phone_no;

            return db.Customers.AddCustomer(customer);

        }
        public static Customer GetCustomer(string username)
        {
            return db.Customers.GetCustomer(username);
        }

        public static bool UpdateCustomer(dynamic u)
        {
            Customer customer = new Customer();
            customer.Customer_name = u.Customer_name;
            customer.Customer_Username = u.Customer_Username;
            customer.Phone_no = u.Phone_no;
            return db.Customers.UpdateCustomer(customer);
        }

        public static bool DeleteCustomer(string username)
        {
            return db.Customers.DeleteCustomer(username);
        }

        public static ArrayList GetAllCustomers()
        {
            return db.Customers.GetAllCustomers();
        }
    }
}
