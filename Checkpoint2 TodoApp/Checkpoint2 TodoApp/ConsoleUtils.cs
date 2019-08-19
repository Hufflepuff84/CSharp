using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_TodoApp
{
    class ConsoleUtils
    {
        App app = new App();
        public ConsoleUtils()
        {

        }

        public void Start()
        {

            while (true)
            {
                Console.WriteLine("What would you like to do?" +
                    "\n 1. Get All ToDo Items" +
                    "\n 2. Get Done To Do Items" +
                    "\n 3. Get Pending Items" +
                    "\n 4. Add a ToDo Item" +
                    "\n 5. Mark an Item as Done" +
                    "\n 6. Delete an Item");
                string choice = Console.ReadLine();


                if (choice.Equals("1"))
                {
                    IEnumerable<ToDo> todos = app.GetAll();
                    foreach(ToDo item in todos)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice.Equals("4"))
                {
                    Console.WriteLine("What is the description?");
                    string description = Console.ReadLine();
                    Console.WriteLine("When is the due date?");
                    string Due = Console.ReadLine();
                    app.Add(description, Due);
                    Console.WriteLine("Item Added!");
                }




            }


        }




    }
}
