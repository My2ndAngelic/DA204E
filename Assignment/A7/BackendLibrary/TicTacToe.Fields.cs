namespace BackendLibrary
{
    public partial class TicTacToe
    {
        private int boardSize;
        private string?[,] board;
        private IList<string> turnHistory;
        private string p1Name;
        private string p2Name;
        private string p1Symbol;
        private string p2Symbol;
        private DateTime startTime;
        private DateTime endTime;
        private List<string[,]> boardArray;
    }
}