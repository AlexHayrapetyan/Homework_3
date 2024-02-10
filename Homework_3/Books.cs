using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Books
    {
        private string title;
        private Author author;
        private Category category;

        public Books(string title, Author author, Category category)
        {
            this.title = title;
            this.author = author;
            this.category = category;
        }
        public string Title()
        {
            return title;
        }

        public Author Author()
        {
            return author;
        }

        public Category Category()
        {
            return category;
        }


    }

}
