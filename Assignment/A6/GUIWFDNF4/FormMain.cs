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

        private void InitializeGUI()
        {
            taskManager = new TaskManager();

            Text = @"ToDo Reminder by Evan Huynh";

            comboBox1.DataSource = prioListString;
            listBox1.DataSource = taskManager.ToStrings();
            listBox1.Font = new Font("Consolas", 12);

            dateTimePicker1.Value = DateTime.Now;

            toolTip1.SetToolTip(dateTimePicker1, "Click the calendar to open the date, write the time here.");
            toolTip1.SetToolTip(comboBox1, "Click to select your priority of the task.");
            toolTip1.SetToolTip(textBox1, "Enter the description of your task here.");
            toolTip1.SetToolTip(listBox1, "Click to select a tag, hold Ctrl to Select ");
            toolTip1.SetToolTip(buttonAdd, "Add a new task.");
            toolTip1.SetToolTip(buttonEdit, "Edit the first selected task");
            toolTip1.SetToolTip(buttonDelete, "Delete currently selected tasks.");

            // // This does not play nice with the program, it is ugly but I leave it here in case.
            // toolStripMenuItemNew.ToolTipText = @"New list";
            // toolStripMenuItemOpen.ToolTipText = @"Open file containing list";
            // toolStripMenuItemSave.ToolTipText = @"Save existing list to file";
            // toolStripMenuItemExit.ToolTipText = @"Exit the program";
            // toolStripMenuItemAbout.ToolTipText = @"Show about box";
            
            textBox1.Text = string.Empty;

            label1.Text = @"Date and Time";
            label2.Text = @"Priority";
            label3.Text = @"Description";
            label4.Text = @"Time";
            label5.Text = @"Priority";
            label6.Text = @"Description";

            timer1.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            currentSelectedTask = taskManager[listBox1.SelectedIndex];
            textBox1.Text = currentSelectedTask.ToDo;
            comboBox1.SelectedIndex = prioListString.IndexOf(Task.PriorityTypeToString(currentSelectedTask.Priority));
            dateTimePicker1.Value = currentSelectedTask.Date;
        }

        private void UpdateGUI()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            taskManager.Add(new Task(dateTimePicker1.Value, (PriorityType) comboBox1.SelectedIndex, textBox1.Text));
            listBox1.DataSource = taskManager.ToStrings();
            listBox1.SelectedIndex = -1;
            UpdateGUI();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            int temp = listBox1.SelectedIndex;
            taskManager[temp] = new Task(dateTimePicker1.Value, (PriorityType) comboBox1.SelectedIndex, textBox1.Text);
            listBox1.DataSource = taskManager.ToStrings();
            listBox1.SelectedIndex = temp;
            UpdateGUI();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
                return;
            if (MessageBox.Show(@"Do you want to delete selected items?", @"Deleting", MessageBoxButtons.YesNo) ==
                DialogResult.No)
                return;
            foreach (int index in listBox1.SelectedIndices.Cast<int>().Select(x => x).Reverse())
                taskManager.RemoveAt(index);
            listBox1.DataSource = taskManager.ToStrings();
            listBox1.SelectedIndex = -1;
            UpdateGUI();
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Do you want to exit?", @"Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void toolStripMenuItemSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                if (sfd.FileName == string.Empty) return;
                FileManager.FileWriter(Path.GetFullPath(sfd.FileName), taskManager.ToStringsFile());
            }
            catch (Exception ignored)
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
                if (ofd.FileName == string.Empty) return;

                if (taskManager.Count > 0)
                    switch (MessageBox.Show(@"Do you want to Append (Yes), Replace (No) or Cancel?", @"Opening file",
                                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                    {
                        case DialogResult.Yes:
                            break;
                        case DialogResult.No:
                            taskManager = new TaskManager();
                            break;
                        case DialogResult.None:
                        case DialogResult.OK:
                        case DialogResult.Cancel:
                        case DialogResult.Abort:
                        case DialogResult.Retry:
                        case DialogResult.Ignore:
                        default:
                            return;
                    }

                foreach (string s in FileManager.FileReader(Path.GetFullPath(ofd.FileName)))
                    taskManager.Add(Task.FromString(s));

                listBox1.DataSource = taskManager.ToStrings();
            }
            catch (Exception _)
            {
                MessageBox.Show(@"Something is wrong. Please try again.", @"Error");
            }

            UpdateGUI();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            if (taskManager.Count > 0)
            {
                switch (MessageBox.Show(@"Do you want to create new list of reminders?", @"New list",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    case DialogResult.Yes:
                        break;
                    case DialogResult.None:
                    case DialogResult.OK:
                    case DialogResult.Cancel:
                    case DialogResult.Abort:
                    case DialogResult.Retry:
                    case DialogResult.Ignore:
                    case DialogResult.No:
                    default: 
                        return;                
                }
            }
            taskManager = new TaskManager();
            listBox1.DataSource = taskManager.ToStrings();
            UpdateGUI();
        }

        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            DialogResult _ = new FormAbout().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label7.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listBox1.Items.Count; i++) listBox1.SetSelected(i, true);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listBox1.ClearSelected();
        }
    }
}