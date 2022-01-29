using System;
using System.Globalization;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private BMICalc bmiC = new BMICalc();
        private SavingCalc savingC = new SavingCalc();
        private BMRCalc bmrC = new BMRCalc();
        private readonly CultureInfo ci = CultureInfo.InvariantCulture;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void InitializeGUI()
        {
            Text = "Super Calculator by Evan Huynh"; // 

            // input control
            rbUS.Checked = true;
            groupBoxBMI.Text = "BMI Calculator";
            labelName.Text = "Name";
            labelHeight.Text = "Height";
            labelWeight.Text = "Weight";
            labelBMIRes.Text = "Result";
            labelBMICat.Text = "Category";
            labelNormalWeight.Text = "Range";

            // Empty
            textName.Text = string.Empty;
            textKg.Text = string.Empty;
            textFt.Text = string.Empty;
            textInch.Text = string.Empty;
            textWeight.Text = string.Empty;
            textBMI.Text = string.Empty;
            textBMICat.Text = string.Empty;
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
        }

        private void labelHeight_Click(object sender, EventArgs e)
        {

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
            bmiC.SetUnitType(UnitType.American);
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
            bmiC.SetUnitType(UnitType.Metric);
        }

        private void buttonCalculateBMI_Click(object sender, EventArgs e)
        {
            UpdateCorrectData();
        }

        /// <summary>
        ///     Updating the data after clicking the button
        /// </summary>
        private void UpdateCorrectData()
        {
            bmiC.SetName(textName.Text);
            bool out1 = double.TryParse(textWeight.Text, NumberStyles.Number, ci, out var weight);
            bool out2 = true, out3 = true;
            bmiC.SetWeight(weight);
            if (bmiC.GetUnitType().Equals(UnitType.American))
            {
                out2 = double.TryParse(textFt.Text, NumberStyles.Number, ci, out double ft);
                out3 = double.TryParse(textInch.Text, NumberStyles.Number, ci, out double inch);
                bmiC.SetHeight(ft*12 + inch);
            }
            else if (bmiC.GetUnitType().Equals(UnitType.Metric))
            {
                out2 = double.TryParse(textKg.Text, NumberStyles.Number, ci, out double m);
                bmiC.SetHeight(m);
            }
            if (out1 || out2 || out3)
            {
                SetTheBMI();
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input.", "Error");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void SetTheBMI()
        {
            groupBoxResult.Text = $@"Result for {bmiC.GetName()}";
            textBMI.Text = bmiC.BMIResult().ToString("#.##", ci);
            textBMICat.Text = $@"{bmiC.BMICategory()}";
            double[] normalWeight = bmiC.GetNormalWeight();
            string unit = bmiC.GetUnitType().Equals(UnitType.American) ? "lbs" : "kg";
            textBoxNormalWeight.Text = @"Normal weight is between " +
                                       $@"{normalWeight[0]:#} " +
                                       $@"{unit} " +
                                       @"and " +
                                       $@"{normalWeight[1]:#} " +
                                       $@"{unit} ";
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

        private void textBoxNormalWeight_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
