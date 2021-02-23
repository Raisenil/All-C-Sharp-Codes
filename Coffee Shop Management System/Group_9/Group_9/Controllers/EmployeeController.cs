using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_9.Models;

namespace Group_9.Controllers
{
    class EmployeeController
    {
        static Database db = new Database();

        public static bool AddEmployee(dynamic u)
        {
            Employee employee = new Employee();
            employee.Employee_name = u.Employee_name;
            employee.Employee_Username = u.Employee_Username;
            employee.Designation = u.Designation;
            employee.Salary = u.Salary;
            employee.Bonus = u.Bonus;
            employee.Password = u.Password;
            employee.Shop_id = u.Shop_id;

            return db.Employees.AddEmployee(employee);

        }
        public static Employee GetManager(string username)
        {
            return db.Employees.GetManager(username);
        }

        public static Employee GetStaff(string username)
        {
            return db.Employees.GetStaff(username);
        }

        public static bool UpdateManager(dynamic u)
        {
            Employee employee = new Employee();
            employee.Employee_name = u.Employee_name;
            employee.Employee_Username = u.Employee_Username;
            employee.Salary = u.Salary;
            employee.Bonus = u.Bonus;
            return db.Employees.UpdateManager(employee);
        }

        public static bool UpdateStaff(dynamic u)
        {
            Employee employee = new Employee();
            employee.Employee_name = u.Employee_name;
            employee.Employee_Username = u.Employee_Username;
            employee.Salary = u.Salary;
            employee.Bonus = u.Bonus;
            return db.Employees.UpdateStaff(employee);
        }
        public static bool DeleteManager(string username)
        {
            return db.Employees.DeleteManager(username);
        }
        public static bool DeleteStaff(string username)
        {
            return db.Employees.DeleteStaff(username);
        }

        public static ArrayList GetAllManager()
        {
            return db.Employees.GetAllManager();
        }
        public static ArrayList GetAllStaff()
        {
            return db.Employees.GetAllStaff();
        }
    }
}
