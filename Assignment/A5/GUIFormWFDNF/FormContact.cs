using System;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIFormWFDNF
{
    public partial class FormContact : Form
    {
        private Customer customer;
        private readonly bool editMode;

        public FormContact(Customer customer, bool editMode)
        {
            this.editMode = editMode;
            this.customer = customer;
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
            customer = new Customer(
                new Contact(
                    textBoxFName.Text.Trim(), 
                    textBoxLName.Text.Trim(),
                    new Address(
                        textBoxStreet.Text.Trim(), 
                        textBoxCity.Text.Trim(), 
                        textBoxZipcode.Text.Trim(),
                        (Countries) Enum.Parse(typeof(Countries), comboBoxCountry.SelectedValue.ToString().Replace(" ", "_"))),
                    new Email(
                        textBoxOMail.Text.Trim(), 
                        textBoxPMail.Text.Trim()), 
                    new Phone(
                        textBoxOPhone.Text.Trim(),
                        textBoxPPhone.Text.Trim()
                    )
                ));
            if (customer.Contact.IsValidContact())
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"Something is wrong. Please check your input", @"Error");
            }
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(@"Do you want to cancel?", @"Cancel", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}