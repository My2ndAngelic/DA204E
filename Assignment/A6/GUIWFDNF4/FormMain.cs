using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIWFDNF4
{
    public partial class FormMain : Form
    {
        private readonly List<string> prioListString = Enum.GetNames(typeof(PriorityType))
            .Select(Task.PriorityTypeToString)
            .ToList();

        private Task currentSelectedTask = new Task();
        private TaskManager taskManager = new TaskManager();

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        ///     Initialize GUI
        /// </summary>
        private void InitializeGUI()
        {
            // New Task Manager
            taskManager = new TaskManager();

            // Title
            Text = @"ToDo Reminder by Evan Huynh";

            // Set data binding to the array 
            comboBoxPrioList.DataSource = prioListString;
            listBoxReminders.DataSource = taskManager.ToStrings();
            listBoxReminders.Font = new Font("Consolas", 12);

            // Date time picker
            dateTimePicker1.Value = DateTime.Now;

            // Tooltips
            toolTip1.SetToolTip(dateTimePicker1, "Click the calendar to open the date, write the time here.");
            toolTip1.SetToolTip(comboBoxPrioList, "Click to select your priority of the task.");
            toolTip1.SetToolTip(textBoxDescription, "Enter the description of your task here.");
            toolTip1.SetToolTip(listBoxReminders, "Click to select a tag, hold Ctrl to Select ");
            toolTip1.SetToolTip(buttonAdd, "Add a new task.");
            toolTip1.SetToolTip(buttonEdit, "Edit the first selected task");
            toolTip1.SetToolTip(buttonDelete, "Delete currently selected tasks.");

            textBoxDescription.Text = string.Empty;

            // All the labels
            labelDateAndTime.Text = @"Date and Time";
            labelPrioList.Text = @"Priority";
            labelDescription.Text = @"Description";
            labelTimeList.Text = @"Time";
            labelPriorityList.Text = @"Priority";
            labelDesciptionList.Text = @"Description";

            timer.Start();
        }

        /// <summary>
        ///     Handing event when the selected index is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxReminder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxReminders.SelectedIndex < 0) return;
            currentSelectedTask = taskManager[listBoxReminders.SelectedIndex];
            textBoxDescription.Text = currentSelectedTask.ToDo;
            comboBoxPrioList.SelectedIndex =
                prioListString.IndexOf(Task.PriorityTypeToString(currentSelectedTask.Priority));
            dateTimePicker1.Value = currentSelectedTask.Date;
        }

        /// <summary>
        ///     After every action taken
        /// </summary>
        private void UpdateGUI()
        {
            listBoxReminders.DataSource = taskManager.ToStrings();
            dateTimePicker1.Value = DateTime.Now;
            textBoxDescription.Text = string.Empty;
        }

        /// <summary>
        ///     Handling event when the add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            taskManager.Add(new Task(dateTimePicker1.Value, (PriorityType) comboBoxPrioList.SelectedIndex,
                textBoxDescription.Text));
            listBoxReminders.SelectedIndex = -1;
            UpdateGUI();
        }

        /// <summary>
        ///     Handling event when the edit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxReminders.SelectedIndex < 0) return; // If nothing selected
            int temp = listBoxReminders.SelectedIndex;
            taskManager[temp] = new Task(dateTimePicker1.Value, (PriorityType) comboBoxPrioList.SelectedIndex,
                textBoxDescription.Text); // Change the task at position
            UpdateGUI();
            listBoxReminders.SelectedIndex = temp;
        }

        /// <summary>
        ///     Handling event when the delete button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxReminders.SelectedIndex < 0)
                return; // If nothing selected
            if (MessageBox.Show(@"Do you want to delete selected items?", @"Deleting", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                return; // If user does not want to deleted
            foreach (int index in listBoxReminders.SelectedIndices.Cast<int>().Select(x => x).Reverse())
                taskManager.RemoveAt(index); // Delete everything
            listBoxReminders.SelectedIndex = -1; // Deselect
            UpdateGUI();
        }

        /// <summary>
        ///     Handling event when user want to quit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to exit?", @"Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        /// <summary>
        ///     Handling event when save menu item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                if (sfd.FileName == string.Empty) return; // If no file is selected, return
                if (new FileInfo(Path.GetFullPath(sfd.FileName)).Length != 0)
                    switch (MessageBox.Show(@"Do you want to Append (Yes), Replace (No) or Cancel?", @"Opening file",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                    {
                        case DialogResult.Yes:
                            FileManager.FileAppender(Path.GetFullPath(sfd.FileName), taskManager.ToStringsFile());
                            break; // Append to the end of list
                        case DialogResult.No:
                            FileManager.FileWriter(Path.GetFullPath(sfd.FileName), taskManager.ToStringsFile());
                            break; // Replace the list with opened from file
                        default:
                            return;
                    }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something is wrong. Please try again.", @"Error");
            }

            UpdateGUI();
        }

        private void toolStripMenuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                if (ofd.FileName == string.Empty) return; // If no file is selected
                TaskManager taskManager2 = new TaskManager(); // Make a copy of the original for safety issue
                if (taskManager.Count > 0) // When there is loaded tasks
                    switch (MessageBox.Show(@"Do you want to Append (Yes), Replace (No) or Cancel?", @"Opening file",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                    {
                        case DialogResult.Yes:
                            taskManager2.Add(taskManager.ToList());
                            break; // Append to the end of list
                        case DialogResult.No:
                            break; // Replace the list with opened from file
                        default:
                            return;
                    }

                foreach (string s in FileManager.FileReader(Path.GetFullPath(ofd.FileName)))
                    taskManager2.Add(Task.FromString(s)); // Adding on the new list
                taskManager = taskManager2; // Change the old list reference to the new list
                listBoxReminders.DataSource = taskManager.ToStrings();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Something is wrong. Please try again.", @"Error");
            }

            UpdateGUI();
        }

        /// <summary>
        ///     Handling event when the new menu item is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            if (taskManager.Count > 0) // If there is a list of event present
                switch (MessageBox.Show(@"Do you want to create new list of reminders?", @"New list",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                    case DialogResult.OK:
                        break;
                    default:
                        return;
                }

            taskManager = new TaskManager();
            UpdateGUI();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            DialogResult _ = new FormAbout().ShowDialog();
        }

        /// <summary>
        ///     Display local time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void listBoxDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listBoxReminders.Items.Count; i++) listBoxReminders.SetSelected(i, true);
        }

        private void listBoxDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxReminders.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listBoxReminders.ClearSelected();
        }
    }
}