using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    class Course
    {
        public string courseName;
        public string courseID;
        public int credit;
        public Course()
        {

        }
        public Course(string courseName, string courseID, int credit)
        {

            this.courseName = courseName;
            this.courseID = courseID;
            this.credit = credit;
        }
        public void Show()
        {
            Console.WriteLine("courseName:" + courseName);
            Console.WriteLine("courseID:" + courseID);
            Console.WriteLine("credit:" + credit);
        }
    }
}
