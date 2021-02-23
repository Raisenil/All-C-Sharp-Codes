using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Book
    {
        string bookName;
        string bookAuthor;
        string bookId;
        string bookType;
        int bookCopy;

        public string BookName 
        { 
            get { return bookName; } 
            set { bookName = value; }
        }
        public string BookAuthor 
        { 
            get { return bookAuthor; } 
            set { bookAuthor = value; } 
        }
        public string BookId 
        { 
            get { return bookId; } 
            set { bookId = value; } 
        }
        public string BookType 
        { 
            get { return bookType; } 
            set { bookType = value; } 
        }
        public int BookCopy 
        { 
            get { return BookCopy; } 
            set { bookCopy = value; } 
        }
        public Book()
        {

        }
        public Book(string bookName, string bookId,string bookType, string bookAuthor,int bookCopy)
        {
            this.bookName = bookName;
            this.bookAuthor = bookAuthor;
            this.bookId = bookId;
            this.bookType = bookType;
            this.bookCopy = bookCopy;
        }
        public void showInfo()
        {
            Console.WriteLine("Book Name : " + this.bookName);
            Console.WriteLine("Book ID : " + this.bookId);
            Console.WriteLine("Book Author : " + this.bookAuthor);
            Console.WriteLine("Book Type : " + this.bookType);
            Console.WriteLine("BookCopy : " + this.bookCopy);
        }

        public void AddBookCopy(int x)
        {
            this.bookCopy += x;
        }
    }
}
