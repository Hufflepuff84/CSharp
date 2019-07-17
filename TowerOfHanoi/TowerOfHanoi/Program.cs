using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TowerofHanoi
{
    class Program
    {
        public static void Main(string[] args)
        {
            

            Stack<int> a = new Stack<int>();
            a.Push(4);
            a.Push(3);
            a.Push(2);
            a.Push(1);
            Stack<int> b = new Stack<int>();
            Stack<int> c = new Stack<int>();

            string from;
            string to;

            int[] win = new int[] { 1, 2, 3, 4 };

            bool play = false;

            while (play == false)
            {
                Console.Clear();

                printGame(a, b, c);

                Console.WriteLine("Pick a cone: A, B, or C to move from.");
                from = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine("Pick a cone: A, B, or C to move to.");
                to = Console.ReadLine().ToLower();

                Console.WriteLine();
                Console.WriteLine();

                if (from == "a")
                {
                    if (a.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "b")
                    {
                        if (b.Count == 0 || b.Peek() > a.Peek())
                        {
                            b.Push(a.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "c")
                    {
                        if (c.Count == 0 || c.Peek() > a.Peek())
                        {
                            c.Push(a.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (from == "b")
                {
                    if (b.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "a")
                    {
                        if (a.Count == 0 || a.Peek() > b.Peek())
                        {
                            a.Push(b.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "c")
                    {
                        if (c.Count == 0 || c.Peek() > b.Peek())
                        {
                            c.Push(b.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (from == "c")
                {
                    if (c.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "a")
                    {
                        if (a.Count == 0 || a.Peek() > c.Peek())
                        {
                            a.Push(c.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "b")
                    {
                        if (b.Count == 0 || b.Peek() > c.Peek())
                        {
                            b.Push(c.Pop());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Input!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }

                // test for win
                int[] test1 = b.ToArray();
                if (test1.SequenceEqual(win))
                {
                    Console.WriteLine("WIN! Tower moved from A to C !!");
                    play = true;
                    break;
                }

                int[] test2 = c.ToArray();
                if (test2.SequenceEqual(win))
                {
                    Console.WriteLine("WIN! Tower moved from A to C !!");
                    play = true;
                    break;
                }

            }

            Console.WriteLine("");

            Console.ReadKey();
        }

        public static void printGame(Stack<int> a, Stack<int> b, Stack<int> c)
        {
            Console.Write("A  ");
            PrintStack(a);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("B  ");
            PrintStack(b);
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("C  ");
            PrintStack(c);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void PrintStack(Stack<int> a)
        {
            if (a.Count == 0)
                return;
            else
            {
                int x = a.Peek();
                a.Pop();
                PrintStack(a);
                Console.Write(x + " ");
                a.Push(x);
            }
        }
    }
}