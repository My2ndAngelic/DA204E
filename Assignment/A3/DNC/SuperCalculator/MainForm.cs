using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        private readonly CultureInfo ci = CultureInfo.InstalledUICulture;
        private readonly NumberStyles ns = NumberStyles.Number;
        private readonly NumberStyles nsi = NumberStyles.Integer;
        private BMICalc bmiC = new BMICalc();
        private SavingCalc savingC = new SavingCalc();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private void InitializeGUI()
        {
            Text = "Super Calculator by Evan Huynh"; // 

            // input control
            rbSI.Checked = true;
            groupBoxBMI.Text = "BMI Calculator";
            labelName.Text = "Name";
            labelHeight.Text = "Height";
            labelWeight.Text = "Weight";
            labelBMIRes.Text = "Result";
            labelBMICat.Text = "Category";
            labelNormalWeight.Text = "Range";

            // BMR
            rbFemale.Checked = true;
            rb0.Checked = true;

            // Empty
            textName.Text = string.Empty;
            textKg.Text = "1,69";
            textFt.Text = string.Empty;
            textInch.Text = string.Empty;
            textWeight.Text = "69";
            textBMI.Text = string.Empty;
            textBMICat.Text = string.Empty;
            textAge.Text = "32";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbUS_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbUS.Checked) return;
            textKg.Hide();
            textKg.Text = string.Empty;
            textFt.Show();
            textInch.Show();
            labelUnit1.Show();
            labelUnit1.Text = "ft";
            labelUnit2.Text = "in";
            labelUnit3.Text = "lb";
            bmiC.SetUnitType(UnitType.Imperial);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
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
            UpdateCorrectBMIData();
        }

        /// <summary>
        ///     Updating the data after clicking the button
        /// </summary>
        private void UpdateCorrectBMIData()
        {
            bmiC.SetName(textName.Text);
            bool out1 = double.TryParse(textWeight.Text, ns, ci, out double weight);

            bool out2 = true, out3 = true;

            bmiC.SetWeight(weight);

            if (bmiC.GetUnitType().Equals(UnitType.Imperial))
            {
                out2 = double.TryParse(textFt.Text, ns, ci, out double ft);
                out3 = double.TryParse(textInch.Text, ns, ci, out double inch);
                if (out2 && out3) 
                    bmiC.SetHeight(ft * 12 + inch);
            }
            else if (bmiC.GetUnitType().Equals(UnitType.Metric))
            {
                out2 = double.TryParse(textKg.Text, ns, ci, out double m);
                if (out2)
                    bmiC.SetHeight(m);
            }

            if (out1 && out2 && out3)
                DisplayTheBMI();
            else
                MessageBox.Show("Something is wrong. Please check your input.", "Error");
        }

        /// <summary>
        /// </summary>
        private void DisplayTheBMI()
        {
            groupBoxResult.Text = $@"Result for {bmiC.GetName()}";
            textBMI.Text = bmiC.BMIResult().ToString("#.##", ci);
            textBMICat.Text = $@"{bmiC.BMICategory()}";
            double[] normalWeight = bmiC.GetNormalWeight();
            string unit = bmiC.GetUnitType().Equals(UnitType.Imperial) ? "lbs" : "kg";
            textBoxNormalWeight.Text = @"Normal weight is between " +
                                       $@"{normalWeight[0]:#} " +
                                       $@"{unit} " +
                                       @"and " +
                                       $@"{normalWeight[1]:#} " +
                                       $@"{unit} ";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculateSaving_Click(object sender, EventArgs e)
        {
            bool out1 = decimal.TryParse(textDeposit.Text, ns, ci, out decimal md);
            if (out1)
            {
                savingC.SetDeposit(md);
            }
            else
            {
                textDeposit.Text = "0"; 
                savingC.SetDeposit(0);
            }

            bool out2 = int.TryParse(textYear.Text, nsi, ci, out int period);
            if (out2)
            {
                savingC.SetPeriod(period * 12);
            }
            else
            {
                textYear.Text = "0";
                savingC.SetPeriod(0);
            }

            bool out3 = decimal.TryParse(textInterest.Text, ns, ci, out decimal interest);
            if (out3)
            {
                savingC.SetInterest(interest/100/12);
            }
            else
            {
                textInterest.Text = @"0";
                savingC.SetInterest(0);
            }

            bool out4 = decimal.TryParse(textFee.Text, ns, ci, out decimal fee);
            if (out4)
            {
                savingC.SetFee(fee/100/12);
            }
            else
            {
                textFee.Text = @"0";
                savingC.SetFee(0);
            }
            SetTheFutureValue();
        }

        private void SetTheFutureValue()
        {
            textAmountPaid.Text = savingC.GetAmountPaid().ToString("F", ci);
            textAmountEarned.Text = savingC.GetAmountEarned().ToString("F", ci);
            textFinalBalance.Text = savingC.GetFinalBalance().ToString("F", ci);
            textTotalFee.Text = savingC.GetTotalFee().ToString("F", ci);
        }

        private void buttonCalculateBMR_Click(object sender, EventArgs e)
        {
            buttonCalculateBMI_Click(sender, e);
            BMRCalc bmrC = new BMRCalc(bmiC);
            if (rbFemale.Checked)
            {
                bmrC.SetGender(false);
            }
            else if (rbMale.Checked)
            {
                bmrC.SetGender(true);
            }

            if (rb0.Checked)
            {
                bmrC.SetGroup(0);
            } else if (rb1.Checked)
            {
                bmrC.SetGroup(1);
            } else if (rb2.Checked)
            {
                bmrC.SetGroup(2);
            } else if (rb3.Checked)
            {
                bmrC.SetGroup(3);
            } else if (rb4.Checked)
            {
                bmrC.SetGroup(4);
            }

            bool ageOK = int.TryParse(textAge.Text, nsi, ci, out int age);
            if (ageOK && !textBMI.Text.Equals(string.Empty))
            {       
                    bmrC.SetAge(age);
                    ListBox mylist = new ListBox();
                    listBox1.Controls.Clear();      
                    mylist.Size = new Size(listBox1.Size.Width, listBox1.Size.Height);
                    mylist.Items.Add($"BMR result for {bmrC.GetName()}");
                    mylist.Items.Add("");
                    mylist.Items.Add($"Your BMR (calories/day): {bmrC.GetMinBMR():F2}");
                    mylist.Items.Add($"Calories to maintain your weight: {bmrC.GetCalories(0):F2}");
                    mylist.Items.Add($"Calories to lose {0.5} kg per week: {bmrC.GetCalories(-500):F2}");
                    mylist.Items.Add($"Calories to lose {1} kg per week: {bmrC.GetCalories(-1000):F2}");
                    mylist.Items.Add($"Calories to gain {0.5} kg per week: {bmrC.GetCalories(500):F2}");
                    mylist.Items.Add($"Calories to gain {1} kg per week: {bmrC.GetCalories(1000):F2}");
                    mylist.Items.Add("");
                    mylist.Items.Add("Losing more than 1000 calories per day is to be avoided.");
                    listBox1.Controls.Add(mylist);
                    listBox1.Font = new Font(FontFamily.GenericSansSerif, 12);
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input", "Error");
            }
        }
    }
}