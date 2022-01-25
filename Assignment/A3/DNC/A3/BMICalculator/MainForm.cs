using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace BMICalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private BMICalc bmicalc = new BMICalc();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InitializeGUI()
        {
            this.Text = "The Body Mass Calculator by Evan Huynh"; // 

            // input control
            rbUS.Checked = true;
            labelHeight.Text = "Height (ft)";
            labelWeight.Text = "Weight (lbs)";

            textHeight.Text = string.Empty;
            textWeight.Text = string.Empty;
        }

        private void ReadName()
        {
            
        }

        private void labelName_Click(object sender, EventArgs e) => bmicalc.SetName(x => x = labelName.Text);
        
        private void textName_TextChanged(object sender, EventArgs e)
        {
            labelNameDisp.Text = textName.Text.ToString();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void labelWeight_Click(object sender, EventArgs e)
        {
            labelWeight.Text = bmicalc.GetUnitType().Equals(UnitType.American) ? "Weight (lbs)" : "Weight (kg)";
            Debug.WriteLine("Hello World");
        }

        private void labelHeight_Click(object sender, EventArgs e)
        {
            labelHeight.Text = bmicalc.GetUnitType().Equals(UnitType.American) ? "Height (ft)" : "Height (m)";
        }

        private void rbUS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUS.Checked)
            {
                bmicalc.SetUnitType(UnitType.American);
                labelHeight_Click(sender, e);
                labelWeight_Click(sender, e);
            }
        }

        private void rbSI_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSI.Checked)
            {
                bmicalc.SetUnitType(UnitType.Metric);
                labelHeight_Click(sender, e);
                labelWeight_Click(sender, e);
            }
        }

        private void buttonCalculateBMI_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            labelBMI.Text = bmicalc.BMIResult().ToString("#.##", CultureInfo.InvariantCulture);
        }

        private void textHeight_TextChanged(object sender, EventArgs e)
        {
            _ = double.TryParse(textHeight.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double id);
            bmicalc.SetHeight(id);
        }

        private void textWeight_TextChanged(object sender, EventArgs e)
        {
            _ = double.TryParse(textWeight.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double id);
            bmicalc.SetWeight(id);
        }

        private void labelBMI_Click(object sender, EventArgs e)
        {

        }
    }
}
