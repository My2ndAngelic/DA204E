namespace BackendLibrary
{
    public partial class TicTacToe
    {
        // There is a TicTaxToe.Computer.Minimax.cs file but it is copied code from G4G so it is not suitable for submission

        /// <summary>
        ///     Randomize a move from computer
        /// </summary>
        /// <returns>Integer array representing the coordinate of the move</returns>
        public int[] RandomComputerMoveIntegerArray()
        {
            if (IsGameOver())
                return new int[] {-1, -1};
            Random r = new Random();
            int row, column;
            do
            {
                row = r.Next(boardSize);
                column = r.Next(boardSize);
            } while (!IsValidMove(row, column));

            return new int[] {row, column};
        }

        /// <summary>
        ///     Randomize a move from computer
        /// </summary>
        /// <returns>Tuple of integers representing the coordinate of the move</returns>
        public (int, int) RandomComputerMoveIntegerTuple()
        {
            if (IsGameOver())
                return (-1, -1);
            Random r = new Random();
            int row, column; // For now it is integers, long is only good if you have bigger board.
            do
            {
                row = r.Next(boardSize);
                column = r.Next(boardSize);
            } while (!IsValidMove(row, column));

            return (row, column);
        }
    }
}