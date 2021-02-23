using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Course
    {
        string courseName;
        string courseCode;
        int courseCredit;

        public Course()
        {
            courseName = "OBJECT ORIENTED PROGRAMMING 2";
            courseCode = "CSC2210";
            courseCredit = 3;
        }
        public Course(string courseName,string courseCode, int courseCredit)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
            this.courseCredit = courseCredit;
        }

        public void CourseInfo()
        {
            Console.WriteLine("CourseName : " + courseName);
            Console.WriteLine("CourseCode : " + courseCode);
            Console.WriteLine("CourseCredit : " + courseCredit);
        }
    }
}
