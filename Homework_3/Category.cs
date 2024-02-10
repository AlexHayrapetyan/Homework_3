using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Category
    {
        private string categoryName;
        private string description;

        public Category(string categoryName, string description)
        {
            this.categoryName = categoryName;
            this.description = description;
        }

        public string CategoryName()
        {
            return categoryName;
        }

        public string Description()
        {
            return description;
        }
    }
}
