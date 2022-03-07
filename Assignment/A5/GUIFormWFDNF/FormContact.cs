using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormContact : Form
    {
        private Customer customer;

        public Customer Customer => customer;

        public FormContact(Customer customer)
        {
            InitializeComponent();
            InitializeGUI();
            this.customer = customer;
        }
        
        public FormContact()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            
        }
    }
}