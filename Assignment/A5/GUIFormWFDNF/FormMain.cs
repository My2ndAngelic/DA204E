using System;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormMain : Form
    {
        private readonly CustomerManager cm = new CustomerManager();
        private Customer currCustomer = new Customer();

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // currCustomer = new Customer(new Contact("John", "Cena", new Address("", "", "", Countries.Afghanistan),
            //     new Email("john@gmail.com", "cena@gmail.com"),
            //     new Phone("+69 420")));
            currCustomer = new Customer();
            if (!LaunchDialog()) return;
            cm.Add(currCustomer);
            UpdateGUI();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex == -1) return;
            currCustomer = cm[listboxContact.SelectedIndex];
            if (!LaunchDialog()) return;
            cm[listboxContact.SelectedIndex] = currCustomer;
        }

        public bool LaunchDialog()
        {
            FormContact fc = new FormContact(currCustomer);
            DialogResult di = fc.ShowDialog();
            return di == DialogResult.OK;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }

        private void UpdateGUI()
        {
            listboxContact.DataSource = cm.GetCustomers();
        }
    }
}