namespace GameLogic
{
    public class Board
    {
        public int[] Grid { get; set; }

        public Board()
        {
            //set grid to 9 (3x3)
            Grid = new int[9];
            // we initialize and set the Grid to 0
            for (int i = 0; i < Grid.Length; i++)
            {
                Grid[i] = 0;
            }
        }

        public bool IsBoardFull()
        {
            // we asume the board is full
            bool isFull = true;

            // we loop the board, if board is not full we change bool to false.

            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == 0)
                {
                    isFull = false;
                }
            }

            return isFull;
        }

        public int CheckForWinner()
        {
            // return 0 for draw, 1 for player win, 2 for computer win
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[0] == Grid[1] && Grid[1] == Grid[2])
                {
                    return Grid[0];
                }
                else if (Grid[3] == Grid[4] && Grid[4] == Grid[5])
                {
                    return Grid[3];
                }
                else if (Grid[6] == Grid[7] && Grid[7] == Grid[8])
                {
                    return Grid[6];
                }
                else if (Grid[0] == Grid[3] && Grid[3] == Grid[6])
                {
                    return Grid[0];
                }
                else if (Grid[1] == Grid[4] && Grid[4] == Grid[7])
                {
                    return Grid[1];
                }
                else if (Grid[2] == Grid[5] && Grid[5] == Grid[8])
                {
                    return Grid[2];
                }
                else if (Grid[0] == Grid[4] && Grid[4] == Grid[8])
                {
                    return Grid[0];
                }
                else if (Grid[2] == Grid[4] && Grid[4] == Grid[6])
                {
                    return Grid[2];
                }


            }

            return 0;
        }

        public void ResetGame()
        {
            for (int i = 0; i < Grid.Length; i++)
            {
                Grid[i] = 0;
            }
        }
    }
}
