using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static string[,] board = new string[3, 3]; //global variable because above main//
        static bool xturn = true;
        static bool gameRunning = true;
        static string winner;
        static void Main(string[] args)
        {
            initializeboard();

            while (gameRunning)
            {
                printboard();
                Console.WriteLine("Enter your column row...one number space other number...");
                string input = Console.ReadLine();
                string[] vals = input.Split(' ');
                move(Convert.ToInt32(vals[0]), Convert.ToInt32(vals[1]));
                isgameover();
            }
            printboard();
            Console.WriteLine("Winner is " + winner);
            
            Console.ReadLine();
        }
        static void initializeboard()
        {
            for (int i = 0; i<3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    board[i, j] = " ";
                }
            }
        }
        static void printboard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("["+board[i,j]+"]");
                }
                Console.WriteLine();
            }

        }
        static void move(int row, int col)
        {
            if (board[col, row] == " ")
            {
                if (xturn)
                {
                    board[col, row] = "x";

                }
                if (!xturn)
                {
                    board[col, row] = "o";
                }
                xturn = !xturn;
            }
        }
        static void isgameover()
        {
            int count;
            //check rows
            for (int i = 0; i < 3; i++)
            {
                count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if(board[i,j] == "x")
                    {
                        count++;
                    }
                    if(board[i,j] == "o")
                    {
                        count--;
                    }
                }
                if (count == 3)
                {
                    gameRunning = false;
                    winner = "x";
                }
                if (count == -3)
                {
                    gameRunning = false;
                    winner = "o";
                }
            }
            //check cols
            for (int i = 0; i < 3; i++)
            {
                count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (board[j, i] == "x")
                    {
                        count++;
                    }
                    if (board[j, i] == "o")
                    {
                        count--;
                    }
                }
                if (count == 3)
                {
                    gameRunning = false;
                    winner = "x";
                }
                if (count == -3)
                {
                    gameRunning = false;
                    winner = "o";
                }
            }

            if (board [0,0] != " " && board[0,0] == board[1,1] && board[1,1] == board[2, 2])
            {
                if (board[0, 0] == "x")
                {
                    gameRunning = false;
                    winner = "x";
                }
                if (board[0,0] == "o")
                {
                    gameRunning = false;
                    winner = "o";
                }
            }
            if (board[2, 0] != " " && board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                if (board[2, 0] == "x")
                {
                    gameRunning = false;
                    winner = "x";
                }
                if (board[2, 0] == "o")
                {
                    gameRunning = false;
                    winner = "o";
                }
            }
            count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != " ")
                    {
                        count++;
                    }
                }
            }
            if (count == 9)
            {
                gameRunning = false;
                winner = "tie";
            }

        }
    }
}
