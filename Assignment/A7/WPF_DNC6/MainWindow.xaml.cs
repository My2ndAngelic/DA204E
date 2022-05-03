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
        private TicTacToe ttt = new TicTacToe(3)
        {
            P1Symbol = "X",
            P2Symbol = "O"
        };
        private List<TicTacToe> tttList = new List<TicTacToe>();
        private bool computerMode = false;
        private bool whoseTurn = true;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
            Initialize();
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
            ttt = new TicTacToe(3);
            computerMode = false;
            Initialize();
        }

        private void ButtonGameCompP1_OnClick(object sender, RoutedEventArgs e)
        {
            ttt = new TicTacToe(3);
            computerMode = true;
        }

        private void ButtonGameCompP2_OnClick(object sender, RoutedEventArgs e)
        {
            ttt = new TicTacToe(3);
            computerMode = true;
        }

        private void GameButton_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;
            
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);
            
            if (ttt.IsGameOver())
                return;

            if (!ttt.IsValidMove(row, column)) return;
            if (whoseTurn)
            {
                button.Content = ttt.P1Symbol;
                button.Foreground = Brushes.Red;
                whoseTurn = false;
            }
            else
            {
                button.Content = ttt.P2Symbol;
                button.Foreground = Brushes.Blue;
                whoseTurn = true;
            }
            ttt.Move(row, column);
        }
    }
}