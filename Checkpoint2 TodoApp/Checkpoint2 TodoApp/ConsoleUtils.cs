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
                    IEnumerable<ToDo> Todos = app.GetAll();
                    var foo = Todos.ToList();
                    foreach(ToDo item in Todos)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice.Equals("2"))
                {
                    IEnumerable<ToDo> Todos = app.GetDone();
                    var foo = Todos.ToList();
                    foreach (ToDo item in Todos)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice.Equals("3"))
                {
                    IEnumerable<ToDo> Todos = app.GetPending();
                    var foo = Todos.ToList();
                    foreach (ToDo item in Todos)
                    {
                        Console.WriteLine(item);
                    }
                }
                else if (choice.Equals("4"))
                {
                    Console.WriteLine("What is the description?");
                    string description = Console.ReadLine();
                    Console.WriteLine("When is the Status?");
                    string Due = Console.ReadLine();
                    app.Add(description, Due);

                    Console.WriteLine("Item Added!");
                }
                else if (choice.Equals("5"))
                {
                    Console.WriteLine("What is the Id of the item you want marked as done?");
                    string what = Console.ReadLine();
                    int Id = int.Parse(what); // you can try using tryparse and it returns a boolean
                    app.MarkAsDone(Id);
                }
                else if (choice.Equals("6"))
                {
                    Console.WriteLine("Which to do Items do you wish to be deleted?");
                    string retort = Console.ReadLine();
                    int Id = int.Parse(retort);
                    app.Delete(Id);
                }
                else
                {
                    Console.WriteLine("Sorry that was invalid input, try again!");
                }




            }


        }




    }
}
