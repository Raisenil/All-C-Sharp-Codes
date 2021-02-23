using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Models
{
    public class Admins
    {
        SqlConnection conn;
        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddAdmin(Admin Admin)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Admins VALUES ('{0}','{1}','{2}','{3}')", Admin.Name,Admin.Username, Admin.Password, Admin.Shop_id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }
        public Admin AuthenticateAdmin(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admins WHERE Username='{0}' and Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin Admin = null;
            while (reader.Read())
            {
                Admin = new Admin();
                Admin.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                Admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                Admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                Admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                Admin.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
            }
            conn.Close();
            return Admin;
        }
        public ArrayList GetAllAdmins()
        {
            ArrayList admins = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Admins";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Admin admin = new Admin();
                admin = new Admin();
                admin.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admin.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
                admins.Add(admin);
            }
            conn.Close();
            return admins;
        }

        public Admin GetAdmin(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Admins WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Admin admin = null;
            while (reader.Read())
            {
                admin = new Admin();
                admin.UserId = reader.GetInt32(reader.GetOrdinal("UserId"));
                admin.Name = reader.GetString(reader.GetOrdinal("Name"));
                admin.Username = reader.GetString(reader.GetOrdinal("Username"));
                admin.Password = reader.GetString(reader.GetOrdinal("Password"));
                admin.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
            }
            conn.Close();
            return admin;
        }
        public bool UpdateAdmin(Admin admin)
        {
            conn.Open();
            string query = String.Format("UPDATE Admins SET Name='{0}'  WHERE Username='{1}'", admin.Name, admin.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteAdmin(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Admins WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
