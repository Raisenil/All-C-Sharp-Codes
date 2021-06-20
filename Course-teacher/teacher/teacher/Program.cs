using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course("X", "123", 12);
            //c1.Show();
            Course c2 = new Course("A", "423", 12);
            //c2.Show();
            Course c3 = new Course("B", "323", 12);
            //c3.Show();
            Course c4 = new Course("C", "223", 12);
            //c4.Show();
            Teacher t = new Teacher("Abir","19-1","abir@gmail.com",c1,c2,c3,c4);
            t.Show();
        }
    }
}
