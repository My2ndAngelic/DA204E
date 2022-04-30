using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BackendLibrary;

namespace WPF_DNC6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TicTacToe ttt = new TicTacToe();
        private List<TicTacToe> tttList = new List<TicTacToe>();
        
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }
        
        private void InitializeGUI()
        {
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += (dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0,0,1);
            dispatcherTimer.Start();
        }
        
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            Time.Content = DateTime.Now.ToString("HH:mm:ss");
        } 
    }
}
