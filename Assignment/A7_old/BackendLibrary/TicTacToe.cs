using System.Text;

namespace BackendLibrary
{
    public class TicTacToe
    {
        public string Mode
        {
            get;
            set;
        }

        public string[,] Board { get; set; }
        public string CurrentPlayer { get; set; }
        public string Winner { get; set; }
        public bool GameOver { get; set; }

        public TicTacToe()
        {
            Mode = "PP";
            Board = new string[3, 3];
            CurrentPlayer = "x";
            Winner = "";
            GameOver = false;
        }

        public TicTacToe(string mode, string currentPlayer)
        {
            Mode = mode;
            Board = new string[3, 3];
            CurrentPlayer = currentPlayer.ToLower() is "x" or "o" ? currentPlayer.ToLower() : "x";
            Winner = "";
            GameOver = false;
        }

        public TicTacToe(string board)
        {
            string[] boardData = board.Split('|');
            Mode = boardData[0];
            Board = new string[3, 3];
            if (!SetBoard(boardData[1]))
            {
                throw new Exception("Invalid board data");
            }
            CurrentPlayer = "";
            CheckForWinner();
        }
        
        public void Play(int row, int col)
        {
            if (Board[row, col] == string.Empty)
            {
                Board[row, col] = CurrentPlayer;
                CurrentPlayer = CurrentPlayer == "x" ? "o" : "x";
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
            {
                if (Board[i, 0] != string.Empty && Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2])
                {
                    Winner = Board[i, 0];
                    GameOver = true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (Board[0, i] == string.Empty || Board[0, i] != Board[1, i] || Board[1, i] != Board[2, i]) continue;
                Winner = Board[0, i];
                GameOver = true;
            }

            // Check diagonals
            if (Board[0, 0] != string.Empty && Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2])
            {
                Winner = Board[0, 0];
                GameOver = true;
            }

            if (Board[0, 2] != string.Empty && Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0])
            {
                Winner = Board[0, 2];
                GameOver = true;
            }
        }

        private string BoardToFile()
        {
            StringBuilder result = new StringBuilder(Utilities.Arrays.DeepToString(Board));
            result.Replace("[", "").Replace("]", "").Replace(" ", "").Replace("string.Empty", "a").Replace(" ", "").Replace(",", "");
            return result.ToString();
        }

        public bool SetBoard(string boardData)
        {
            if (boardData.Length != 9)
            {
                return false;
            }

            string[] board = boardData.Chunk(1).Select(x => new string(x)).ToArray();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i * 3 + j].Equals("a"))
                    {
                        Board[i, j] = string.Empty;
                    }
                    else
                    {
                        Board[i, j] = board[i * 3 + j];
                    }
                }
            }
            CheckForWinner();
            return true;
        }
        public string ToStringFile()
        {
            return $"{Mode}|{BoardToFile()}";
        }
    }
}