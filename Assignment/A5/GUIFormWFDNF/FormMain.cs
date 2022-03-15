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
            
        }
        
        private void testSuite(int max)
        {
            Random r = new Random();

            string[] name = MiscellaneousHandlers.Name;
            
            for (int i = 0; i < max; i++)
                cm.Add(new Customer(
                    new Contact($@"{name[r.Next(name.Length)]}", $@"{name[r.Next(name.Length)]}",
                        new Address("Random Street", "NY", r.Next(100000).ToString("00 000"),
                            (Countries) Enum.GetValues(typeof(Countries)).OfType<Enum>().OrderBy(c => Guid.NewGuid())
                                .FirstOrDefault()),
                    new Email($"{name[r.Next(name.Length)].ToLower()}@gmail.com", $"{name[r.Next(name.Length)].ToLower()}@gmail.com"),
                    new Phone(
                        $"+{r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()}",
                        $"+{r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()} {r.Next(999).ToString()}"))));
            UpdateGUI();
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
            listboxContact.DataSource = MiscellaneousHandlers.CustomerProcessing(cm.GetCustomers());
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

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            testSuite(1);
        }

        private void buttonAdd10_Click(object sender, EventArgs e)
        {
            testSuite(10);
        }

        private void buttonAdd100_Click(object sender, EventArgs e)
        {
            testSuite(100);
        }

        private void listboxContact_MouseDown(object sender, MouseEventArgs e)
        {
            if (listboxContact.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listboxContact.ClearSelected();
        }
    }
}