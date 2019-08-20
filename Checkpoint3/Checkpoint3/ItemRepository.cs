using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Checkpoint3
{
    class ItemRpository        // between the app class and the database
    {
        ToDosContext context = new ToDosContext();
        public ItemRpository()
        {
        }
        // add item
        public void Add(ToDo Add)
        {
            context.Database.EnsureCreated();
            context.ToDos.Add(Add);
            context.SaveChanges();
        }

        public void Change(int cng)
        {
            ToDo change;
            foreach (ToDo c in context.ToDos)
            {
                if (c.Id == cng)
                {
                    change = context.ToDos.First(i => i.Id == cng);

                    if (change.Status == "Pending")
                    {
                        change.Status = "Done";
                    }
                    else
                    {
                        change.Status = "Pending";
                    }
                }
                else
                {
                }
            }
            context.SaveChanges();
        }

        public void DelItem(int del)
        {
            ToDo delet;
            foreach (ToDo c in context.ToDos)
            {
                if (c.Id == del)
                {
                    delet = context.ToDos.First(i => i.Id == del);
                    context.ToDos.Remove(delet);
                }
                else
                {
                }
            }
            context.SaveChanges();
        }

        public void PendingTable()
        {
            Console.WriteLine("      All Pending Items");
            Console.WriteLine();

            foreach (ToDo s in context.ToDos)
            {
                if (s.Status == "Pending")
                {
                    Console.WriteLine("{0}        || {1} >>>>>>> {2}",
                                        s.Id, s.Item, s.Status);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public void DoneTable()
        {
            Console.WriteLine("      All Done Items");
            Console.WriteLine();
            foreach (ToDo s in context.ToDos)
            {
                if (s.Status == "Done")
                {
                    Console.WriteLine("{0}        || {1} >>>>>>> {2}",
                                        s.Id, s.Item, s.Status);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
        }

        public void Table()
        {
            foreach (ToDo s in context.ToDos)
            {
                Console.WriteLine("{0}        || {1} >>>>>>> {2}",
                                        s.Id, s.Item, s.Status);
            }
        }
    }
}