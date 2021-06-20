using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teacher
{
    class Teacher
    {
        public string name;
        public string id;
        public string email;
        public Course[] course = new Course[4];
        public Teacher()
        {
            Console.WriteLine("Index error");
        }
        public Teacher(string name, string id, string email, Course course1, Course course2, Course course3, Course course4)
        {
            this.name = name;
            this.id = id;
            this.email = email;
            this.course[0] = course1;
            this.course[1] = course2;
            this.course[2] = course3;
            this.course[3] = course4;
        }
        public void Show()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("email: " + email);
            Console.WriteLine("CourseName: " + course[0].courseName + " CourseID: " + course[0].courseID + " Credit: " + course[0].credit);
            Console.WriteLine("CourseName: " + course[1].courseName + " CourseID: " + course[1].courseID + " Credit: " + course[1].credit);
            Console.WriteLine("CourseName: " + course[2].courseName + " CourseID: " + course[2].courseID + " Credit: " + course[2].credit);
            Console.WriteLine("CourseName: " + course[3].courseName + " CourseID: " + course[3].courseID + " Credit: " + course[3].credit);
        }

    }
}
