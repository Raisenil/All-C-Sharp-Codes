using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Student
    {
        string name;
        string id;
        string department;
        float cgpa;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public String Department
        {
            get { return department; }
            set { department = value; }
        }

        Book[] borrowedBook;
        int borrowedBookCount;
        public Book[] BorrowedBook
        {
            get { return borrowedBook; }
            set 
            { 
                borrowedBook = value; 
                borrowedBookCount = borrowedBook.Length; 
            }
        }

        public int BorrowedBookCount
        {
            get { return borrowedBookCount; }
            set { borrowedBookCount = value; }
        }

        public Student()
        {
            Console.WriteLine("Empty constractor");
        }

        public Student(string name,string id, string department)
        {
            this.name = name;
            this.id = id;
            this.department = department;
        }
        public void showInfo()
        {
            Console.WriteLine("Name : "+this.name);
            Console.WriteLine("ID : " +this.id);
            Console.WriteLine("Department : " + this.department);
        }
        public void showBorrowedBookInfo()
        {
            for (int i = 0; i < borrowedBookCount; i++)
            {
                borrowedBook[i].showInfo();
            }
        }
    }
}
