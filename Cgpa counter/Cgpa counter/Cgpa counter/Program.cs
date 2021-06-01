using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cgpa_counter
{
    class Program
    {
        static void Main(string[] args)
        {
            SemesterDetails p = new SemesterDetails();
            SemesterDetails p1 = new SemesterDetails("Suschi", "19-40235-1", 7);
       
            p1.showInfo();
            p1.GPACalculator(3.10,3.25,3.50,3.12,3.56,3.60,3.25);
            p1.ListOfSubjects("ENGLISH READING SKILLS & PUBLIC SPEAKING", "PHYSICS 1", "PHYSICS 1 LAB", "OBJECT ORIENTED PROGRAMMING 1 (JAVA)");
        }
    }
}