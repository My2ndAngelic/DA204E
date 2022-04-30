using System.Text;

namespace BackendLibrary
{
    public partial class TicTacToe
    {
        // String: "P1Name,P2Name,P1Symbol,P2Symbol | StartTime, EndTime | BoardSize | TurnHistory"
        public TicTacToe(string data)
        {
            string[] dataArray = data.Replace(" ", "").Split('|');
            string[] playerData = dataArray[0].Split(',');
            p1Name = playerData[0];
            p2Name = playerData[1];
            p1Symbol = playerData[2];
            p2Symbol = playerData[3];

            string[] timeData = dataArray[1].Split(',');
            startTime = DateTime.Parse(DateTimeOffset.FromUnixTimeSeconds(long.Parse(timeData[0])).ToString());
            endTime = DateTime.Parse(DateTimeOffset.FromUnixTimeSeconds(long.Parse(timeData[1])).ToString());

            boardSize = int.Parse(dataArray[2]);
            board = new string[boardSize, boardSize];

            turnHistory = dataArray[3].Split(",");
            boardArray = new List<string[,]>();
            foreach (string bData in turnHistory)
            {
                // Format: "Sym-Row-Col"
                string[] bDataArray = bData.Split('-');
                board[int.Parse(bDataArray[1]), int.Parse(bDataArray[2])] = bDataArray[0];
                boardArray.Add(board);
            }
        }

        public string GetWinner()
        {
            string winner = "";
            if (CheckForWinner(p1Symbol))
            {
                winner = p1Name;
            }
            else if (CheckForWinner(p2Symbol))
            {
                winner = p2Name;
            }
            else if (CheckForDraw())
            {
                winner = "Draw";
            }
            else
            {
                winner = "Invalid game";
            }

            return winner;
        }

        public bool CheckForWinner(string symbol)
        {
            bool winner = false;
            // Check rows
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[i, j] != symbol)
                    {
                        break;
                    }

                    if (j == boardSize - 1)
                    {
                        winner = true;
                    }
                }
            }

            // Check columns
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[j, i] != symbol)
                    {
                        break;
                    }

                    if (j == boardSize - 1)
                    {
                        winner = true;
                    }
                }
            }

            // Check diagonals left to right
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, i] != symbol)
                {
                    break;
                }

                if (i == boardSize - 1)
                {
                    winner = true;
                }
            }

            // Check diagonals right to left
            for (int i = boardSize - 1; i >= 0; i--)
            {
                if (board[i, i] != symbol)
                {
                    break;
                }

                if (i == 0)
                {
                    winner = true;
                }
            }

            return winner;
        }

        public bool CheckForDraw()
        {
            bool draw = false;
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if (board[i, j] is null)
                    {
                        break;
                    }

                    if (j == boardSize - 1)
                    {
                        draw = true;
                    }
                }
            }

            return draw;
        }

        public string BoardDisplay(string[,] board)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    result.Append(board[i, j] is null ? "-" : board[i, j]).Append(" | ");
                }

                result.Remove(result.Length - 3, 3);
                result.Append("\n");
            }

            return result.Remove(result.Length - 1, 1).ToString();
        }

        public string BoardDisplay()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    result.Append(board[i, j] is null ? "-" : board[i, j]).Append(" | ");
                }

                result.Remove(result.Length - 3, 3);
                result.Append("\r\n");
            }

            return result.ToString();
        }

        public bool SetSymbolToBoard(string turn)
        {
            // Format: "symbol-row-column"
            string[] input = turn.Split('-');
            board[int.Parse(input[1]), int.Parse(input[2])] = input[0];
            turnHistory.Add(turn);
            boardArray.Add(board);
            return true;
        }

        public override string ToString()
        {
            return
                $"{p1Name},{p2Name},{p1Symbol},{p2Symbol}|{new DateTimeOffset(startTime).ToUnixTimeSeconds()},{new DateTimeOffset(startTime).ToUnixTimeSeconds()}|{boardSize}|{string.Join(",", turnHistory)}";
        }
    }
}
