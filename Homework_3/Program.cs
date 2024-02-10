using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Library Management System");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. List All Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                

                
            }
        }

        static void AddBook()
        {
            Console.WriteLine("Enter book details:");
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();
            Console.Write("Author Biography: ");
            string authorBiography = Console.ReadLine();
            Console.Write("Category Name: ");
            string categoryName = Console.ReadLine();
            Console.Write("Category Description: ");
            string categoryDescription = Console.ReadLine();
            Console.Write("Year: ");
            

            if (authorName != null && authorBiography != null && categoryDescription != null && categoryName != null && title != null)
            {
                Author author = new Author(authorName, authorBiography);
                Category category = new Category(categoryName, categoryDescription);
                Books book = new Books(title, author, category);

                LibraryManager.AddBook(book);
            }
            else
            {
                Console.WriteLine("Error");
            }

        }

        static void RemoveBook()
        {
            Console.Write("Enter the title of the book: ");
            string title = Console.ReadLine();
            if (title != null)
            {
                LibraryManager.RemoveBook(title);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }

    }

