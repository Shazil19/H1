using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//namespace A_tour_of_the_library
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }

//    public class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public string ISBN { get; set; }
//        public int PageCount { get; set; }

//        public Book(string title, string author, string isbn, int pageCount)
//        {
//            Title = title;
//            Author = author;
//            ISBN = isbn;
//            PageCount = pageCount;
//        }

//        public override string ToString()
//        {
//            return "\nBook Title: " + Title + "   Author: " + Author + "   ISBN: " + ISBN + "   Page Count: " + PageCount;
//        }

//    }

//}

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public override string ToString()
    {
        return "\nTitle: " + Title + "   Author: " + Author + "   ISBN: " + ISBN;
    }

}

class LendingSystem
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>()
        {
            new Book("\nThe Great Gatsby", "F. Scott Fitzgerald", "978-0-6848-0707-4"),
            new Book("\nTo Kill a Mockingbird", "Harper Lee", "978-0-4463-1070-8"),
            new Book("\nPride and Prejudice", "Jane Austen", "978-0-14-143951-3"),
            new Book("\nThe Catcher in the Rye", "J.D. Salinger", "978-0-451-53247-1")
        };

        Stack<Book> loans = new Stack<Book>();

        Console.WriteLine("\nWelcome to the lending system! Please choose a book to borrow by entering its ISBN:");

        foreach (Book book in books)
        {
            Console.WriteLine($"\n{book.Title} - ISBN: {book.ISBN}");
        }

        while (true)
        {
            Console.WriteLine("\nEnter the ISBN of the book you would like to borrow (or type 'done' to finish):\n");
            
            string input = Console.ReadLine();

            if (input == "done")
            {
                break;
            }

            Book selectedBook = books.Find(book => book.ISBN == input);

            if (selectedBook == null)
            {
                Console.WriteLine("\nInvalid ISBN. Please try again.");
                continue;
            }

            books.Remove(selectedBook);

            loans.Push(selectedBook);

            Console.WriteLine($"\nYou have borrowed\n{selectedBook.Title} by {selectedBook.Author}");
        }

        Console.WriteLine("\nHere are the books you have borrowed:");

        while (loans.Count > 0)
        {
            Book loan = loans.Peek();

            Console.WriteLine($"\n{loan.Title} by {loan.Author}");
            
            loans.Pop();
        }

        Console.WriteLine("\nThank you for using the lending system! Have a great day.\n");

        Console.ReadKey();
    }
}
