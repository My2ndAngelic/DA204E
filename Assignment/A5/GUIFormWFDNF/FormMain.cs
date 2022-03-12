using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormMain : Form
    {
        private CustomerManager cm = new CustomerManager();
        private Customer customer = new Customer();

        public Customer Customer
        {
            get { return customer; }
        }

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            testSuite();
        }


        private void testSuite()
        {
//             FormContact fc = new FormContact(customer);
//             textBoxTest.Text = $@"{fc.Customer.Contact.FName}
// {customer.Contact.LName}
// {customer.Contact.Email.Work}
// {customer.Contact.Email.Personal}
// {customer.Contact.Phone.Number}
// {customer.Contact.Address.Street}
// {customer.Contact.Address.City}
// {customer.Contact.Address.Zipcode}
// {customer.Contact.Address.Countries.ToString()}";

            for (int i = 0; i < 5; i++)
            {
                cm.Add(new Customer(new Contact($"John", "Cena",
                    new Address("Random Street", "NY", "69 420", Countries.United_States_of_America),
                    new Email("john@gmail.com", "cena@gmail.com"),
                    new Phone("+1 234 567 890"))));
            }
            UpdateGUI();
            // fc.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            cm.Add(LaunchDialog());
            UpdateGUI();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex == -1) return;
            customer = cm[listboxContact.SelectedIndex];
            cm.EditCustomer(LaunchDialog(), listboxContact.SelectedIndex);
            UpdateGUI();
        }

        public Customer LaunchDialog()
        {
            FormContact fc = new FormContact(customer);
            fc.ShowDialog();
            return fc.Customer;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex < 0) return;
            for (int i = listboxContact.SelectedIndices.Count - 1; i >= 0; i--)
            {
                cm.RemoveAt(listboxContact.SelectedIndices[i]);
            }
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            listboxContact.DataSource = cm.GetCustomers();
        }

        private void listboxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex < 0) return;
            textBoxContact.Text = cm.GetCustomerInfo(listboxContact.SelectedIndex).Aggregate("", (current, s) => current + (s + "\r\n"));;
            textBoxTest.Text = string.Join(", ", listboxContact.SelectedIndex);
        }
    }
}