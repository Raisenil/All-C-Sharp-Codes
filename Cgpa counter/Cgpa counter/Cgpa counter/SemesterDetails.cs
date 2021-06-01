using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cgpa_counter
{
    class SemesterDetails
    {
        String a;
        String b;
        int c;
        float d;

        public SemesterDetails()
        {
            Console.WriteLine("Error");
        }
        public SemesterDetails(String a, String b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void showInfo()
        {
            Console.WriteLine("Name: " + a);
            Console.WriteLine("ID: " + b);
            Console.WriteLine("Semester : " + c);
        }
        public void GPACalculator(params double[] x)
        {
            double sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum = sum + x[i];
            }
            d = (float)sum / c;

            Console.WriteLine("Cgpa: " + d);
        }
        public void ListOfSubjects(params object[] y)
        {
            Console.WriteLine("List of Subjects: ");
            for (int i = 0; i <= y.Length; i++)
            {

                Console.WriteLine(y[i]);
            }
        }

    }
}
