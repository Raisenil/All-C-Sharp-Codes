using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class main
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.ShowInfo();

            Triangle t = new Triangle();
            t.ShowInfo();
            t.TestTriangle();

            Account a = new Account();
            a.ShowInfo();
            a.Amount = 500;
            a.Deposit(500);
            a.Withdraw(500);

            Course c = new Course();
            c.CourseInfo();
        }
    }
}
