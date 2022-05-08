namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public bool Move(int x, int y)
        {
            if (IsGameOver() || !IsValidMove(x, y)) return false;
            string symbol;
            BeginSwitchCurrentPlayer:
            switch (currentPlayer)
            {
                case 0:
                    symbol = p1Symbol;
                    break;
                case 1:
                    symbol = p2Symbol;
                    break;
                default:
                    currentPlayer %= 2; 
                    goto BeginSwitchCurrentPlayer;
            }

            currentPlayer++;
            board[x, y] = symbol;
            turnHistory.Add(string.Join('-', symbol, x.ToString(), y.ToString()));
            boardHistory.Add(board);
            if (turnHistory.Count == 0)
                startTime = DateTime.Now;
            endTime = DateTime.Now;
            return true;
        }
    }
}