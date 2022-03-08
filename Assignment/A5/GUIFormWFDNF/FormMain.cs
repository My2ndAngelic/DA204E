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
            currCustomer = new Customer();
            FormContact fc = new FormContact(currCustomer);
            DialogResult di = fc.ShowDialog();

            if (di == DialogResult.OK) cm.Add(currCustomer);
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex == -1) return;
            currCustomer = cm[listboxContact.SelectedIndex];
            FormContact fc = new FormContact(currCustomer);
            DialogResult di = fc.ShowDialog();

            if (di == DialogResult.OK) cm[listboxContact.SelectedIndex] = currCustomer;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }
    }
}