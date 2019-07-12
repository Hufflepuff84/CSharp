using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook
{
    class Program
    {
        static Dictionary<string, int[]> gradebook = new Dictionary<string, int[]>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hi! Welcome to Gradebook! Please Enter your name or type \"stop\"");
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                Console.WriteLine("Please enter all of your grades each separated by a space");
                string inputgrades = Console.ReadLine();
                string[] stringrades = inputgrades.Split(' '); //this converts a string into a string array separated by spaces
                int[] grades = new int[stringrades.Length];
                for (int i = 0; i < stringrades.Length; i++)
                {
                    grades[i] = Convert.ToInt32(stringrades[i]);
                }

                gradebook.Add(name, grades);


            }
            foreach (KeyValuePair<string, int[]> student in gradebook)
            {
                Console.WriteLine(student.Key);
                Console.WriteLine($"Highest grade is {highest(student.Value)}");// the $ tells it that we are using STRING interpolation
                Console.WriteLine($"Lowest grade is {lowest(student.Value)}");
                Console.WriteLine($"Average grade is {average(student.Value)}");
                
            }
            Console.ReadLine();
        }
        public static int highest(int[] grades)
        {
            int high = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if(grades[i] > high)
                {
                    high = grades[i];
                    
                }
            }
            return high;
        }
        public static int lowest(int[] grades)
        {
            int low = 100;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < low)
                {
                    low = grades[i];

                }
            }
            return low;
        }
        public static int average(int[] grades)
        {
            int average = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
            }
            average = average / grades.Length;
            return average;
        }
    }
}
