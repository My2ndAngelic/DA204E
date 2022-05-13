using System.Globalization;
using System.Text;

namespace BackendLibrary
{
    public partial class TicTacToe
    {
        /// <summary>
        ///     Reset the game, but keep the players and symbols
        /// </summary>
        public void Reset()
        {
            turnHistory.Clear();
            board = new string[boardSize, boardSize];
            boardHistory.Clear();
            startTime = DateTime.Now;
            endTime = DateTime.Now;
        }

        public override string ToString()
        {
            return
                $"{p1Name},{p2Name},{p1Symbol},{p2Symbol}|{new DateTimeOffset(startTime).ToUnixTimeMilliseconds().ToString(CultureInfo.InvariantCulture)}:{new DateTimeOffset(endTime).ToUnixTimeMilliseconds().ToString(CultureInfo.InvariantCulture)}|{boardSize}|{string.Join(",", turnHistory)}";
        }

        public StringBuilder ToStringBuilder()
        {
            return new StringBuilder()
                .Append(p1Name).Append(',').Append(p2Name).Append(',')
                .Append(p1Symbol).Append(',').Append(p2Symbol).Append('|')
                .Append(new DateTimeOffset(startTime).ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture))
                .Append(':')
                .Append(new DateTimeOffset(endTime).ToUnixTimeSeconds().ToString(CultureInfo.InvariantCulture))
                .Append('|')
                .Append(boardSize).Append('|')
                .Append(string.Join(",", turnHistory));
        }
    }
}