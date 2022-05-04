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
        private bool computerMode;
        private bool isComputerTurn;
        private bool p1Turn = true;

        private TicTacToe ttt = new TicTacToe(3)
        {
            P1Symbol = "X",
            P2Symbol = "O"
        };

        private List<TicTacToe> tttList = new List<TicTacToe>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
            Initialize();
        }

        private void NewGame()
        {
            ttt = new TicTacToe(3)
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
            for (int i = 0; i < ttt.BoardSize; i++)
            {
                RowDefinition row = new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                };
                PlayArea.RowDefinitions.Add(row);
                ColumnDefinition column = new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                };
                PlayArea.ColumnDefinitions.Add(column);
            }

            for (int i = 0; i < ttt.BoardSize; i++)
            for (int j = 0; j < ttt.BoardSize; j++)
            {
                Button button = new Button();
                button.Click += GameButton_OnClick;
                button.Name = $"Button_{i}_{j}";
                Grid.SetRow(button, i);
                Grid.SetColumn(button, j);
                PlayArea.Children.Add(button);
            }
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            // Time.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MenuItemOpen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Initialize()
        {
            List<Button> buttons = PlayArea.Children.OfType<Button>().ToList();
            foreach (Button button in buttons)
            {
                button.Content = "";
                button.Background = Brushes.White;
                button.Foreground = Brushes.Black;
                button.FontSize = 30;
            }
        }

        private void ButtonGameHuman_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            computerMode = false;
            Initialize();
        }

        private void ButtonGameCompP1_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            computerMode = true;
            p1Turn = true;
            isComputerTurn = false;
            Initialize();
            ComputerMove();
        }

        private void ButtonGameCompP2_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            computerMode = true;
            p1Turn = true;
            isComputerTurn = true;
            Initialize();
            ComputerMove();
        }

        private void GameButton_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);

            if (ttt.IsGameOver())
                return;

            if (!ttt.IsValidMove(row, column)) return;
            if (p1Turn)
            {
                button.Content = ttt.P1Symbol;
                button.Foreground = Brushes.Red;
                p1Turn = false;
            }
            else
            {
                button.Content = ttt.P2Symbol;
                button.Foreground = Brushes.Blue;
                p1Turn = true;
            }

            ttt.Move(row, column);

            if (!computerMode) return;
            isComputerTurn = true;
            ComputerMove();
        }

        private void ComputerMove()
        {
            if (ttt.IsGameOver())
                return;
            if (!isComputerTurn)
                return;
            int[] computerMove = ttt.ComputerMove();

            // Click the button from the computer's move
            Button button = PlayArea.Children.OfType<Button>()
                .First(button1 => button1.Name == $"Button_{computerMove[0]}_{computerMove[1]}");

            if (p1Turn)
            {
                button.Content = ttt.P1Symbol;
                button.Foreground = Brushes.Red;
                p1Turn = false;
            }
            else
            {
                button.Content = ttt.P2Symbol;
                button.Foreground = Brushes.Blue;
                p1Turn = true;
            }

            isComputerTurn = false;
        }
    }
}