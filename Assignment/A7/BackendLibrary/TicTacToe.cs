using System.Text;

namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public override string ToString()
        {
            return new StringBuilder()
                .Append(p1Name).Append(',').Append(p2Name).Append(',')
                .Append(p1Symbol).Append(',').Append(p2Symbol).Append('|')
                .Append(new DateTimeOffset(startTime).ToUnixTimeSeconds()).Append(',')
                .Append(new DateTimeOffset(endTime).ToUnixTimeSeconds()).Append('|')
                .Append(boardSize).Append('|')
                .Append(string.Join(",", turnHistory))
                .ToString();
        }

        public int[] ComputerMove()
        {
            Random r = new Random();
            int x = -1;
            int y = -1;
            if (IsGameOver())
                return new int[] {x, y};
            bool moveMade;
            do
            {
                x = r.Next(boardSize);
                y = r.Next(boardSize);
                moveMade = Move(x, y);
            } while (!moveMade);

            return new int[] {x, y};
        }
    }
}