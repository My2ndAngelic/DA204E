namespace BackendLibrary
{
    public partial class TicTacToe
    {
        private static int evaluate(string?[,] b, string player, string opponent)
        {
            // Checking for Rows for X or O victory.
            for (int row = 0; row < 3; row++)
            {
                if (b[row, 0] != b[row, 1] || b[row, 1] != b[row, 2]) continue;
                if (b[row, 0] == player)
                    return +10;
                if (b[row, 0] == opponent)
                    return -10;
            }

            // Checking for Columns for X or O victory.
            for (int col = 0; col < 3; col++)
            {
                if (b[0, col] != b[1, col] || b[1, col] != b[2, col]) continue;
                if (b[0, col] == player)
                    return +10;

                if (b[0, col] == opponent)
                    return -10;
            }

            // Checking for Diagonals for X or O victory.
            if (b[0, 0] == b[1, 1] && b[1, 1] == b[2, 2])
            {
                if (b[0, 0] == player)
                    return +10;
                if (b[0, 0] == opponent)
                    return -10;
            }

            if (b[0, 2] != b[1, 1] || b[1, 1] != b[2, 0]) return 0;
            if (b[0, 2] == player)
                return +10;
            if (b[0, 2] == opponent)
                return -10;

            // Else if none of them have won then return 0
            return 0;
        }

        private int[] findBestMove(string?[,] board)
        {
            int bestVal = -1000;
            int[] bestMove = new int[2];
            bestMove[0] = -1;
            bestMove[0] = -1;

            string player, opponent;
            if (p1Name == "Computer")
            {
                player = p1Symbol;
                opponent = p2Symbol;
            }
            else
            {
                player = p2Symbol;
                opponent = p1Symbol;
            }

            // Traverse all cells, evaluate minimax function
            // for all empty cells. And return the cell
            // with optimal value.
            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
            {
                // Check if cell is empty
                if (board[i, j] != null) continue;
                // Make the move
                board[i, j] = player;

                // compute evaluation function for this
                // move.
                int moveVal = minimax(board, 0, false);

                // Undo the move
                board[i, j] = null;

                // If the value of the current move is
                // more than the best value, then update
                // best/
                if (moveVal <= bestVal) continue;
                bestMove[0] = i;
                bestMove[1] = j;
                bestVal = moveVal;
            }

            return bestMove;
        }

        private static bool isMovesLeft(string?[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            for (int j = 0; j < board.GetLength(0); j++)
                if (board[i, j] == null)
                    return true;
            return false;
        }

        private int minimax(string?[,] board,
            int depth, bool isMax)
        {
            string player, opponent;
            if (p1Name == "Computer")
            {
                player = p1Symbol;
                opponent = p2Symbol;
            }
            else
            {
                player = p2Symbol;
                opponent = p1Symbol;
            }

            int score = evaluate(board, player, opponent);

            switch (score)
            {
                // If Maximizer has won the game
                // return his/her evaluated score
                case 10:
                    return score;
                // If Minimizer has won the game
                // return his/her evaluated score
                case -10:
                    return score;
            }

            // If there are no more moves and
            // no winner then it is a tie
            if (isMovesLeft(board) == false)
                return 0;

            // If this maximizer's move
            if (isMax)
            {
                int best = -1000;

                // Traverse all cells
                for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != null) continue;
                    // Make the move
                    board[i, j] = player;

                    // Call minimax recursively and choose
                    // the maximum value
                    best = Math.Max(best, minimax(board,
                        depth + 1, !isMax));

                    // Undo the move
                    board[i, j] = null;
                }

                return best;
            }

            // If this minimizer's move
            else
            {
                int best = 1000;

                // Traverse all cells
                for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] != null) continue;
                    // Make the move
                    board[i, j] = opponent;

                    // Call minimax recursively and choose
                    // the minimum value
                    best = Math.Min(best, minimax(board,
                        depth + 1, !isMax));

                    // Undo the move
                    board[i, j] = null;
                }

                return best;
            }
        }

        /// <summary>
        ///     This code is copied from GeeksForGeeks line by line for testing purpose.
        ///     Source: https://www.geeksforgeeks.org/minimax-algorithm-in-game-theory-set-3-tic-tac-toe-ai-finding-optimal-move/
        /// </summary>
        /// <returns></returns>
        public int[] MinimaxMove()
        {
            return findBestMove(board);
        }
    }
}