using System;
using System.Collections.Generic;
using System.Windows;
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
        private TicTacToe ttt = new TicTacToe(3);
        private List<TicTacToe> tttList = new List<TicTacToe>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
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
            Time.Content = DateTime.Now.ToString("HH:mm:ss");
        }

        private void MenuItemOpen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }

        private void Button00_OnClick(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button01_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button02_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button10_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button11_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button12_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button20_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button21_OnClick(object sender, RoutedEventArgs e)
        {
        }

        private void Button22_OnClick(object sender, RoutedEventArgs e)
        {
        }
    }
}