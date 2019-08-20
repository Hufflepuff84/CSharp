using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Checkpoint3
{
    class ConsoleUtils  // between user and app
    {
        App app = new App();
        public ConsoleUtils()
        {
        }

        // select work
        public void Start()
        {
            bool InUse = true;
            while (InUse == true)
            {
                PrintAll();
                Console.WriteLine();
                Console.WriteLine("                           The To Do List!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Enter 1 - 6:");
                Console.WriteLine("     1 to Add an Item to the todo list.");
                Console.WriteLine("     2 to Mark an Item Done.");
                Console.WriteLine("     3 to Delete an Item.");
                Console.WriteLine("     4 to Print all Pending items.");
                Console.WriteLine("     5 to print all Done Items");
                Console.WriteLine("     6 to Quit");
                string Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    Add();
                }
                else if (Choice == "2")
                {
                    Change();
                }
                else if (Choice == "3")
                {
                    DelItem();
                }
                else if (Choice == "4")
                {
                    PrintPending();
                }
                else if (Choice == "5")
                {
                    PrintDone();
                }
                else if (Choice == "6")
                {
                    InUse = false;
                }
                else
                {
                    Console.WriteLine("Inocorrect input, press enter to try again");
                    Console.ReadKey();
                }
                Console.Clear();
            }
        }

        public void Add()
        {
            Console.WriteLine("Enter a New to do item.");
            string Add = Console.ReadLine();
            app.Add(Add);
        }

        public void Change()
        {
            int cng;
            Console.WriteLine("ID Numbers are in the first row of the table!");
            Console.WriteLine("Enter an item id Number to change the status.");
            string Change = Console.ReadLine();
            try
            {
                cng = Int32.Parse(Change);
            }
            catch
            {
                Console.WriteLine("The Number 'Zero' (for your ability to follow intstructions) has been entered!!");
                Change = "0";
                Console.ReadKey();

            }
            app.Change(Change);
        }

        public void DelItem()
        {
            int del;
            Console.WriteLine("ID Numbers are in the first row of the table!");
            Console.WriteLine("Enter an item id Number to DELETE that item.");
            string Delet = Console.ReadLine();
            try
            {
                del = Int32.Parse(Delet);
            }
            catch
            {
                Console.WriteLine("The NUMBER 'Zero' (for your ability to follow intstructions) has been entered!!");
                Delet = "0";
                Console.ReadKey();
            }
            app.DelItem(Delet);
        }

        public void PrintPending()
        {
            app.PrintPending();
        }

        public void PrintDone()
        {
            app.PrintDone();
        }

        public void PrintAll()
        {
            Console.WriteLine("The Current List of" +
                " to do items is: ");
            Console.WriteLine();
            Console.WriteLine("Id Number ||  Item  >>>>>>  Status");
            Console.WriteLine("---------------------------------------");
            app.PrintAll();
        }
    }
}