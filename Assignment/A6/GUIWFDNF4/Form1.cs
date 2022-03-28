using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BackendLibrary;

namespace GUIWFDNF4
{
    public partial class Form1 : Form
    {
        private TaskManager taskManager = new TaskManager();
        private Task currentSelected = new Task();
        private readonly List<string> pList = Enum.GetNames(typeof(PriorityType)).Select(Task.PriorityTypeToString).ToList();
        public Form1()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            taskManager = new TaskManager();
            comboBox1.DataSource = pList;
            listBox1.DataSource = taskManager.ToStrings();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;
            currentSelected = taskManager[listBox1.SelectedIndex];
            textBox1.Text = currentSelected.ToDo;
            comboBox1.SelectedIndex = pList.IndexOf(Task.PriorityTypeToString(currentSelected.Priority));
            dateTimePicker1.Value = currentSelected.Date;
        }

        private void UpdateGUI()
        {
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Text = string.Empty;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            taskManager.Add(new Task(dateTimePicker1.Value, (PriorityType) comboBox1.SelectedIndex, textBox1.Text));
            // taskManager.Add(new Task(new DateTime(2022,03,12), PriorityType.Important, "Hello World"));
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
            if (listBox1.SelectedIndex < 0) return;
            int temp = listBox1.SelectedIndex;
            taskManager.RemoveAt(listBox1.SelectedIndex);
            listBox1.DataSource = taskManager.ToStrings();
            listBox1.SelectedIndex = temp - 1;
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
                FileManager.FileWriter(Path.GetFullPath(sfd.FileName), taskManager.ToStringsFile());
            }
            catch
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
            
                foreach (string s in FileManager.FileReader(Path.GetFullPath(ofd.FileName)))
                {
                    taskManager.Add(Task.FromString(s));
                }

                listBox1.DataSource = taskManager.ToStrings();
            }
            catch
            {
                MessageBox.Show(@"Something is wrong. Please try again.", @"Error");
            }
            UpdateGUI();
        }

        private void toolStripMenuItemNew_Click(object sender, EventArgs e)
        {
            taskManager = new TaskManager();
            listBox1.DataSource = taskManager.ToStrings();
            UpdateGUI();
        }
    }
}