using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "MD.Raisul Islam Niloy";
            s1.Id = "19-39982-1";
            s1.Department = "CSE";

            Student s2 = new Student("Jsck", "123456", "CSE");
            Student s3 = new Student("Ash", "987654", "CSE");

            s1.showInfo();
            s2.showInfo();
            s3.showInfo();

            Book b1 = new Book("book1Name", "book1Author", "353", "Drama", 10);
            Book b2 = new Book("book2Name", "book2Author", "525", "Horror", 6);
            Book b3 = new Book("book3Name", "book3Author", "264", "Commedy", 3);
            Book b4 = new Book("book4Name", "book4Author", "235", "Fairytale", 2);
            Book b5 = new Book("book5Name", "book5Author", "642", "Romantic", 11);
            Book b6 = new Book("book6Name", "book6Author", "665", "Graphic novel", 5);


            s1.BorrowedBook = new Book[] { b1, b2 };
            s2.BorrowedBook = new Book[] { b3, b4, b5 };
            s3.BorrowedBook = new Book[] { b2, b6 };
            s1.showBorrowedBookInfo();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Library library = new Library("Bookstore", "Dhaka", new Book[] { b1, b2, b3, b4, b5, b6 }, 6);

            library.ShowAllBooks();
        }
    }
}
