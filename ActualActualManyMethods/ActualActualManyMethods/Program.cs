using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manymethods
{
    public class Program
    {
        public static void Main(string[] args)
        {
            hello();
            addition();
            catDog();
            oddEvent();
            inches();
            echo();
            KillGrams();
            date();
            age();
            guess();
            Console.ReadKey();
        }
        public static void hello()
        {
            string name;
            Console.WriteLine("Hello! Please enter your name.");
            name = Console.ReadLine();
            Console.WriteLine("Bye " + name);
        }
        public static void addition()
        {
            Console.WriteLine("Please enter your first number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            int sum = (numberOne + numberTwo);
            Console.WriteLine("Your sum is " + sum);

        }
        public static void catDog()
        {
            Console.WriteLine("Do you prefer cats or dogs?");
            string animal;
            animal = Console.ReadLine();
            if (animal == "cats")
            {
                Console.WriteLine("Meow!");
            }
            else if (animal == "dogs")
            {
                Console.WriteLine("Bark!");
            }
            else
            {
                Console.WriteLine("You did not enter cats or dogs");
            }
        }
        public static void oddEvent()
        {
            Console.WriteLine("Please enter a number");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
        }
        static void inches()
        {
            int feet;
            int inches;
            Console.WriteLine("Please enter your height in feet");
            feet = Convert.ToInt32(Console.ReadLine());
            inches = (feet * 12);
            Console.WriteLine($"Your height in inches is {inches}");


        }
        static void echo()
        {
            Console.WriteLine("Whoa! Do you hear that echo??");
            string echo = Console.ReadLine();
            Console.WriteLine(echo.ToUpper());
            Console.WriteLine(echo.ToLower());
            Console.WriteLine(echo.ToLower());


        }
        static void KillGrams()
        {
            int pounds;
            int kilograms;
            Console.WriteLine("Hi there, please enter your weight in pounds");
            pounds = Convert.ToInt32(Console.ReadLine());
            kilograms = (int)(0.45359237 * (Double)pounds);
            Console.WriteLine("Your weight in kilograms is " + kilograms);
        }
        static void date()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
        }
        static void age()
        {
            int birthyear;
            int age;
            Console.WriteLine("Hi, Please enter your birth year");
            birthyear = Convert.ToInt32(Console.ReadLine());
            age = DateTime.Today.Year - birthyear;
            Console.WriteLine("Your age is " + age);


        }
        static void guess()
        {
            string guess;
            Console.WriteLine("Can you guess my word?");
            guess = Console.ReadLine();
            if (guess == "csharp")
            {
                Console.WriteLine("CORRECT!");
            }
            else Console.WriteLine("WRONG!");
        }
    }
}
