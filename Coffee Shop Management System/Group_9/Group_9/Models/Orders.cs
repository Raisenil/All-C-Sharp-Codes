using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Models
{
    public class Orders
    {
        SqlConnection conn;
        public Orders(SqlConnection conn)
        {
            this.conn = conn;
        }
        public ArrayList GetAllItem(string username)
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = String.Format("SELECT * FROM Orders WHERE Item_Name='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order = new Order();
                order.Order_id = reader.GetInt32(reader.GetOrdinal("Order_id"));
                order.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                order.Price = reader.GetString(reader.GetOrdinal("Price"));
                order.Customer_Username = reader.GetString(reader.GetOrdinal("Customer_Username"));
                orders.Add(order);
            }
            conn.Close();
            return orders;
        }
        public ArrayList GetAllUsername(string username)
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = String.Format("SELECT * FROM Orders WHERE Customer_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order = new Order();
                order.Order_id = reader.GetInt32(reader.GetOrdinal("Order_id"));
                order.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                order.Price = reader.GetString(reader.GetOrdinal("Price"));
                order.Customer_Username = reader.GetString(reader.GetOrdinal("Customer_Username"));
                orders.Add(order);
            }
            conn.Close();
            return orders;
        }

        public ArrayList GetAllOrder()
        {
            ArrayList orders = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Orders";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Order order = new Order();
                order = new Order();
                order.Order_id = reader.GetInt32(reader.GetOrdinal("Order_id"));
                order.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                order.Price = reader.GetString(reader.GetOrdinal("Price"));
                order.Customer_Username = reader.GetString(reader.GetOrdinal("Customer_Username"));
                orders.Add(order);
            }
            conn.Close();
            return orders;
        }
    }
}
