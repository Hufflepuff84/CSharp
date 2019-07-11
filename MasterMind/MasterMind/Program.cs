using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hi Welcome to MasterMind! Please press enter to continue or type 'stop' to end the program");
                string word = Console.ReadLine();
                if (word == "stop")
                {
                    break;
                }
                else
                {
                    masterminds();
                }
            }
            Console.ReadLine();
        }

        public static void masterminds()
        {
            string[] colors = { "Red", "Yellow", "Blue" };
            Console.WriteLine("Please chose two colors from Red, Yellow, and Blue with a space between them");
            string userchoice = Console.ReadLine();
            string[] choices = userchoice.Split(' ');
            Random r = new Random();
            int index1 = r.Next(0, 3);
            int index2 = r.Next(0, 3);
            string[] computerchoice = { colors[index1], colors[index2] };
            int firstnumber = 0; // this represents the situation where the user got the correct color but not the right order
            int secondnumber = 0; // this represents the correct color AND the correct position 
            // when the second number = 2 we're done
            while (secondnumber != 2)
            {
                firstnumber = 0;
                secondnumber = 0;
                if (computerchoice[0] == choices[0])
                {
                    secondnumber++;
                }
                if (computerchoice[1] == choices[1])
                {
                    secondnumber++;
                }
                if (computerchoice[0] == choices[1])
                {
                    firstnumber++;
                }
                if (computerchoice[1] == choices[0])
                {
                    firstnumber++;
                }
                Console.WriteLine($"{firstnumber}-{secondnumber}");
                if (secondnumber < 2)
                {
                    Console.WriteLine("Try again please!");
                    userchoice = Console.ReadLine();
                    choices = userchoice.Split(' ');
                }
                
            }
            Console.WriteLine("Congratulations, You Won!");
        }



           
    }
    }

