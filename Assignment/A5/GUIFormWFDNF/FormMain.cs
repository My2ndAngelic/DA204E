using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormMain : Form
    {
        private CustomerManager cm = new CustomerManager();
        private Customer currCustomer = new Customer();
        private bool editMode;
        
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

            if (di == DialogResult.OK)
            {
                cm.Add(currCustomer);
            }

        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            currCustomer = cm[listboxContact.SelectedIndex];
            FormContact fc = new FormContact(currCustomer);
            DialogResult di = fc.ShowDialog();

            if (di == DialogResult.OK)
            {
                cm[listboxContact.SelectedIndex] = currCustomer;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            
        }
    }
}
