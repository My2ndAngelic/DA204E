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

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        ///     Initialization
        /// </summary>
        private void InitializeGUI()
        {
            Text = @"Customer Registry by Evan Huynh";

            listboxContact.Text = string.Empty;
            textBoxContact.Text = string.Empty;

            labelID.Text = @"ID";
            labelName.Text = @"Name (Last, First)";
            labelPhone.Text = @"Office phone";
            labelEmail.Text = @"Office E-Mail";

            buttonAdd.Text = @"Add";
            buttonEdit.Text = @"Edit";
            buttonDelete.Text = @"Delete";

            UpdateGUI();
        }

        /// <summary>
        ///     Add button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            customer = new Customer();
            LaunchDialog(false);
            UpdateGUI();
        }

        /// <summary>
        ///     Edit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex == -1) return;
            customer = cm[listboxContact.SelectedIndex];
            LaunchDialog(true);
            UpdateGUI();
        }

        /// <summary>
        ///     Launch the dialog and add/edit the customer
        /// </summary>
        /// <param name="editMode"></param>
        public void LaunchDialog(bool editMode)
        {
            Customer customerA = new Customer(new Contact("John", "Cena",
                new Address("Random Street", "New York", "69420", Countries.United_States_of_America),
                new Email("john@gmail.com", "cena@gmail.com"),
                new Phone("+1 (234) 567-890", "+1 (234) 567-890")));
            FormContact fc = new FormContact(customerA, editMode);
            DialogResult di = fc.ShowDialog();
            if (di != DialogResult.OK) return;
            if (!editMode)
            {
                if (cm.Count == 0 || listboxContact.SelectedIndex < 0) // If no customer or not selected
                    cm.Add(fc.Customer);
                else
                    cm.Insert(listboxContact.SelectedIndex, fc.Customer);
            }
            else
            {
                cm[listboxContact.SelectedIndex] = fc.Customer;
            }
        }

        /// <summary>
        ///     Delete selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listboxContact.SelectedIndex < 0) return;
            foreach (int index in listboxContact.SelectedIndices.Cast<int>().Select(x => x).Reverse())
                cm.RemoveAt(index);
            UpdateGUI();
        }

        /// <summary>
        ///     Update MainForm GUI
        /// </summary>
        private void UpdateGUI()
        {
            listboxContact.DataSource = MiscellaneousHandlers.CustomerProcessing(cm.GetCustomers());
            listboxContact_SelectedIndexChanged(new object(), EventArgs.Empty);
        }

        /// <summary>
        ///     Watch which customer is selected then displayed their information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listboxContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxContact.Text = listboxContact.SelectedIndex < 0
                ? string.Empty
                : ContactTextBoxHandler(cm.GetCustomerInfo(listboxContact.SelectedIndex));
            // textBoxContact.Text =  ContactTextBoxHandler(cm.GetCustomerInfo(listboxContact.SelectedIndex));
        }

        /// <summary>
        ///     Output customer information onto the info text box
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private string ContactTextBoxHandler(IEnumerable<string> data)
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

        /// <summary>
        ///     Right click or click on the white part to deselect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listboxContact_MouseDown(object sender, MouseEventArgs e)
        {
            if (listboxContact.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listboxContact.ClearSelected();
        }

        /// <summary>
        ///     Ctrl + A for Select All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listboxContact_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listboxContact.Items.Count; i++) listboxContact.SetSelected(i, true);
        }
    }
}