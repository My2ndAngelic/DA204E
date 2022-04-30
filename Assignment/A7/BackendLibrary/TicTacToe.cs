using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public TicTacToe(int size)
        {
            startTime = DateTime.Now;
            endTime = DateTime.Now;
            p1Name = "Player 1";
            p2Name = "Player 2";
            p1Symbol = "x";
            p2Symbol = "o";
            boardSize = size;
            board = new string[size, size];
            turnHistory = new List<string>();
            boardArray = new List<string[,]>();
        }
        
        
    }
}
