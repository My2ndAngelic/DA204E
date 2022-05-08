namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public int[] RandomComputerMove()
        {
            Random r = new Random();
            int x = -1;
            int y = -1;
            if (IsGameOver())
                return new int[] {x, y};
            do
            {
                x = r.Next(boardSize);
                y = r.Next(boardSize);
            } while (!IsValidMove(x, y));

            return new int[] {x, y};
        }

        public int[] OldRandomComputerMove()
        {
            Random r = new Random();
            int x = -1;
            int y = -1;
            if (IsGameOver())
                return new int[] {x, y};
            bool moveMade;
            do
            {
                x = r.Next(boardSize);
                y = r.Next(boardSize);
                moveMade = Move(x, y);
            } while (!moveMade);

            return new int[] {x, y};
        }

        public int[] MinimaxMove()
        {
            return new int[] {-69, -420};
        }
    }
}