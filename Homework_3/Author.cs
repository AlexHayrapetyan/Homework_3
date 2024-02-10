using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class Author
    {
        
        private string name;
        private string biography;

        public Author(string name, string biography)
        {
            this.name = name;
            this.biography = biography;
        }

        public string Name()
        {
            return name;
        }

        public string Biography()
        {
            return biography;
        }
    }

}
