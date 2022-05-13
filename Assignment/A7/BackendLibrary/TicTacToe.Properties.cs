namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public string?[,] Board
        {
            get { return board; }
            set { board = value; }
        }

        public IList<string?[,]> BoardHistory
        {
            get { return boardHistory; }
            set { boardHistory = value; }
        }

        public int BoardSize
        {
            get { return boardSize; }
            set { boardSize = value; }
        }

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value is 0 or 1 ? value : 0; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }

        public string P1Name
        {
            get { return p1Name; }
            set { p1Name = value; }
        }

        public string P1Symbol
        {
            get { return p1Symbol; }
            set { p1Symbol = value; }
        }

        public string P2Name
        {
            get { return p2Name; }
            set { p2Name = value; }
        }

        public string P2Symbol
        {
            get { return p2Symbol; }
            set { p2Symbol = value; }
        }

        public DateTime StartTime
        {
            get { return startTime; }
        }

        public IList<string> TurnHistory
        {
            get { return turnHistory; }
        }
    }
}