using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksInventory
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
    }
    public class BookContext: Books
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the title and the author of the book you wish you add to the data base");
            string input = Console.ReadLine();

        }
    }
    public class books
    {

    }
}
