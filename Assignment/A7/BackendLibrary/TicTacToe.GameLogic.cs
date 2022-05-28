namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public string GetWinner()
        {
            string winner = string.Empty;
            if (IsWinner(p1Symbol))
                winner = p1Name;
            else if (IsWinner(p2Symbol))
                winner = p2Name;
            else if (IsFilled())
                winner = "No one";

            return winner;
        }

        /// <summary>
        ///     Find the non-empty cells in the board
        /// </summary>
        /// <returns>True if there is no empty cell, false otherwise</returns>
        public bool IsFilled()
        {
            for (int i = 0; i < boardSize; i++)
            for (int j = 0; j < boardSize; j++)
                if (board[i, j] is null)
                    return false;
            return true;
        }

        /// <summary>
        ///     Check if game is over
        /// </summary>
        /// <returns>True if game over</returns>
        public bool IsGameOver()
        {
            return !string.IsNullOrEmpty(GetWinner());
        }

        /// <summary>
        ///     Check if move is valid
        /// </summary>
        /// <param name="move">
        ///     Move description in string
        ///     Format: Symbol-Row-Column
        /// </param>
        /// <returns>True if valid</returns>
        public bool IsValidMove(string move)
        {
            return IsValidMove(move.Split("-"));
        }

        /// <summary>
        ///     Check if move is valid
        /// </summary>
        /// <param name="move">
        ///     Move description in string
        ///     Format: Symbol-Row-Column
        /// </param>
        /// <returns>True if valid</returns>
        public bool IsValidMove(string[] move)
        {
            return int.TryParse(move[1], out int row) && int.TryParse(move[2], out int column) &&
                   IsValidMove(row, column);
        }

        /// <summary>
        ///     Check if move is valid
        /// </summary>
        /// <param name="row">Row of move</param>
        /// <param name="column">Column of move</param>
        /// <returns>True if valid</returns>
        public bool IsValidMove(int row, int column)
        {
            return string.IsNullOrEmpty(board[row, column]);
        }

        /// <summary>
        ///     Check if particular symbol wins
        /// </summary>
        /// <param name="symbol">Symbol needed to check</param>
        /// <returns>True if winner</returns>
        public bool IsWinner(string symbol)
        {
            bool winner = false;
            // Check rows
            for (int i = 0; i < boardSize; i++)
            for (int j = 0; j < boardSize; j++)
            {
                if (board[i, j] != symbol) break;

                if (j == boardSize - 1) winner = true;
            }

            // Check columns
            for (int i = 0; i < boardSize; i++)
            for (int j = 0; j < boardSize; j++)
            {
                if (board[j, i] != symbol) break;

                if (j == boardSize - 1) winner = true;
            }

            // Check diagonals left to right
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, i] != symbol) break;

                if (i == boardSize - 1) winner = true;
            }

            // Check diagonals right to left
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, boardSize - 1 - i] != symbol) break;

                if (i == boardSize - 1) winner = true;
            }

            return winner;
        }

        /// <summary>
        ///     Move symbol to position
        /// </summary>
        /// <param name="move">
        ///     Move data
        ///     Format: Symbol-Row-Column
        /// </param>
        /// <returns>True if move is valid</returns>
        public bool Move(string move)
        {
            return Move(move.Split("-"));
        }

        /// <summary>
        ///     Move symbol to position
        /// </summary>
        /// <param name="move">Move data</param>
        /// <returns>True if move is valid</returns>
        public bool Move(string[] move)
        {
            if (!IsValidMove(move) || IsGameOver()) return false;
            string symbol = move[0];
            int row = int.Parse(move[1]);
            int col = int.Parse(move[2]);
            endTime = DateTime.Now;

            board[row, col] = symbol;
            turnHistory.Add(string.Join("-", move));
            ;
            boardHistory.Add(board);
            if (turnHistory.Count == 0)
                startTime = DateTime.Now;
            endTime = DateTime.Now;
            return true;
        }

        /// <summary>
        ///     Undo last move
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>True if successful</returns>
        public bool UndoMove(int row, int column)
        {
            if (row < 0 || row > boardSize || column < 0 || column > boardSize ||
                string.IsNullOrEmpty(board[row, column]))
                return false;
            board[row, column] = null;
            turnHistory.RemoveAt(turnHistory.Count - 1);
            boardHistory.RemoveAt(boardHistory.Count - 1);
            return true;
        }
    }
}