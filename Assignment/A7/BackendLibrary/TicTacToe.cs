using System.Globalization;

namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public override string ToString()
        {
            // return new StringBuilder()
            //     .Append(p1Name).Append(',').Append(p2Name).Append(',')
            //     .Append(p1Symbol).Append(',').Append(p2Symbol).Append('|')
            //     .Append(new DateTimeOffset(startTime).ToUnixTimeSeconds()).Append(',')
            //     .Append(new DateTimeOffset(endTime).ToUnixTimeSeconds()).Append('|')
            //     .Append(boardSize).Append('|')
            //     .Append(string.Join(",", turnHistory))
            //     .ToString();
            return
                $"{p1Name},{p2Name},{p1Symbol},{p2Symbol}|{new DateTimeOffset(startTime).ToUnixTimeMilliseconds().ToString(CultureInfo.InvariantCulture)}:{new DateTimeOffset(endTime).ToUnixTimeMilliseconds().ToString(CultureInfo.InvariantCulture)}|{boardSize}|{string.Join(",", turnHistory)}";
        }

        /// <summary>
        ///     Reset the game, but keep the players and symbols
        /// </summary>
        public void Reset()
        {
            turnHistory = new List<string>();
            board = new string[boardSize, boardSize];
            boardHistory = new List<string?[,]>();
            startTime = DateTime.Now;
            endTime = DateTime.Now;
        }
    }
}