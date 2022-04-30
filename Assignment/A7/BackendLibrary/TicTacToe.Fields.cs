namespace BackendLibrary
{
    public partial class TicTacToe
    {
        private int currentPlayer;
        private string?[,] board;
        private IList<string?[,]> boardHistory;
        private int boardSize;
        private DateTime endTime;
        private string p1Name;
        private string p1Symbol;
        private string p2Name;
        private string p2Symbol;
        private DateTime startTime;
        private IList<string> turnHistory;
        
    }
}