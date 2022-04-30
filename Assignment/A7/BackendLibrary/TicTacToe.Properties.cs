namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public int BoardSize
        {
            get { return boardSize; }
            set { boardSize = value; }
        }

        public string?[,] Board
        {
            get { return board; }
            set { board = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public IList<string> TurnHistory
        {
            get { return turnHistory; }
            set { turnHistory = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public string P1Name
        {
            get { return p1Name; }
            set { p1Name = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public string P2Name
        {
            get { return p2Name; }
            set { p2Name = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public string P1Symbol
        {
            get { return p1Symbol; }
            set { p1Symbol = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public string P2Symbol
        {
            get { return p2Symbol; }
            set { p2Symbol = value ?? throw new ArgumentNullException(nameof(value)); }
        }

        public DateTime StartTime
        {
            get { return startTime; }
            set { startTime = value; }
        }

        public DateTime EndTime
        {
            get { return endTime; }
            set { endTime = value; }
        }
        
        public List<string[,]> BoardArray
        {
            get { return boardArray; }
            set { boardArray = value; }
        }
    }
}
