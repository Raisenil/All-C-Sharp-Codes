using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s = new Salary(10, 30, 40);

            Employee e = new Employee("xy", "19-1","x@gmail.com", 20, s);
            e.Show();
            s.Show();

        }
    }
}
