using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Library
    {
        string libName;
        string libAddress;
        Book[] listofBook;
        int totalBook;
        Student[] libMembers;

        public String LibName 
        { 
            get { return libName; } 
            set { libName = value; } 
        }
        public String LibAddress 
        { 
            get { return libAddress; } 
            set { libAddress = value; } 
        }
        public Book[] ListOfBook 
        { 
            get { return listofBook; } 
            set { listofBook = value; } 
        }
        public int TotalBook 
        {
            get { return totalBook; } 
            set { totalBook = value; } 
        }
        public Student[] LibMembers 
        { 
            get { return libMembers; } 
            set { libMembers = value; } 
        }
        /*public Account LibAccount 
        { 
            get {return libAccount;} 
            set {libAccount = value;} 
        }*/
        public Library()
        {

        }
        public Library(string libName, string libAddress,Book[] listofBook,int totalBook)
        {
            this.libName = libName;
            this.libAddress = libAddress;
            this.listofBook = listofBook;
            this.totalBook = totalBook;
        }
        public void ShowlibInfo()
        {
            Console.WriteLine("Library Name : " + this.libName);
            Console.WriteLine("Library Address : " + this.libName);
            Console.WriteLine("Total Number of Books : " + this.totalBook);
        }
        public void ShowAllBooks()
        {
            for (int i = 0; i < totalBook; i++)
            {
                listofBook[i].showInfo();
                Console.WriteLine();
            }
        }
        public void AddNewBook(Book book)
        {
            listofBook[totalBook++] = book;
        }
        public void DeleteBook(Book book)
        {
            int i = 0;
            for (i = 0; i < totalBook; i++)
            {
                if (listofBook[i] == book)
                {
                    listofBook[i] = null;
                    break;
                }
            }

            if (i < totalBook)
            {
                for (int j = i; j < totalBook - 1; ++j)
                {
                    listofBook[j] = listofBook[j + 1];
                }
            }
        }

        public void AddNewBookCopy(Book book, int copy)
        {
            int i = 0;

            for (i = 0; i < totalBook; i++)
            {
                if (listofBook[i] == book)
                {
                    listofBook[i] = null;
                    break;
                }
            }

            if (i < totalBook)
            {
                listofBook[i].AddBookCopy(copy);
            }
        }
        public void showAllBorrowInfo()
        {
            for (int i = 0; i < libMembers.Length; i++)
            {
                libMembers[i].showInfo();
                libMembers[i].showBorrowedBookInfo();
            }
        }
    }
}
