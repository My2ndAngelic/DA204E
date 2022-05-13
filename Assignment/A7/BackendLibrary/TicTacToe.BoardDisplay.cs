using System.Text;

namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public static string BoardDisplay(string?[,] boardData)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < boardData.GetLength(0); i++)
            {
                for (int j = 0; j < boardData.GetLength(1); j++)
                    result.Append(boardData[i, j] is null ? "-" : boardData[i, j]).Append(" | ");

                result.Remove(result.Length - 3, 3);
                result.Append('\n');
            }

            return result.Remove(result.Length - 1, 1).ToString();
        }

        public string BoardDisplay()
        {
            return BoardDisplay(board);
        }
    }
}