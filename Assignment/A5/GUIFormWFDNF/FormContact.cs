using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormContact : Form
    {
        private readonly Customer customer;

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

        public Customer Customer
        {
            get { return customer; }
        }

        private void InitializeGUI()
        {
        }
    }
}