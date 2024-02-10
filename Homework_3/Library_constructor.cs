using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Homework_3
{
    public static class LibraryManager
    {
        private static List<Books> books = new List<Books>();

        public static void AddBook(Books book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully");
        }

        public static void RemoveBook(string title)
        {
            Books bookToRemove = books.Find(book => book.Title() == title);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }

        public static void ListAllBooks()
        {
            bool empty = true;

            Console.WriteLine("Listing all books:");
            foreach (Books book in books)
            {
                Console.WriteLine($"Title: {book.Title()}, Author: {book.Author().Name()}, Category: {book.Category().CategoryName()}");
                empty = false;
            }

            if (empty == true) Console.WriteLine("No books were found to list.");
        }
    }


}
