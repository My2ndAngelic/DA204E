namespace BackendLibrary
{
    public partial class TicTacToe
    {
        /// <summary>
        ///     Move symbol to position on board
        /// </summary>
        /// <param name="row">Row of move</param>
        /// <param name="column">Column of move</param>
        /// <returns>True if valid move</returns>
        public bool Move(int row, int column)
        {
            BeginSwitchCurrentPlayer:
            string symbol;
            switch (currentPlayer)
            {
                case 0:
                    symbol = p1Symbol;
                    break;
                case 1:
                    symbol = p2Symbol;
                    break;
                default:
                    currentPlayer %= 2;
                    goto BeginSwitchCurrentPlayer;
            }

            currentPlayer++; // Next player

            return Move(string.Join("-", symbol, row.ToString(), column.ToString()));
        }
    }
}