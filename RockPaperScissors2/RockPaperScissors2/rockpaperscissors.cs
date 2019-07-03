using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hi Welcome to paper rock or scissors! Please press enter to continue or stop to end the program");
                string word = Console.ReadLine();
                if (word == "stop")
                {
                    break;
                }
                else
                {
                    rockpaperscissors();
                }
            }
                Console.ReadLine();
        }
        public static void rockpaperscissors()
        {
            Console.WriteLine("Please choose rock, paper or scissors");
            string userChoice = Console.ReadLine();
            Random r = new Random();
            int computerChoice = r.Next(4);
            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock It is a tie! please press enter ");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper, it's a tie! press enter to continue");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors is a tie! press enter to continue");
                }
                else
                {
                    Console.WriteLine("You have choose rock, paper or scissors! press enter");
                }
            }
                else if (computerChoice == 2)
            {

                if (userChoice == "rock")
                {
                    Console.WriteLine("Sorry you lose, The computer chose paper which beats rock press enter ");


                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("Sorry you lose, the computer chose scissors which beat paper, press enter ");
                }

                else if (userChoice == "scissors")
                {
                    Console.WriteLine("Sorry you lose.The computer chose rock which beats scissors, press enter");
                }
                else
                {
                    Console.WriteLine("You must choose rock, paper or scissors! press enter");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    
                    Console.WriteLine("You win! The computer chose scissors which lose to rock, press enter");

                }
                else if (userChoice == "paper")
                {
                    
                    Console.WriteLine("You win, The computer chose rock which loses to paper, press enter");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("You win! The computer chose paper which loses to scissors, press enter");
                }
                else
                {
                    Console.WriteLine("You must choose rock, paper or scissors! press enter");

                }

            }

            Console.ReadLine();
        }
    }
}