using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormMain : Form
    {
        private readonly CustomerManager cm = new CustomerManager();
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
                cm.Add(new Customer(
                    new Contact($"John", "Cena",
                    new Address("Random Street", "NY", "69 420", Countries.United_States_of_America),
                    new Email("john@gmail.com", "cena@gmail.com"),
                    new Phone("+1 234 567 890", "+46 123 456 789"))));
            UpdateGUI();
            // fc.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            LaunchDialog(false);
            UpdateGUI();
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex == -1) return;
            customer = cm[listboxContact.SelectedIndex]; 
            LaunchDialog(true);
            UpdateGUI();
        }

        public void LaunchDialog(bool editMode)
        {
            FormContact fc = new FormContact(customer, editMode);
            DialogResult di = fc.ShowDialog();
            if (di != DialogResult.OK) return;
            if (editMode)
            {
                cm[listboxContact.SelectedIndex] = fc.Customer;
            }
            else
            {
                cm.Add(fc.Customer);
            }
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
            listboxContact.DataSource = CustomerProcessing(cm.GetCustomers());
        }

        private string[] CustomerProcessing(Customer[] customers)
        {
            return customers.Select((t, i) => $"{i} {t.Contact.LName}, {t.Contact.FName} {t.Contact.Phone.OfficeNumber} {t.Contact.Email.Work}").ToArray();
        }

        private void listboxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex < 0) return;
            textBoxContact.Text = listboxHandler(cm.GetCustomerInfo(listboxContact.SelectedIndex));
            textBoxTest.Text = string.Join(", ", listboxContact.SelectedIndex);
        }

        private string listboxHandler(IEnumerable<string> data)
        {
            return $@"Name: {data.ElementAt(1)} {data.ElementAt(2)}

Email: 
    Office: {data.ElementAt(3)}
    Home: {(data.ElementAt(4) != string.Empty ? data.ElementAt(4) : "None")}

Phone:
    Office: {data.ElementAt(5)} 
    Home: {(data.ElementAt(6) != string.Empty ? data.ElementAt(6) : "None")}

Address:
    {data.ElementAt(7)}
    {data.ElementAt(8)}
    {data.ElementAt(9)}
    {data.ElementAt(10)}
";
        }
    }
}