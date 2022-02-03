using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        private readonly CultureInfo ci = CultureInfo.InstalledUICulture;
        private const NumberStyles ns = NumberStyles.Number;
        private const NumberStyles nsi = NumberStyles.Integer;
        private BMICalc bmiC = new BMICalc();
        private SavingCalc savingC = new SavingCalc();
        private BMRCalc bmrC = new BMRCalc();


        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// </summary>
        /// <returns></returns>
        private void InitializeGUI()
        {
            Text = "Super Calculator by Evan Huynh"; // 

            // BMI labels
            groupBoxBMI.Text = "BMI Calculator";
            groupBoxGender.Text = "Gender";
            groupBoxResultBMI.Text = "Result";
            labelName.Text = "Name";
            labelHeight.Text = "Height";
            labelWeight.Text = "Weight";
            labelBMIRes.Text = "Result";
            labelBMICat.Text = "Category";
            labelNormalWeight.Text = "Range";
            buttonCalculateBMI.Text = "Calculate BMI";
            rbUS.Text = "Imperial";
            rbSI.Text = "Metric";
            textName.Text = string.Empty;
            textFt.Text = string.Empty;
            textInch.Text = string.Empty;
            textBMI.Text = string.Empty;
            textBMICat.Text = string.Empty;
            rbSI.Checked = true;
            textName.Text = "Your mom";
            textKg.Text = "1,69";
            textWeight.Text = "69";
            
            // Saving labels
            groupBoxSaving.Text = "Saving";
            labelMonthlyDeposit.Text = "Monthly deposit";
            labelPeriod.Text = "Period (year)";
            labelInterest.Text = "Interest (in %)";
            labelFee.Text = "Fee (in %)";
            labelAmountPaid.Text = "Amount paid";
            labelAmountEarned.Text = "Amount earned";
            labelFinalBalance.Text = "Final balance";
            labelFee.Text = "Total fee";
            textDeposit.Text = "1200";
            textPeriod.Text = "15";
            textInterest.Text = "9,99";
            textFee.Text = "0,80";

            // BMR
            groupBoxBMR.Text = "BMR Calculator";
            groupBoxGender.Text = "Gender";
            groupBoxWAL.Text = "Weekly activity level";
            labelAge.Text = "Age";
            rb0.Text = "Sedentary";
            rb1.Text = "Lightly active";
            rb2.Text = "Moderately active";
            rb3.Text = "Very active";
            rb4.Text = "Extra active";
            buttonCalculateBMR.Text = "Calculate BMR";
            rbFemale.Checked = true;
            rb0.Checked = true;
            textAge.Text = "32";
            // Empty
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
            ReadName();
            UpdateBMIData();
        }

        private void ReadName()
        {
            textName.Text = textName.Text.Trim();
            bmiC.SetName(!string.IsNullOrEmpty(textName.Text) ? textName.Text : "Unknown");
        }

        /// <summary>
        ///     Updating the data after clicking the button
        /// </summary>
        private void UpdateBMIData()
        {
            bool out1 = double.TryParse(textWeight.Text, ns, ci, out double weight);
            if (out1) bmiC.SetWeight(weight);

            bool out2 = true, out3 = true;

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
                DisplayBMIResult();
            else
                MessageBox.Show("Something is wrong. Please check your input.", "Error");
        }

        /// <summary>
        ///     If everything is correct, display the result
        /// </summary>
        private void DisplayBMIResult()
        {
            groupBoxResultBMI.Text = $@"Result for {bmiC.GetName()}";
            textBMI.Text = bmiC.GetBMIResult().ToString("#.##", ci);
            textBMICat.Text = $@"{bmiC.GetBMICategory()}";
            double[] normalWeight = bmiC.GetNormalWeight();
            string unit = bmiC.GetUnitType().Equals(UnitType.Imperial) ? "lbs" : "kg";
            textBoxNormalWeight.Text = @"Normal weight is between " +
                                       $@"{normalWeight[0]:#} " +
                                       $@"{unit} " +
                                       @"and " +
                                       $@"{normalWeight[1]:#} " +
                                       $@"{unit}.";
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculateSaving_Click(object sender, EventArgs e)
        {
            UpdateFutureValue();
        }

        /// <summary>
        ///     Update the input data to correct result, otherwise set to 0;
        /// </summary>
        private void UpdateFutureValue()
        {
            if (decimal.TryParse(textDeposit.Text, ns, ci, out decimal md))
            {
                savingC.SetDeposit(md);
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input", "Error");
            }

            if (int.TryParse(textPeriod.Text, nsi, ci, out int period))
            {
                savingC.SetPeriod(period * 12);
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input", "Error");
            }

            if (decimal.TryParse(textInterest.Text, ns, ci, out decimal interest))
            {
                savingC.SetInterest(interest / 100 / 12);
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input", "Error");
            }

            if (decimal.TryParse(textFee.Text, ns, ci, out decimal fee))
            {
                savingC.SetFee(fee / 100 / 12);
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input", "Error");
            }
            DisplayFutureValue();
        }

        /// <summary>
        ///     Display the future value if everything is correctly set
        /// </summary>
        private void DisplayFutureValue()
        {
            textAmountPaid.Text = savingC.GetAmountPaid().ToString("F", ci);
            textAmountEarned.Text = savingC.GetAmountEarned().ToString("F", ci);
            textFinalBalance.Text = savingC.GetFinalBalance().ToString("F", ci);
            textTotalFee.Text = savingC.GetTotalFee().ToString("F", ci);
        }

        /// <summary>
        ///     Handling BMR button
        ///     Reference:
        ///     [1] https://stackoverflow.com/questions/4321300/c-easiest-way-to-populate-a-listbox-from-a-list
        ///     [2] https://www.geeksforgeeks.org/how-to-add-items-in-listbox-in-c-sharp/
        ///     [3] https://referencesource.microsoft.com/#System.Windows.Forms/winforms/Managed/System/WinForms/ListBox.cs
        ///     [4] https://www.geeksforgeeks.org/how-to-add-items-in-listbox-in-c-sharp/
        ///     [5] https://docs.microsoft.com/en-us/dotnet/api/system.drawing.font?view=windowsdesktop-6.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculateBMR_Click(object sender, EventArgs e)
        {
            buttonCalculateBMI_Click(sender, e); // Click the BMI button for updated value
            if (UpdateBMRData())
            {
                DisplayBMRResult();
            }
            else
            {
                MessageBox.Show("Something is wrong. Please check your input", "Error");
            }
        }

        private bool UpdateBMRData()
        {
            bmrC = new BMRCalc(bmiC);
            
            if (rbFemale.Checked)
                bmrC.SetGender(false);
            else if (rbMale.Checked) bmrC.SetGender(true);

            if (rb0.Checked)
                bmrC.SetGroup(0);
            else if (rb1.Checked)
                bmrC.SetGroup(1);
            else if (rb2.Checked)
                bmrC.SetGroup(2);
            else if (rb3.Checked)
                bmrC.SetGroup(3);
            else if (rb4.Checked) bmrC.SetGroup(4);
            bool ageOk = int.TryParse(textAge.Text, nsi, ci, out int age);
            bmrC.SetAge(age);

            return ageOk && !textBMI.Text.Equals(string.Empty);
        }

        private void DisplayBMRResult()
        {

            listBoxBMR.Controls.Clear();

            /*
             * Yes I did split up declaration, 
             * AddRange method using a string array to ListBox Items property
             * But initialize this is more fun
             */
            listBoxBMR.Controls.Add(new ListBox
            {
                Size = new Size(listBoxBMR.Size.Width, listBoxBMR.Size.Height),
                Sorted = false,
                DataSource = new string[]
                {
                    $"BMR result for {bmrC.GetName()}",
                    "",
                    $"Your BMR (calories/day): {bmrC.GetMinBMR():F2}",
                    $"Calories to maintain your weight: {bmrC.GetCalories(0):F2}",
                    $"Calories to lose {0.5} kg per week: {bmrC.GetCalories(-500):F2}",
                    $"Calories to lose {1} kg per week: {bmrC.GetCalories(-1000):F2}",
                    $"Calories to gain {0.5} kg per week: {bmrC.GetCalories(500):F2}",
                    $"Calories to gain {1} kg per week: {bmrC.GetCalories(1000):F2}",
                    "",
                    "Losing more than 1000 calories per day is to be avoided.",
                    ""
                }
            });
            listBoxBMR.Font = new Font(FontFamily.GenericSansSerif, 10);
        }
        
    }
}