using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using System.Windows.Threading;
using BackendLibrary;
using Button = System.Windows.Controls.Button;
using ButtonBase = System.Windows.Controls.Primitives.ButtonBase;
using MessageBox = System.Windows.MessageBox;

namespace WPF_DNC6
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private const int BoardSize = 3;
        private readonly TicTacToe ttt = new TicTacToe(BoardSize);
        private string folderPath = $"{Environment.CurrentDirectory}";
        private bool isComputerTurn;
        private bool isComputerVsComputerMode;
        private bool isComputerVsHumanMode;
        private bool p1Turn = true;

        public MainWindow()
        {
            InitializeComponent();
            NewGame();
            InitializeGUI();
            InitializeBoard();
            DataContext = ttt;
        }

        private void ButtonExit_OnClick(object sender, RoutedEventArgs e)
        {
            // MatchHistory matchHistory = new MatchHistory();
            // matchHistory.ShowDialog();
            if (MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButton.YesNo,
                    MessageBoxImage.Question) !=
                MessageBoxResult.Yes) return;
            Close();
        }

        private void ButtonGameBoard_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);

            if (!ttt.IsValidMove(row, column)) return;

            LeList.Items.Add(
                $"{(p1Turn ? ttt.P1Name : ttt.P2Name)} puts {(p1Turn ? ttt.P1Symbol : ttt.P2Symbol)} into row {row} column {column}.");

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

            button.IsEnabled = false;
            ttt.Move(row, column);
            CheckGameStatus();

            switch (isComputerVsComputerMode)
            {
                case false when !isComputerVsHumanMode:
                    return;
                case false:
                    isComputerTurn = !isComputerTurn;
                    break;
                default:
                    isComputerTurn = true;
                    break;
            }

            ComputerMove();
        }

        private void ButtonGameCompP1_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Player 1";
            ttt.P2Name = "Computer";
            isComputerVsHumanMode = true;
            isComputerTurn = false;
            isComputerVsComputerMode = false;
            InitializeBoard();
            CheckGameStatus();
        }

        private void ButtonGameCompP1P2_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Computer 1";
            ttt.P2Name = "Computer 2";
            isComputerVsHumanMode = false;
            isComputerTurn = true;
            isComputerVsComputerMode = true;
            InitializeBoard();
            CheckGameStatus();
            ComputerMove();
        }

        private void ButtonGameCompP2_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Computer";
            ttt.P2Name = "Player 2";
            isComputerVsHumanMode = true;
            isComputerTurn = true;
            isComputerVsComputerMode = false;
            InitializeBoard();
            CheckGameStatus();
            ComputerMove();
        }

        private void ButtonGameHuman_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Player 1";
            ttt.P2Name = "Player 2";
            isComputerVsHumanMode = false;
            isComputerTurn = false;
            isComputerVsComputerMode = false;
            InitializeBoard();
        }

        private void ButtonSave_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!ttt.IsGameOver())
                {
                    MessageBox.Show("Game is not over yet. Please finish the game before saving.", "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    return;
                }

                File.WriteAllText(
                    $"{folderPath}\\{new DateTimeOffset(ttt.StartTime).ToUnixTimeSeconds()}.mhf",
                    ttt.ToString());
                MessageBox.Show("Match saved successfully.", "Save", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot save match history. Please select another folder or try again.", "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void ButtonSelectFolder_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.ShowDialog();
                folderPath = Path.GetFullPath(fbd.SelectedPath);
                SysInfo.Text = $"Save folder: {folderPath}";
            }
            catch (ArgumentException)
            {
            }
        }

        private void ComputerMove()
        {
            if (!isComputerTurn || ttt.IsGameOver()) return;

            (int row, int column) = ttt.RandomComputerMove();

            // Click the button from the computer's move
            PlayArea.Children.OfType<Button>().First(b => b.Name == $"Button_{row}_{column}")
                .RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            // isComputerTurn = false;
        }

        private void CheckGameStatus()
        {
            if (!ttt.IsGameOver())
            {
                GameStatus.Text = $"Ongoing between {ttt.P1Name}: {ttt.P1Symbol} and {ttt.P2Name}: {ttt.P2Symbol}";
                return;
            }

            GameStatus.Text = $"Game over. {ttt.GetWinner()} wins!";
            LeList.Items.Add($"Match length: {ttt.EndTime.Subtract(ttt.StartTime).TotalSeconds:F} seconds");
            foreach (Button button in PlayArea.Children.OfType<Button>()) button.IsEnabled = false;


            // Write to file
            // Not now
        }

        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            // OS: {RuntimeInformation.OSDescription} {RuntimeInformation.OSArchitecture}
            // .NET version: {Environment.Version}
            // Timezone: GMT/UTC{DateTime.Now:zzz}
            TimeInfo.Text =
                $@"Date: {DateTime.Now:yyyy-MM-dd}
Time: {DateTime.Now:HH:mm:ss}
Match length: {(ttt.TurnHistory.Count == 0 ? 0 : ttt.IsGameOver() ? ttt.EndTime.Subtract(ttt.StartTime).TotalMilliseconds / 1000 : DateTime.Now.Subtract(ttt.StartTime).TotalMilliseconds / 1000):F}";
        }

        private void InitializeBoard()
        {
            // Clear play area
            PlayArea.Children.Clear();
            PlayArea.RowDefinitions.Clear();
            PlayArea.ColumnDefinitions.Clear();

            // Initialize row and column definitions for play area n x n
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

            // Initialize n x n buttons for play area
            for (int i = 0; i < ttt.BoardSize; i++)
            for (int j = 0; j < ttt.BoardSize; j++)
            {
                Button button = new Button();
                button.Click += ButtonGameBoard_OnClick;
                button.Name = $"Button_{i}_{j}";
                Grid.SetRow(button, i);
                Grid.SetColumn(button, j);
                button.FontSize = 30;
                button.FontWeight = FontWeights.Bold;
                button.Content = "";
                button.IsEnabled = true;
                button.Background = Brushes.White;
                PlayArea.Children.Add(button);
            }

            // Match history list

            CheckGameStatus();
        }

        private void InitializeGUI()
        {
            DispatcherTimer dt = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 0, 10)
            };
            dt.Tick += dispatcherTimer_Tick;
            dt.Start();
            SysInfo.Text = $"Save folder: {folderPath}";
            Title = $"{((AssemblyProductAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute), false)).Product}";
        }

        private void NewGame()
        {
            ttt.Reset();
            p1Turn = true;
            LeList.Items.Clear();
        }

        private void ButtonAbout_OnClick(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
    }
}