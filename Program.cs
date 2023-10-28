using GameLogic;

namespace TicTacToe
{
    internal class Program
    {
        static Board game = new Board();

        static void Main(string[] args)
        {

            int player = -1;
            int computer = -1;
            Random random = new Random();




            Console.WriteLine("    ***Game Rules***");
            Console.WriteLine("************************");
            Console.WriteLine("* We have a 3x3 grid   *");
            Console.WriteLine("* grid is numbered 1-9 *");
            Console.WriteLine("* . means not occupied *");
            Console.WriteLine("* X = player 1         *");
            Console.WriteLine("* O = player 2 (cpu)   *");
            Console.WriteLine("************************");
            Console.WriteLine();


            ShowBoard();
            Console.WriteLine();

            while (game.CheckForWinner() == 0)
            {
                while (player == -1 || game.Grid[player - 1] != 0)
                {
                    Console.Write("\nWhat is your next move (1-9) ");

                    while (!int.TryParse(Console.ReadLine(), out player))
                    {
                        Console.Write("only number 1-9 ");
                    }
                }

                //marks player choice on the board
                game.Grid[player - 1] = 1;
                ShowBoard();
                if (game.IsBoardFull())
                {
                    break;
                }

                if (game.CheckForWinner() == 1)
                {
                    break;
                }

                Console.WriteLine();
                Console.WriteLine("computers turn ");

                while (computer == -1 || game.Grid[computer - 1] != 0)
                {
                    computer = random.Next(1, 10);
                }
                //marks computers random choice on the board
                game.Grid[computer - 1] = 2;
                ShowBoard();
                if (game.CheckForWinner() == 2)
                {
                    break;
                }
            }
            Console.WriteLine();
            if (game.CheckForWinner() == 0)
            {
                Console.WriteLine("Game over. It´s a draw!");
            }
            else if (game.CheckForWinner() == 1)
            {
                Console.WriteLine($"Game is over. Player 1 won!");
            }
            else
            {
                Console.WriteLine("Game over. Computer is the winner.");
            }



        }
        private static void ShowBoard()
        {
            for (int i = 0; i < game.Grid.Length; i++)
            {
                // player 1 is X, computer is O, unoccupied space is .
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }

                if (game.Grid[i] == 0)
                {
                    Console.Write(".");
                }
                else if (game.Grid[i] == 1)
                {
                    Console.Write("X");
                }
                else if (game.Grid[i] == 2)
                {
                    Console.Write("O");
                }



            }

        }




    }
}