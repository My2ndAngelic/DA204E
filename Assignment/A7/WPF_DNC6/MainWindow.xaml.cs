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
    public partial class MainWindow : Window
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

        /// <summary>
        ///     Show about dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAboutAndMenuAbout_OnClick(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        /// <summary>
        ///     Ask user if they want to exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExitAndMenuExit_OnClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Do you want to close the program?", "Exit", MessageBoxButton.YesNo,
                    MessageBoxImage.Question) != MessageBoxResult.Yes) return;
            Environment.Exit(0);
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGameBoard_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;

            // Get the position of the button
            int column = Grid.GetColumn(button);
            int row = Grid.GetRow(button);

            // Add move to the database
            if (!ttt.Move(row, column)) // Move method returns false if the move is invalid
                return;

            // Color the button
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

            // Disable the button
            button.IsEnabled = false;

            // Add move history to the list
            ListMoveHistory.Items.Add(
                $"{(p1Turn ? ttt.P1Name : ttt.P2Name)} puts {(p1Turn ? ttt.P1Symbol : ttt.P2Symbol)} into row {row} column {column}.");

            CheckGameStatus(); // Check the game status

            switch (isComputerVsComputerMode) // Check if computer vs computer mode
            {
                case false when !isComputerVsHumanMode: // If computer vs computer
                    return;
                case false: // If computer vs human
                    isComputerTurn = !isComputerTurn;
                    break;
                default: // If computer vs computer
                    isComputerTurn = true;
                    break;
            }

            ComputerMove(); // Computer move
        }

        /// <summary>
        ///     Initialize new game: Computer as player 1 and computer as player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGameEvE_OnClick(object sender, RoutedEventArgs e)
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

        /// <summary>
        ///     Initialize new game: Computer as player 1 and human as player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGameEvP_OnClick(object sender, RoutedEventArgs e)
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

        /// <summary>
        ///     Initialize new game: Human as player 1 and computer as player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGamePvE_OnClick(object sender, RoutedEventArgs e)
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

        /// <summary>
        ///     Initialize new game: Human as player 1 and human as player 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonGamePvP_OnClick(object sender, RoutedEventArgs e)
        {
            NewGame();
            ttt.P1Name = "Player 1";
            ttt.P2Name = "Player 2";
            isComputerVsHumanMode = false;
            isComputerTurn = false;
            isComputerVsComputerMode = false;
            InitializeBoard();
        }

        /// <summary>
        ///     Save game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveAndMenuSave_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (ttt.IsGameOver()) // Game finished
                {
                    File.WriteAllText(
                        $"{folderPath}\\{new DateTimeOffset(ttt.StartTime).ToUnixTimeSeconds()}.mhf",
                        ttt.ToString()); // Write to file
                    MessageBox.Show("Match saved successfully.", "Save", MessageBoxButton.OK,
                        MessageBoxImage.Information); // Show message when successful
                }
                else // Game not finished
                {
                    MessageBox.Show("Game is not over yet. Please finish the game before saving.", "Error",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                }
            }
            catch (UnauthorizedAccessException) // If you cannot write match history due to lack of permission
            {
                MessageBox.Show(
                    "Cannot save match history. Please select another folder or change write permission to the current one.",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
            catch (Exception ex) // Other error, just catch it, I do not know what else can happen
            {
                MessageBox.Show($@"Unknown error.
{ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        ///     Select folder to save match history
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSelectFolderAndMenuSelectFolder_OnClick(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog(); // This is from System.Windows.Forms, not WPF
            try
            {
                fbd.ShowDialog();
                // Do I need to check for write permission before changing the folder?
                folderPath = Path.GetFullPath(fbd.SelectedPath);
                SysInfo.Text = $"Save folder: {folderPath}";
            }
            catch (ArgumentException)
            {
            }
        }

        /// <summary>
        ///     Handling the event when computer move is made
        /// </summary>
        private void ComputerMove()
        {
            if (!isComputerTurn || ttt.IsGameOver()) return; // If computer is not playing or game is over, do nothing

            (int row, int column) = ttt.RandomComputerMoveIntegerTuple(); // Get computer move

            // Click the button from the computer's move
            FieldOfPlay.Children.OfType<Button>().First(b => b.Name == $"Button_{row}_{column}")
                .RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent)); // Click the button
        }

        /// <summary>
        ///     Check the game status and update the UI
        /// </summary>
        private void CheckGameStatus()
        {
            if (!ttt.IsGameOver())
            {
                GameStatus.Text = $"Ongoing between {ttt.P1Name}: {ttt.P1Symbol} and {ttt.P2Name}: {ttt.P2Symbol}";
                return;
            }

            GameStatus.Text = $"Game over. {ttt.GetWinner()} wins!";
            ListMoveHistory.Items.Add($"Match length: {ttt.EndTime.Subtract(ttt.StartTime).TotalSeconds:F} seconds");
            foreach (Button button in FieldOfPlay.Children.OfType<Button>()) button.IsEnabled = false;

            // Auto write to file could be done here
            // TODO: Add a checkbox to enable/disable auto-write to file. Maybe implemented in a later version.
            // Not now
        }

        /// <summary>
        ///     Update the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatcherTimer_Tick(object? sender, EventArgs e)
        {
            TimeInfo.Text =
                $@"Date: {DateTime.Now:yyyy-MM-dd}
Time: {DateTime.Now:HH:mm:ss}
Match length: {(ttt.TurnHistory.Count == 0 ? 0 : ttt.IsGameOver() ? ttt.EndTime.Subtract(ttt.StartTime).TotalMilliseconds / 1000 : DateTime.Now.Subtract(ttt.StartTime).TotalMilliseconds / 1000):F}";
        }

        /// <summary>
        ///     Board initialization
        /// </summary>
        private void InitializeBoard()
        {
            // Clear play area
            FieldOfPlay.Children.Clear();
            FieldOfPlay.RowDefinitions.Clear();
            FieldOfPlay.ColumnDefinitions.Clear();

            // Initialize row and column definitions for play area n x n
            for (int i = 0; i < ttt.BoardSize; i++)
            {
                RowDefinition rowStar = new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                };
                FieldOfPlay.RowDefinitions.Add(rowStar);
                ColumnDefinition columnStar = new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                };
                FieldOfPlay.ColumnDefinitions.Add(columnStar);
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
                FieldOfPlay.Children.Add(button);
            }

            // Match history list
            CheckGameStatus();
        }

        /// <summary>
        ///     Initialize the program
        /// </summary>
        private void InitializeGUI()
        {
            DispatcherTimer dt = new DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 0, 0, 10)
            };
            dt.Tick += dispatcherTimer_Tick;
            dt.Start();
            SysInfo.Text = $"Save folder: {folderPath}";
            Title =
                $"{((AssemblyProductAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute), false)).Product}";
        }

        /// <summary>
        ///     New game
        /// </summary>
        private void NewGame()
        {
            ttt.Reset();
            p1Turn = true;
            ListMoveHistory.Items.Clear();
        }
    }
}