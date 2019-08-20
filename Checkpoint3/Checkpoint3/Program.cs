using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace ToDoCheckpoint
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils Session = new ConsoleUtils();
            Session.Start();
            Console.ReadKey();
        }
    }
}