using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ToDoItems
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, DateTime> List = new Dictionary<string, DateTime>();
            Console.WriteLine("Please enter your to do item or type 'end'. ");
            string DoItem = Convert.ToString(Console.ReadLine());
            ToDoItem first = new ToDoItem();
            first.Description = "0";
            first.DueDate = new DateTime();
            first.Priority = 1;
            string priority = "high priority";

                while (DoItem != "end")
                {
                Console.WriteLine("Please enter the due date for your to do item in the format mm/dd/yyyy: ");
                try
                {
                    first.DueDate = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Almost! try again in the correct format: " +
                        "mm/dd/yyyy ");
                    continue;
                }
                Console.WriteLine("Please enter your priority level; 1 for high, " +
                    "2 for normal & 3 for low. If you do not enter a number the priority will automatically be set to high");
                try
                {
                    first.Priority = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    first.Priority = 1;
                    Console.WriteLine("Your priority has been set to high ");
                }
                if (first.Priority == 1)
                {
                    priority = "high priority";
                }
                else if (first.Priority == 2)
                {
                    priority = "normal priority";
                }
                else if (first.Priority == 3)
                {
                    priority = "low priority";
                }
                else
                {
                    Console.WriteLine();

                    try
                    {
                        first.Priority = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        first.Priority = 1;
                        Console.WriteLine("Priority has been set to high ");
                    }
                }


                    first.Description = priority + ":    " + DoItem;
                List.Add(first.Description, first.DueDate);

                Console.WriteLine("Please enter a to do item name or type 'end'. ");
                DoItem = Convert.ToString(Console.ReadLine());

            }

            foreach (KeyValuePair<string, DateTime> item in List)
            {
                string due = item.Value.ToString("t");
                Console.WriteLine("Due by {0}:      {1}", due, item.Key);
            }
            Console.ReadKey();
         }
    }
        public class ToDoItem
        {
            public String Description;
            public DateTime DueDate;
            public int Priority;
        }
}