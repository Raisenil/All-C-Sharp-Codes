using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Models
{
    class Customers
    {
        SqlConnection conn;
        public Customers(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddCustomer(Customer Customer)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Customers VALUES ('{0}','{1}','{2}','{3}','{4}')", Customer.Customer_name, Customer.Customer_Username,Customer.Password, Customer.Phone_no,Customer.Shop_id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public ArrayList GetAllCustomers()
        {
            ArrayList customers = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Customers";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Customer customer = new Customer();
                customer = new Customer();
                customer.Customer_id = reader.GetInt32(reader.GetOrdinal("Customer_id"));
                customer.Customer_name = reader.GetString(reader.GetOrdinal("Customer_name"));
                customer.Customer_Username = reader.GetString(reader.GetOrdinal("Customer_Username"));
                customer.Phone_no = reader.GetString(reader.GetOrdinal("Phone_no"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
                customer.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
                customers.Add(customer);
            }
            conn.Close();
            return customers;
        }
        public Customer GetCustomer(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Customers WHERE Customer_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Customer customer = null;
            while (reader.Read())
            {
                customer = new Customer();
                customer.Customer_id = reader.GetInt32(reader.GetOrdinal("Customer_id"));
                customer.Customer_name = reader.GetString(reader.GetOrdinal("Customer_name"));
                customer.Customer_Username = reader.GetString(reader.GetOrdinal("Customer_Username"));
                customer.Phone_no = reader.GetString(reader.GetOrdinal("Phone_no"));
                customer.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return customer;
        }
        public bool UpdateCustomer(Customer customer)
        {
            conn.Open();
            string query = String.Format("UPDATE Customers SET Customer_name='{0}',Phone_no='{1}' WHERE Customer_Username='{2}'", customer.Customer_name,customer.Phone_no, customer.Customer_Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteCustomer(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Customers WHERE Customer_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
