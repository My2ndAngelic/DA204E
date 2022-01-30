namespace SuperCalculator
{
    public partial class MainForm : Form
    {
        private readonly CultureInfo ci = CultureInfo.InstalledUICulture;
        private readonly NumberStyles ns = NumberStyles.Number;
        private readonly NumberStyles nsi = NumberStyles.Integer;
        private BMICalc bmiC = new BMICalc();
        private BMRCalc bmrC = new BMRCalc();
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
            if (rbFemale.Checked)
            {
                
            }
            else
            {
                
            }
        }
    }
}