using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft;
using System.IO;

namespace BookInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksContext context = new BooksContext();
            

            Console.WriteLine("Enter the title of the book you wish you add followed by a (comma) and then type the book's author's full name");
            String fullName = Console.ReadLine();

            String[] parts = fullName.Split(',');
            if (parts.Length == 2)
            {
                Book newStudent = new Book(
                    parts[0], parts[1]);

                


                Console.WriteLine("Added the book.");
            }
            else
            {
                Console.WriteLine("Incorrect input," +
                    " no book was added");
            }

            Console.WriteLine("Here is a list of your books: ");

            


            Console.ReadLine();
        }
        public class Books
        {

        }
    }

    internal class BooksContext
    {
        internal object Database;
        internal object Books;
        internal object GetEnumerator;

        public BooksContext()
        {
        }
    }

    class Book
    {
        public int Id { get; private set; }
        public String Title { get; set; }
        public String Author { get; set; }
        public Book(String Title, String Author)
        {
            this.Title = Title;
            this.Author = Author;
        }
    }
}

    