using System;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormContact : Form
    {
        private Customer customer;

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
            comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries)).Cast<Countries>().ToList()
                .ConvertAll(s => s.ToString().Replace("_", " "));
            // comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            customer = new Customer(new Contact(textBoxFName.Text, textBoxLName.Text,
                (Countries) Enum.Parse(typeof(Countries), comboBoxCountry.SelectedItem.ToString().Replace(" ", "_")),
                new Email(), new Phone()));
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}