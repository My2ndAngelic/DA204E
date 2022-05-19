namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public (int row, int column) RandomComputerMove()
        {
            Random r = new Random();
            int row, column;
            if (IsGameOver())
                return (-1, -1);
            do
            {
                row = r.Next(boardSize);
                column = r.Next(boardSize);
            } while (!IsValidMove(row, column));

            return (row, column);
        }

        // There is a TicTaxToe.Computer.Minimax.cs file but it is copied code from G4G so it is not suitable for submission
    }
}