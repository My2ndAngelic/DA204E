using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using BackendLibrary;
using Microsoft.Win32;

namespace WPF_DNC6
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const int boardSize = 3;
        private bool isComputerTurn;
        private bool isComputerVsHumanMode;
        private bool p1Turn = true;
        private TicTacToe ttt;

        // private List<TicTacToe> tttList = new List<TicTacToe>();

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
            InitializeGUI();
            InitializeBoard();
        }

        private void NewGame()
        {
            ttt = new TicTacToe(boardSize)
            {
                P1Symbol = "X",
                P2Symbol = "O"
            };
            p1Turn = true;
        }

        private void InitializeGUI()
        {
            DispatcherTimer dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Time.Text =
                $"Date: {DateTime.Now:yyyy-MM-dd}\nTime: {DateTime.Now:HH:mm:ss}\nTimezone: GMT/UTC{DateTime.Now:zzz}";
        }

        private void MenuItemOpen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void InitializeBoard()
        {
            PlayArea.Children.Clear();
            PlayArea.RowDefinitions.Clear();
            PlayArea.ColumnDefinitions.Clear();

            for (int i = 0; i < ttt.BoardSize; i++)
            {
                RowDefinition rowStar = new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                };
                PlayArea.RowDefinitions.Add(rowStar);
                ColumnDefinition columnStar = new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                };
                PlayArea.ColumnDefinitions.Add(columnStar);
            }

            for (int i = 0; i < ttt.BoardSize; i++)
            for (int j = 0; j < ttt.BoardSize; j++)
            {
                Button button = new Button();
                button.Click += GameButton_OnClick;
                button.Name = $"Button_{i}_{j}";
                Grid.SetRow(button, i);
                Grid.SetColumn(button, j);
                button.FontSize = 30;
                button.FontWeight = FontWeights.Bold;
                PlayArea.Children.Add(button);
            }

            List<Button> buttons = PlayArea.Children.OfType<Button>().ToList();
            foreach (Button button in buttons)
            {
                button.Content = "";
                button.IsEnabled = true;
            }
            GameOver();
        }

        private void ButtonGameHuman_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Player 1";
            ttt.P2Name = "Player 2";
            isComputerVsHumanMode = false;
            isComputerTurn = false;
            InitializeBoard();
        }

        private void ButtonGameCompP1_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Player 1";
            ttt.P2Name = "Computer";
            isComputerVsHumanMode = true;
            isComputerTurn = false;
            InitializeBoard();
            GameOver();
        }

        private void ButtonGameCompP2_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Computer";
            ttt.P2Name = "Player 2";
            isComputerVsHumanMode = true;
            isComputerTurn = true;
            InitializeBoard();
            GameOver();
            ComputerMove();
        }

        private void GameButton_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);

            if (!ttt.IsValidMove(row, column)) return;

            ButtonSet(button);
            ttt.Move(row, column);
            GameOver();

            if (!isComputerVsHumanMode) return;
            isComputerTurn = true;
            ComputerMove();
        }

        private void ButtonSet(ContentControl button)
        {
            if (p1Turn)
            {
                button.Content = ttt.P1Symbol;
                button.Foreground = Brushes.Red;
                button.Background = Brushes.Red;
                p1Turn = false;
            }
            else
            {
                button.Content = ttt.P2Symbol;
                button.Foreground = Brushes.Blue;
                button.Background = Brushes.Blue;
                p1Turn = true;
            }
            button.IsEnabled = false;
        }

        private void ComputerMove()
        {
            if (!isComputerVsHumanMode || !isComputerTurn || ttt.IsGameOver()) return;

            int[] computerMove = ttt.RandomComputerMove();

            // Click the button from the computer's move

            ButtonSet(PlayArea.Children.OfType<Button>()
                .First(b => b.Name == $"Button_{computerMove[0]}_{computerMove[1]}"));
            isComputerTurn = false;
            GameOver();
        }

        private void GameOver()
        {
            if (!ttt.IsGameOver())
            {
                GameStatus.Text = $"Ongoing between {ttt.P1Name}: {ttt.P1Symbol} and {ttt.P2Name}: {ttt.P2Symbol}";
                return;
            }

            GameStatus.Text = $"Game over. {ttt.GetWinner()} wins!";
            foreach (Button button in PlayArea.Children.OfType<Button>()) button.IsEnabled = false;
        }
    }
}