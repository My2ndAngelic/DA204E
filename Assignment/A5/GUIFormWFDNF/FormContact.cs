using System;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormContact : Form
    {
        private readonly bool editMode;
        private Customer customer;

        public FormContact(Customer customer, bool editMode)
        {
            this.editMode = editMode;
            this.customer = new Customer(customer);
            InitializeComponent();
            InitializeGUI();
        }

        public FormContact()
        {
            editMode = false;
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
            Text = editMode ? "Edit customer" : "Add new customer";
            FillInTheVoid();
        }

        private void FillInTheVoid()
        {
            groupBoxName.Text = @"Name";
            groupBoxAddress.Text = @"Address";
            groupBoxEP.Text = @"Email and phone";
            textBoxFName.Text = customer.Contact.FName;
            textBoxLName.Text = customer.Contact.LName;
            textBoxOMail.Text = customer.Contact.Email.Work;
            textBoxPMail.Text = customer.Contact.Email.Personal;
            textBoxOPhone.Text = customer.Contact.Phone.OfficeNumber;
            textBoxPPhone.Text = customer.Contact.Phone.PersonalNumber;
            textBoxStreet.Text = customer.Contact.Address.Street;
            textBoxCity.Text = customer.Contact.Address.City;
            textBoxZipcode.Text = customer.Contact.Address.Zipcode;
            comboBoxCountry.SelectedItem = customer.Contact.Address.Countries.ToString().Replace("_", " ");
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            customer.Contact.FName = textBoxFName.Text.Trim();
            customer.Contact.LName = textBoxLName.Text.Trim();
            customer.Contact.Address.Street = textBoxStreet.Text.Trim();
            customer.Contact.Address.City = textBoxCity.Text.Trim();
            customer.Contact.Address.Zipcode = textBoxZipcode.Text.Trim();
            customer.Contact.Address.Countries = (Countries) Enum.Parse(typeof(Countries),
                comboBoxCountry.SelectedValue.ToString().Replace(" ", "_"));
            customer.Contact.Email.Work = textBoxOMail.Text.Trim();
            customer.Contact.Email.Personal = textBoxPMail.Text.Trim();
            customer.Contact.Phone.OfficeNumber = textBoxOPhone.Text.Trim();
            customer.Contact.Phone.PersonalNumber = textBoxPPhone.Text.Trim();
            // customer = new Customer(
            //     new Contact(
            //         textBoxFName.Text.Trim(),
            //         textBoxLName.Text.Trim(),
            //         new Address(
            //             textBoxStreet.Text.Trim(),
            //             textBoxCity.Text.Trim(),
            //             textBoxZipcode.Text.Trim(),
            //             (Countries) Enum.Parse(typeof(Countries),
            //                 comboBoxCountry.SelectedValue.ToString().Replace(" ", "_"))),
            //         new Email(
            //             textBoxOMail.Text.Trim(),
            //             textBoxPMail.Text.Trim()),
            //         new Phone(
            //             textBoxOPhone.Text.Trim(),
            //             textBoxPPhone.Text.Trim()
            //         )
            //     ));
            if (customer.Contact.IsValidContact())
                DialogResult = DialogResult.OK;
            else
                MessageBox.Show(@"Something is wrong. Please check your input", @"Error");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to cancel?", @"Cancel", MessageBoxButtons.YesNo) == DialogResult.Yes) DialogResult = DialogResult.Cancel;
        }
    }
}