namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public bool Move(int x, int y)
        {
            string symbol = "";
            switch (currentPlayer)
            {
                case 0:
                    symbol = p1Symbol;
                    break;
                case 1:
                    symbol = p2Symbol;
                    break;
                default:
                    return false;
            }
            string[] move = {symbol, x.ToString(), y.ToString()};
            if (!IsValidMove(move) || IsGameOver()) return false;
            int row = int.Parse(move[1]);
            int col = int.Parse(move[2]);
            endTime = DateTime.Now;
            currentPlayer = (currentPlayer + 1) % 2;
            board[row, col] = symbol;
            turnHistory.Add(string.Join('-', move));
            boardHistory.Add(board);
            return true;
        }
    }
}