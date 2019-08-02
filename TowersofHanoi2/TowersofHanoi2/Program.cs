using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersofHanoi2
{
    class Program
    {
        public static Dictionary<string, Stack<int>> Board;

        static void Main(string[] args)
        {
            Board = new Dictionary<string, Stack<int>>(); // needs paranthesis because it is running constructor function
            Board.Add("A", new Stack<int>());
            Board.Add("B", new Stack<int>());
            Board.Add("C", new Stack<int>());
            Board["A"].Push(3);  // this is now considered a stack...this is a "pez" dispenser imagine the towers as that we're pushing 3 first, because it is last
            Board["A"].Push(2);
            Board["A"].Push(1);
            

            while (Board["C"].Count < 3)
            {
                PrintBoard();
                Console.WriteLine("From?");
                string from = Console.ReadLine();
                Console.WriteLine("To?");
                string to = Console.ReadLine();
                Move(from, to);

            }
            Console.WriteLine("You Win!!!");


            Console.ReadLine();



        }
        public static void PrintBoard() // functions always have parantheses...you don't need parantheses in aray.length bc its not a function its just a value in that file
        {
            Console.WriteLine(); //this makes the program go to a new line
            Console.Write("A ");
            int[] A = Board["A"].ToArray(); // this converts the stack to an array ...we're making the stack run the toarray function we need a reverse for loop
            for (int i = A.Length -1; i >= 0; i--) // length is bigger than the last index so we need to use -1 and we use i -- because we need to access the items backwards..now it is a reverse looop
            {
                Console.Write(A[i] +" ");
            }
            Console.WriteLine();
            Console.Write("B ");
            A = Board["B"].ToArray(); // this converts the stack to an array ...we're making the stack run the toarray function we need a reverse for loop
            for (int i = A.Length - 1; i >= 0; i--) // length is bigger than the last index so we need to use -1 and we use i -- because we need to access the items backwards..now it is a reverse looop
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.Write("C ");
            A = Board["C"].ToArray(); // this converts the stack to an array ...we're making the stack run the toarray function we need a reverse for loop
            for (int i = A.Length - 1; i >= 0; i--) // length is bigger than the last index so we need to use -1 and we use i -- because we need to access the items backwards..now it is a reverse looop
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine(); //input is on a new line
        }
        public static void Move(string from, string to) // inside the parantheses we have parameters which gives the function information it needs, to and from represent which cone you are moving a disk to and from
        {
            if (Board[to].Count == 0 || Board[from].Peek() < Board[to].Peek()) // this is saying the top one where were trying to move form is greater than the one we're trying to move to, if this if statement evaluates to true then it would be an illegal move
            {
                Board[to].Push(Board[from].Pop());  // so we need Board[to].count so C# knows to check if the move is possible 
            }
            else
            {
                Console.WriteLine("Invalid Move!");
            }
        }

    }


}
