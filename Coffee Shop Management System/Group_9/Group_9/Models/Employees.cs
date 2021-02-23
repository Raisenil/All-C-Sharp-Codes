using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_9.Models
{
    public class Employees
    {
        SqlConnection conn;
        public Employees(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddEmployee(Employee Employee)
        {
            conn.Open();
            string query = String.Format("INSERT INTO Employees VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", Employee.Employee_name, Employee.Employee_Username, Employee.Password, Employee.Designation, Employee.Salary, Employee.Bonus, Employee.Shop_id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0)
                return true;
            return false;
        }

        public Employee GetManager(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE Employee_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Employee_id = reader.GetInt32(reader.GetOrdinal("Employee_id"));
                employee.Employee_name = reader.GetString(reader.GetOrdinal("Employee_name"));
                employee.Employee_Username = reader.GetString(reader.GetOrdinal("Employee_Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employee.Designation = reader.GetString(reader.GetOrdinal("Designation"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));
                employee.Bonus = reader.GetString(reader.GetOrdinal("Bonus"));
                employee.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
            }
            conn.Close();
            return employee;
        }
        public Employee GetStaff(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Employees WHERE Employee_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Employee employee = null;
            while (reader.Read())
            {
                employee = new Employee();
                employee.Employee_id = reader.GetInt32(reader.GetOrdinal("Employee_id"));
                employee.Employee_name = reader.GetString(reader.GetOrdinal("Employee_name"));
                employee.Employee_Username = reader.GetString(reader.GetOrdinal("Employee_Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employee.Designation = reader.GetString(reader.GetOrdinal("Designation"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));
                employee.Bonus = reader.GetString(reader.GetOrdinal("Bonus"));
                employee.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
            }
            conn.Close();
            return employee;
        }

        public ArrayList GetAllManager()
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Employees WHERE designation = 'Manager'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee = new Employee();
                employee.Employee_id = reader.GetInt32(reader.GetOrdinal("Employee_id"));
                employee.Employee_name = reader.GetString(reader.GetOrdinal("Employee_name"));
                employee.Employee_Username = reader.GetString(reader.GetOrdinal("Employee_Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employee.Designation = reader.GetString(reader.GetOrdinal("Designation"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));
                employee.Bonus = reader.GetString(reader.GetOrdinal("Bonus"));
                employee.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }

        public ArrayList GetAllStaff()
        {
            ArrayList employees = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Employees WHERE designation = 'Staff'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee employee = new Employee();
                employee = new Employee();
                employee.Employee_id = reader.GetInt32(reader.GetOrdinal("Employee_id"));
                employee.Employee_name = reader.GetString(reader.GetOrdinal("Employee_name"));
                employee.Employee_Username = reader.GetString(reader.GetOrdinal("Employee_Username"));
                employee.Password = reader.GetString(reader.GetOrdinal("Password"));
                employee.Designation = reader.GetString(reader.GetOrdinal("Designation"));
                employee.Salary = reader.GetString(reader.GetOrdinal("Salary"));
                employee.Bonus = reader.GetString(reader.GetOrdinal("Bonus"));
                employee.Shop_id = reader.GetInt32(reader.GetOrdinal("Shop_id"));
                employees.Add(employee);
            }
            conn.Close();
            return employees;
        }
        public bool UpdateManager(Employee employee)
        {
            conn.Open();
            string query = String.Format("UPDATE Employees SET Employee_name='{0}',Salary='{1}',Bonus='{2}' WHERE Employee_Username='{3}'", employee.Employee_name,employee.Salary,employee.Bonus,employee.Employee_Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool UpdateStaff(Employee employee)
        {
            conn.Open();
            string query = String.Format("UPDATE Employees SET Employee_name='{0}',Salary='{1}',Bonus='{2}' WHERE Employee_Username='{3}'", employee.Employee_name, employee.Salary, employee.Bonus, employee.Employee_Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteManager(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Employees WHERE Employee_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }

        public bool DeleteStaff(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Employees WHERE Employee_Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
