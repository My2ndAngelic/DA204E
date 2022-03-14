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
            Random r = new Random();
            for (int i = 0; i < 500; i++)
                cm.Add(new Customer(
                    new Contact("John", "Cena",
                        new Address("Random Street", "NY", r.Next(100000).ToString("00 000"),
                            (Countries) Enum.GetValues(typeof(Countries)).OfType<Enum>().OrderBy(c => Guid.NewGuid())
                                .FirstOrDefault()),
                    new Email("john@gmail.com", "cena@gmail.com"),
                    new Phone(
                        $"+{r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()}",
                        $"+{r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()}"))));
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

        private string pad(int i, long max)
        {
            int temp = i;
            if (i == 0)
            {
                i = 1;
            }
            int n = 0;
            while (Math.Pow(10, n) <= max)
            {
                n++;
            }

            int k = n;
            while (Math.Pow(10, k) > i)
            {
                k--;
            }

            return $"{string.Join("", Enumerable.Repeat("0", n-k).ToList())}{(temp > 0 ? i : temp)}";
        }

        private string[] CustomerProcessing(IEnumerable<Customer> customers)
        {
            IEnumerable<Customer> enumerable = customers.ToList();
            int i = 0;

            return enumerable.Select(t => $"{pad(i++, enumerable.Count())} {t.Contact.LName}, {t.Contact.FName} {t.Contact.Phone.OfficeNumber} {t.Contact.Email.Work}").ToArray();
        }

        private void listboxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex < 0) return;
            textBoxContact.Text = listboxContact_Handler(cm.GetCustomerInfo(listboxContact.SelectedIndex));
            textBoxTest.Text = string.Join(", ", listboxContact.SelectedIndex);
        }

        private string listboxContact_Handler(IEnumerable<string> data)
        {
            IEnumerable<string> enumerable = data.ToList();
            return $@"Name: {enumerable.ElementAt(1)} {enumerable.ElementAt(2)}

Email: 
    Office: {enumerable.ElementAt(3)}
    Home: {(enumerable.ElementAt(4) != string.Empty ? enumerable.ElementAt(4) : "None")}

Phone:
    Office: {enumerable.ElementAt(5)} 
    Home: {(enumerable.ElementAt(6) != string.Empty ? enumerable.ElementAt(6) : "None")}

Address:
    {enumerable.ElementAt(7)}
    {enumerable.ElementAt(8)}
    {enumerable.ElementAt(9)}
    {enumerable.ElementAt(10)}
";
        }
    }
}