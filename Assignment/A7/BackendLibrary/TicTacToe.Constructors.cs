namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public TicTacToe(int size)
        {
            currentPlayer = 0;
            startTime = DateTime.Now;
            endTime = DateTime.Now;
            p1Name = "Player 1";
            p2Name = "Player 2";
            p1Symbol = "X";
            p2Symbol = "O";
            boardSize = size;
            board = new string[size, size];
            turnHistory = new List<string>();
            boardHistory = new List<string?[,]>();
        }

        // String: "P1Name,P2Name,P1Symbol,P2Symbol | StartTime, EndTime | BoardSize | TurnHistory"
        public TicTacToe(string data)
        {
            currentPlayer = 0;
            string[] dataArray = data.Replace(" ", "").Split('|');
            string[] playerData = dataArray[0].Split(',');
            p1Name = playerData[0];
            p2Name = playerData[1];
            p1Symbol = playerData[2];
            p2Symbol = playerData[3];

            string[] timeData = dataArray[1].Split(':');
            startTime = DateTime.Parse(DateTimeOffset.FromUnixTimeSeconds(long.Parse(timeData[0])).ToString());
            endTime = DateTime.Parse(DateTimeOffset.FromUnixTimeSeconds(long.Parse(timeData[1])).ToString());

            boardSize = int.Parse(dataArray[2]);
            board = new string[boardSize, boardSize];

            turnHistory = dataArray[3].Split(",");
            boardHistory = new List<string?[,]>();
            foreach (string bData in turnHistory)
            {
                // Format: "Sym-Row-Col"
                string[] bDataArray = bData.Split('-');
                board[int.Parse(bDataArray[1]), int.Parse(bDataArray[2])] = bDataArray[0];
                boardHistory.Add(board);
            }
        }

        public TicTacToe(IReadOnlyList<string> dataArray)
        {
            currentPlayer = 0;
            string[] playerData = dataArray[0].Split(',');
            p1Name = playerData[0];
            p2Name = playerData[1];
            p1Symbol = playerData[2];
            p2Symbol = playerData[3];

            string[] timeData = dataArray[1].Split(':');
            startTime = DateTime.Parse(DateTimeOffset.FromUnixTimeSeconds(long.Parse(timeData[0])).ToString());
            endTime = DateTime.Parse(DateTimeOffset.FromUnixTimeSeconds(long.Parse(timeData[1])).ToString());

            boardSize = int.Parse(dataArray[2]);

            board = new string[boardSize, boardSize];
            turnHistory = dataArray[3].Split(",");
            boardHistory = new List<string?[,]>();
            foreach (string bData in turnHistory)
            {
                // Format: "Sym-Row-Col"
                string[] bDataArray = bData.Split('-');
                board[int.Parse(bDataArray[1]), int.Parse(bDataArray[2])] = bDataArray[0];
                boardHistory.Add(board);
            }
        }
    }
}