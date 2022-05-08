﻿namespace BackendLibrary
{
    public partial class TicTacToe
    {
        public bool Move(string position)
        {
            // Format: "sym-row-col"
            string[] move = position.Split('-');
            if (!IsValidMove(move) || IsGameOver()) return false;
            string symbol = move[0];
            int row = int.Parse(move[1]);
            int col = int.Parse(move[2]);
            endTime = DateTime.Now;

            board[row, col] = symbol;
            turnHistory.Add(position);
            boardHistory.Add(board);
            return true;
        }

        public bool UndoMove(int x, int y)
        {
            if (x < 0 || x > boardSize || y < 0 || y > boardSize || string.IsNullOrEmpty(board[x, y]))
                return false;
            board[x, y] = null;
            turnHistory.RemoveAt(turnHistory.Count - 1);
            boardHistory.RemoveAt(boardHistory.Count - 1);
            return true;
        }

        public bool IsGameOver()
        {
            return !string.IsNullOrEmpty(GetWinner());
        }

        public bool IsValidMove(string[] move)
        {
            int row = int.Parse(move[1]);
            int col = int.Parse(move[2]);
            return IsValidMove(row, col);
        }

        public bool IsValidMove(int row, int col)
        {
            return string.IsNullOrEmpty(board[row, col]);
        }

        public string GetWinner()
        {
            string winner = string.Empty;
            if (IsWinner(p1Symbol))
                winner = p1Name;
            else if (IsWinner(p2Symbol))
                winner = p2Name;
            else if (IsFilled())
                winner = "No one";

            return winner;
        }

        public bool IsWinner(string symbol)
        {
            bool winner = false;
            // Check rows
            for (int i = 0; i < boardSize; i++)
            for (int j = 0; j < boardSize; j++)
            {
                if (board[i, j] != symbol) break;

                if (j == boardSize - 1) winner = true;
            }

            // Check columns
            for (int i = 0; i < boardSize; i++)
            for (int j = 0; j < boardSize; j++)
            {
                if (board[j, i] != symbol) break;

                if (j == boardSize - 1) winner = true;
            }

            // Check diagonals left to right
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, i] != symbol) break;

                if (i == boardSize - 1) winner = true;
            }

            // Check diagonals right to left
            for (int i = 0; i < boardSize; i++)
            {
                if (board[i, boardSize - 1 - i] != symbol) break;

                if (i == boardSize - 1) winner = true;
            }

            return winner;
        }

        /// <summary>
        ///     Find the non-empty cells in the board
        /// </summary>
        /// <returns>True if there is no empty cell, false otherwise</returns>
        public bool IsFilled()
        {
            for (int i = 0; i < boardSize; i++)
            for (int j = 0; j < boardSize; j++)
                if (board[i, j] is null)
                    return false;
            return true;
        }
    }
}