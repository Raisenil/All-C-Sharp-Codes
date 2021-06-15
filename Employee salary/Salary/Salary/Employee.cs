using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Employee
    {
        public string name;
        public string id;
        public string email;
        private int age;
        private Salary salary;
        public Employee()
        {

        }
        public Employee(string name, string id, string email, int age, Salary salary)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.age = age;
            this.salary = salary;
        }
        public int Age
        {
            get { return Age; }
        }
        public Salary Salary
        {
            get { return salary; }
        }
        public void Show()
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("id:" + id);
            Console.WriteLine("email:" + email);
            Console.WriteLine("Age:" + age);
        }
    }
}
