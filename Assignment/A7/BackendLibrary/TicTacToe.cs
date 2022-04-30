using System.Text.RegularExpressions;

namespace BackendLibrary
{
    public class TicTacToe
    {
        private readonly string[,] board;
        private string currentPlayer;
        private bool gameOver;
        private string mode;
        private string winner;

        public TicTacToe()
        {
            mode = "PP";
            board = new string[3, 3];
            currentPlayer = "x";
            winner = "";
            gameOver = false;
        }

        public TicTacToe(string mode, string currentPlayer)
        {
            this.mode = mode;
            board = new string[3, 3];
            this.currentPlayer = currentPlayer.ToLower() is "x" or "o" ? currentPlayer.ToLower() : "x";
            winner = "";
            gameOver = false;
        }

        public TicTacToe(string board)
        {
            string[] boardData = board.Split('|');
            mode = boardData[0];
            this.board = new string[3, 3];
            if (!SetBoard(boardData[1])) throw new Exception("Invalid board data");
            currentPlayer = "";
            CheckForWinner();
        }

        public string Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public string[,] Board
        {
            get { return board; }
            init { board = value; }
        }

        public string CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public string Winner
        {
            get { return winner; }
            set { winner = value; }
        }

        public bool GameOver
        {
            get { return gameOver; }
            set { gameOver = value; }
        }


        public void Play(int row, int col)
        {
            if (board[row, col] == string.Empty)
            {
                board[row, col] = currentPlayer;
                currentPlayer = currentPlayer == "x" ? "o" : "x";
            }
            else
            {
                throw new Exception("Invalid move");
            }
        }

        public void CheckForWinner()
        {
            // Check rows
            for (int i = 0; i < 3; i++)
                if (board[i, 0] != string.Empty && board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    winner = board[i, 0];
                    gameOver = true;
                }

            // Check columns
            for (int i = 0; i < 3; i++)
                if (board[0, i] != string.Empty && board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    winner = board[0, i];
                    gameOver = true;
                }

            // Check diagonals
            if (board[0, 0] != string.Empty && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                winner = board[0, 0];
                gameOver = true;
            }

            if (board[0, 2] != string.Empty && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                winner = board[0, 2];
                gameOver = true;
            }
        }

        private string BoardToFile()
        {
            return Regex.Replace(Utilities.Arrays.DeepToString(board), "[\\s\\[\\]\\,]", "")
                    .Replace("null", "a");
        }

        public static bool CheckBoard(string boardData)
        {
            return Regex.IsMatch(boardData, "^[aoxAOX]{9}$");
        }

        public bool SetBoard(string boardData)
        {
            if (!CheckBoard(boardData))
                return false;

            string[] boardArray = boardData.Chunk(1).Select(x => new string(x)).ToArray();
            for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (boardArray[i * 3 + j].Equals("a"))
                    board[i, j] = null;
                else
                    board[i, j] = boardArray[i * 3 + j];
            CheckForWinner();
            return true;
        }

        public string ToStringFile()
        {
            return $"{mode}|{BoardToFile()}";
        }
    }
}