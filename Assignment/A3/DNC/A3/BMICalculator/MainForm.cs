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

namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private BMICalc bmiCalculator = new BMICalc();

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InitializeGUI()
        {
            Text = "Super Calculator by Evan Huynh"; // 

            // input control
            rbUS.Checked = true;
            labelHeight.Text = "Height";
            labelWeight.Text = "Weight";

            // Empty
            textName.Text = string.Empty;
            textKg.Text = string.Empty;
            textFt.Text = string.Empty;
            textInch.Text = string.Empty;
            textWeight.Text = string.Empty;
            labelBMI.Text = string.Empty;
            labelBMICat.Text = string.Empty;
        }

        private void ReadName()
        {
            
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void labelWeight_Click(object sender, EventArgs e)
        {
            labelWeight.Text = "Weight";
        }

        private void labelHeight_Click(object sender, EventArgs e)
        {
            labelHeight.Text = "Height";
        }

        private void rbUS_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbUS.Checked) return;
            textKg.Hide();
            textFt.Show();
            textInch.Show();
            textKg.Text = string.Empty;
            labelUnit1.Show();
            labelUnit1.Text = "ft";
            labelUnit2.Text = "in";
            labelUnit3.Text = "lb";
            bmiCalculator.SetUnitType(UnitType.American);
        }

        private void rbSI_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbSI.Checked) return;
            textKg.Show();
            textFt.Hide();
            textFt.Text = string.Empty;
            textInch.Hide();
            textInch.Text = string.Empty;
            labelUnit1.Hide();
            labelUnit2.Text = "m";
            labelUnit3.Text = "kg";
            bmiCalculator.SetUnitType(UnitType.Metric);
        }

        private void buttonCalculateBMI_Click(object sender, EventArgs e)
        {
            UpdateCorrectData();
            groupBoxResult.Text = $@"Result for {bmiCalculator.GetName()}";
            labelBMI.Text = bmiCalculator.BMIResult().ToString("#.##", CultureInfo.InvariantCulture);
            labelBMICat.Text = $@"Your BMI Category: {bmiCalculator.BMICategory()}";
        }

        /// <summary>
        ///     Updating the data after clicking the button
        /// </summary>
        private void UpdateCorrectData()
        {
            bmiCalculator.SetName(textName.Text);

            _ = double.TryParse(textWeight.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out var weight);
            bmiCalculator.SetWeight(weight);

            if (bmiCalculator.GetUnitType().Equals(UnitType.American))
            {
                _ = double.TryParse(textFt.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double ft);
                _ = double.TryParse(textInch.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double inch);
                bmiCalculator.SetHeight(ft*12 + inch);
            }
            else if (bmiCalculator.GetUnitType().Equals(UnitType.Metric))
            {
                _ = double.TryParse(textKg.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double m);
                bmiCalculator.SetHeight(m);
            }
        }

        private void textKg_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textWeight_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelBMI_Click(object sender, EventArgs e)
        {

        }

        private void labelBMICat_Click(object sender, EventArgs e)
        {
            
        }

        private void textFt_TextChanged(object sender, EventArgs e)
        {
            _ = double.TryParse(textFt.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double id1);
            _ = double.TryParse(textInch.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out double id2);
        }

        private void textInch_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelUnit1_Click(object sender, EventArgs e)
        {

        }

        private void labelUnit2_Click(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_Enter(object sender, EventArgs e)
        {

        }

        private void labelUnit3_Click(object sender, EventArgs e)
        {

        }
    }
}
