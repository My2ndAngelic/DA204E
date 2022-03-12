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
            this.customer = customer;
            InitializeComponent();
            InitializeGUI();
        }

        public FormContact()
        {
            customer = new Customer();
            InitializeComponent();
            InitializeGUI();
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        private void InitializeGUI()
        {
            comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries)).Cast<Countries>().ToList()
                .ConvertAll(s => s.ToString().Replace("_", " "));
            // comboBoxCountry.DataSource = Enum.GetValues(typeof(Countries));
            FillInTheVoid();
        }

        private void FillInTheVoid()
        {
            Console.WriteLine();
            textBoxFName.Text = customer.Contact.FName;
            textBoxLName.Text = customer.Contact.LName;
            textBoxOMail.Text = customer.Contact.Email.Work;
            textBoxPMail.Text = customer.Contact.Email.Personal;
            textBoxPhone.Text = customer.Contact.Phone.Number;
            textBoxStreet.Text = customer.Contact.Address.Street;
            textBoxCity.Text = customer.Contact.Address.City;
            textBoxZipcode.Text = customer.Contact.Address.Zipcode;
            comboBoxCountry.SelectedItem = customer.Contact.Address.Countries.ToString().Replace("_", " ");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            customer = new Customer(
                new Contact(
                    textBoxFName.Text, 
                    textBoxLName.Text,
                    new Address(
                        textBoxStreet.Text, 
                        textBoxCity.Text, 
                        textBoxZipcode.Text,
                        (Countries) Enum.Parse(typeof(Countries), comboBoxCountry.SelectedValue.ToString().Replace(" ", "_"))),
                        new Email(textBoxOMail.Text, textBoxPMail.Text),
                    new Phone(textBoxPhone.Text)
                ));
            CheckValidity();
        }

        private void CheckValidity()
        {
            if (customer.Contact.IsValidContact())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"Something is wrong. Please check your input", "Error");
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}