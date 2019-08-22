using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Checkers
{
    public enum Color { White, Black }

    class Program
    {
        public static void Main(String[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Game Game = new Game();
            Game.Start();
            Console.ReadLine();
        }
    }

    public struct Position
    {
        public int Row { get; private set; }
        public int Collumn { get; private set; }
        public Position(int row, int col)
        {
            Row = row;
            Collumn = col;
        }
    }

    public class Checker
    {
        public string Symbol { get; private set; }
        public Position Position { get; set; }
        public Color Team { get; private set; }

        public Checker(Color team, int row, int col)
        {
            Team = team;
            if (team == Color.Black)
            {
                Symbol = char.ConvertFromUtf32(int.Parse("25CB", System.Globalization.NumberStyles.HexNumber));
                
            }
            else
            {
                Symbol = char.ConvertFromUtf32(int.Parse("25CF", System.Globalization.NumberStyles.HexNumber));
                
            }
            Position = new Position(row, col);
        }
    }

    public class Board
    {
        public List<Checker> Checkers { get; private set; }

        public Board()
        {
            Checkers = new List<Checker>();
            for (int a = 0; a < 3; a++)
            {
                for (int i = 0; i < 8; i += 2)
                {
                    Checker b = new Checker(Color.White, a, (a + 1) % 2 + i);
                    Checkers.Add(b);
                }
                for (int i = 0; i < 8; i += 2)
                {
                    Checker b = new Checker(Color.Black, (a + 5), a % 2 + i);
                    Checkers.Add(b);
                }
            }
        }

        public Checker GetChecker(Position pos)
        {
            Checker found = null;
            foreach (Checker b in Checkers)
            {
                if (pos.Equals(b.Position))
                {
                    found = b;
                    break;
                }
            }
            return found;
        }

        public void RemoveChecker(Checker checker)
        {
            if (checker != null)
            {
                Checkers.Remove(checker);
            }
        }

        public void MoveChecker(Checker checker, Position dest)
        {
            Checkers.Remove(checker);
            checker.Position = dest;
            Checkers.Add(checker);
        }
    }

    public class Game
    {
        private Board board;
        private Color Turn = Color.Black;

        public Game()
        {
            board = new Board();
        }

        public bool CheckForWin()
        {
            return (board.Checkers.All(x => x.Team == Color.White) ||
                board.Checkers.All(x => x.Team == Color.Black));
        }


        public void Start()
        {
            while (!CheckForWin())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Enter your move");
                Console.WriteLine("Start Column, Start Row, Destination" +
                    " Column, Destination Row");
                string Move = Console.ReadLine();

                string[] coord = Move.Split(',');

                Checker checker = new Checker(Turn, Int32.Parse(coord[1]), Int32.Parse(coord[0]));
                Position src = new Position(Int32.Parse(coord[1]), Int32.Parse(coord[0]));
                Position dest = new Position(Int32.Parse(coord[3]), Int32.Parse(coord[2]));
                if (IsLegalMove(checker, src, dest))
                {
                    board.MoveChecker(checker, dest);
                    var result = Turn == Color.Black ? Turn = Color.White : Turn = Color.Black;
                }
            }
            
        }

        public bool IsLegalMove(Checker checker, Position src, Position dest)
        {
            if (checker == null)
            {
                return false;
            }
            if (checker.Team != Turn)
            {
                return false;
            }

            int a = dest.Row;
            int b = dest.Collumn;
            return true;
        }

        public void DrawBoard()
        {
            string[][] grid = new string[8][];
            for (int a = 0; a < 8; a++)
            {
                grid[a] = new string[8];
                for (int b = 0; b < 8; b++)
                {
                    grid[a][b] = " ";
                }
            }
            foreach (Checker b in board.Checkers)
            {
                grid[b.Position.Row][b.Position.Collumn] = b.Symbol;
            }

            Console.WriteLine("  0 1 2 3 4 5 6 7");
            for (int a = 0; a < 8; a++)
            {
                Console.Write(a);
                for (int c = 0; c < 8; c++)
                {
                    Console.Write(" {0}", grid[a][c]);
                }
                Console.WriteLine();
            }
        }

    }
}