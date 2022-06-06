using System;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using BackendLibrary;

namespace Ava_DNC
{
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
            InitializeBoard();
        }

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
                Button button = new Button
                {
                    Name = $"Button_{i}_{j}",
                    FontSize = 30,
                    FontWeight = FontWeight.Bold,
                    Content = "",
                    IsEnabled = true,
                    Background = Brushes.Azure,
                    BorderBrush = Brushes.Black
                };
                button.Click += ButtonGameBoard_OnClick;
                Grid.SetRow(button, i);
                Grid.SetColumn(button, j);
                FieldOfPlay.Children.Add(button);
            }

            // Match history list
            // CheckGameStatus();
        }

        private void ButtonGameBoard_OnClick(object? sender, RoutedEventArgs e)
        {
            Button button = (Button) sender;
            button.IsEnabled = false;
        }

        private void MenuNewPvP_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void MenuNewPvE_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void MenuNewEvP_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void MenuExit_OnClick(object? sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MenuAbout_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void MenuSave_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void MenuSelectFolder_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }

        private void MenuNewEvE_OnClick(object? sender, RoutedEventArgs e)
        {
            
        }
    }
}