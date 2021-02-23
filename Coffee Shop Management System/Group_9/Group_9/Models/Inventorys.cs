using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Models
{
    public class Inventorys
    {
        SqlConnection conn;
        public Inventorys(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddInventory(Inventory Inventory)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Inventorys VALUES ('{0}','{1}')", Inventory.Item_Name,Inventory.Price);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public ArrayList GetAllInventory()
        {
            ArrayList inventorys = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Inventorys";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Inventory inventory = new Inventory();
                inventory = new Inventory();
                inventory.Inventory_id = reader.GetInt32(reader.GetOrdinal("Inventory_Id"));
                inventory.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                inventory.Price = reader.GetString(reader.GetOrdinal("Price"));
                inventorys.Add(inventory);
            }
            conn.Close();
            return inventorys;
        }
        public Inventory GetInventory(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Inventorys WHERE Item_Name='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Inventory inventory = null;
            while (reader.Read())
            {
                inventory = new Inventory();
                inventory.Inventory_id = reader.GetInt32(reader.GetOrdinal("Inventory_id"));
                inventory.Item_Name = reader.GetString(reader.GetOrdinal("Item_Name"));
                inventory.Price = reader.GetString(reader.GetOrdinal("Price"));
            }
            conn.Close();
            return inventory;
        }
        public bool UpdateInventory(Inventory inventory)
        {
            conn.Open();
            string query = String.Format("UPDATE Inventorys SET Price='{0}' WHERE Item_Name='{1}'", inventory.Price,inventory.Item_Name);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteInventory(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Inventorys WHERE Item_Name='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
