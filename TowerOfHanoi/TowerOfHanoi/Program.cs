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
            Stack<int> x = new Stack<int>();
            x.Push(4);
            x.Push(3);
            x.Push(2);
            x.Push(1);
            Stack<int> y = new Stack<int>();
            Stack<int> z = new Stack<int>();
            string from;
            string to;

            int[] win = new int[] { 1, 2, 3, 4 };

            bool play = false;

            while (play == false)
            {

                
                printgame(x.ToArray(), y.ToArray(), z.ToArray());
                

                Console.WriteLine("Hi! Welcome to Tower of Hanoi! Pick a disk represented by a number on a rod: X, Y, or Z to move from. The right most number on the rod will be moved, and a larger number cannot be moved to the right of a smaller number.");
                from = Console.ReadLine().ToLower();
                Console.WriteLine();
                Console.WriteLine("Pick a disk represented by a number from a rod: X, Y, or Z to move to. The right most number on the rod will be moved, and a larger number cannot be moved to the right of a smaller number.");
                to = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (from == "x")
                {
                    if (x.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "y")
                    {
                        if (y.Count == 0 || y.Peek() > x.Peek())
                        {
                            y.Push(x.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "z")
                    {
                        if (z.Count == 0 || z.Peek() > x.Peek())
                        {
                            z.Push(x.Pop());
                            
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.WriteLine();
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (from == "y")
                {
                    if (y.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "x")
                    {
                        if (x.Count == 0 || x.Peek() > y.Peek())
                        {
                            x.Push(y.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "z")
                    {
                        if (z.Count == 0 || z.Peek() > y.Peek())
                        {
                            z.Push(y.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else if (from == "z")
                {
                    if (z.Count == 0)
                    {
                        continue;
                    }
                    else if (to == "x")
                    {
                        if (x.Count == 0 || x.Peek() > z.Peek())
                        {
                            x.Push(z.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else if (to == "y")
                    {
                        if (y.Count == 0 || y.Peek() > z.Peek())
                        {
                            y.Push(z.Pop());
                        }
                        else
                        {
                            Console.WriteLine("You have entered incorrect input!");
                            Console.WriteLine("Press any key to continue.");
                            Console.WriteLine();
                            Console.ReadKey();
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You have entered incorrect input!");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("You have entered incorrect input!");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    continue;
                }
                if (z.Count == 4)
                {
                    Console.WriteLine("You Win!");
                    play = true;
                    break;
                }

            }
            Console.WriteLine("");
            Console.ReadKey();
        }

        public static void printgame(int[] x, int[] y, int[] z)
        {
            Console.Write("X: ");
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Y: ");
            for (int i = y.Length - 1; i >= 0; i--)
            {
                Console.Write(y[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Z: ");
            for (int i = z.Length - 1; i >= 0; i--)
            {
                Console.Write(z[i] + " ");
            }
            Console.WriteLine();
        }
    }
}