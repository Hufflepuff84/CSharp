using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace Checkpoint2_TodoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtils app = new ConsoleUtils();
            ItemContext context = new ItemContext();
            // makes sure that the table exists, 
            //and creates it if it does not already exist
            context.Database.EnsureCreated();
            app.Start();

            

            
        }
        
        
        
    }
}
