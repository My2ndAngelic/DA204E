
namespace SuperCalculator
{
    public partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textKg = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.rbUS = new System.Windows.Forms.RadioButton();
            this.rbSI = new System.Windows.Forms.RadioButton();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.textFt = new System.Windows.Forms.TextBox();
            this.textInch = new System.Windows.Forms.TextBox();
            this.labelUnit1 = new System.Windows.Forms.Label();
            this.labelUnit2 = new System.Windows.Forms.Label();
            this.groupBoxBMI = new System.Windows.Forms.GroupBox();
            this.labelUnit3 = new System.Windows.Forms.Label();
            this.textPeriod = new System.Windows.Forms.TextBox();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.groupBoxResultBMI = new System.Windows.Forms.GroupBox();
            this.textBMI = new System.Windows.Forms.TextBox();
            this.textBMICat = new System.Windows.Forms.TextBox();
            this.textBoxNormalWeight = new System.Windows.Forms.TextBox();
            this.labelNormalWeight = new System.Windows.Forms.Label();
            this.labelBMICat = new System.Windows.Forms.Label();
            this.labelBMIRes = new System.Windows.Forms.Label();
            this.groupBoxSaving = new System.Windows.Forms.GroupBox();
            this.textDeposit = new System.Windows.Forms.TextBox();
            this.textInterest = new System.Windows.Forms.TextBox();
            this.textFee = new System.Windows.Forms.TextBox();
            this.labelMonthlyDeposit = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.buttonCalculateSaving = new System.Windows.Forms.Button();
            this.groupBoxFutureValue = new System.Windows.Forms.GroupBox();
            this.textAmountPaid = new System.Windows.Forms.TextBox();
            this.textAmountEarned = new System.Windows.Forms.TextBox();
            this.textFinalBalance = new System.Windows.Forms.TextBox();
            this.textTotalFee = new System.Windows.Forms.TextBox();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.labelAmountEarned = new System.Windows.Forms.Label();
            this.labelFinalBalance = new System.Windows.Forms.Label();
            this.labelTotalFee = new System.Windows.Forms.Label();
            this.groupBoxBMR = new System.Windows.Forms.GroupBox();
            this.listBoxBMR = new System.Windows.Forms.ListBox();
            this.buttonCalculateBMR = new System.Windows.Forms.Button();
            this.groupBoxWAL = new System.Windows.Forms.GroupBox();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.labelAge = new System.Windows.Forms.Label();
            this.textAge = new System.Windows.Forms.TextBox();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.groupBoxBMI.SuspendLayout();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResultBMI.SuspendLayout();
            this.groupBoxSaving.SuspendLayout();
            this.groupBoxFutureValue.SuspendLayout();
            this.groupBoxBMR.SuspendLayout();
            this.groupBoxWAL.SuspendLayout();
            this.groupBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // textKg
            // 
            this.textKg.Location = new System.Drawing.Point(90, 80);
            this.textKg.Name = "textKg";
            this.textKg.Size = new System.Drawing.Size(175, 23);
            this.textKg.TabIndex = 1;
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(90, 130);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(175, 23);
            this.textWeight.TabIndex = 3;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(90, 30);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(175, 23);
            this.textName.TabIndex = 0;
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Location = new System.Drawing.Point(6, 34);
            this.rbUS.Name = "rbUS";
            this.rbUS.Size = new System.Drawing.Size(68, 19);
            this.rbUS.TabIndex = 3;
            this.rbUS.TabStop = true;
            this.rbUS.Text = "Imperial";
            this.rbUS.UseVisualStyleBackColor = true;
            this.rbUS.CheckedChanged += new System.EventHandler(this.rbUS_CheckedChanged);
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.Location = new System.Drawing.Point(6, 80);
            this.rbSI.Name = "rbSI";
            this.rbSI.Size = new System.Drawing.Size(59, 19);
            this.rbSI.TabIndex = 3;
            this.rbSI.TabStop = true;
            this.rbSI.Text = "Metric";
            this.rbSI.UseVisualStyleBackColor = true;
            this.rbSI.CheckedChanged += new System.EventHandler(this.rbSI_CheckedChanged);
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(13, 249);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(387, 23);
            this.buttonCalculateBMI.TabIndex = 4;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMI_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(7, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(7, 83);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(43, 15);
            this.labelHeight.TabIndex = 14;
            this.labelHeight.Text = "Height";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(7, 133);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(45, 15);
            this.labelWeight.TabIndex = 15;
            this.labelWeight.Text = "Weight";
            // 
            // textFt
            // 
            this.textFt.Location = new System.Drawing.Point(90, 80);
            this.textFt.Name = "textFt";
            this.textFt.Size = new System.Drawing.Size(72, 23);
            this.textFt.TabIndex = 1;
            // 
            // textInch
            // 
            this.textInch.Location = new System.Drawing.Point(193, 80);
            this.textInch.Name = "textInch";
            this.textInch.Size = new System.Drawing.Size(72, 23);
            this.textInch.TabIndex = 2;
            // 
            // labelUnit1
            // 
            this.labelUnit1.AutoSize = true;
            this.labelUnit1.Location = new System.Drawing.Point(168, 83);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(60, 15);
            this.labelUnit1.TabIndex = 20;
            this.labelUnit1.Text = "labelUnit1";
            // 
            // labelUnit2
            // 
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.Location = new System.Drawing.Point(271, 83);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(60, 15);
            this.labelUnit2.TabIndex = 21;
            this.labelUnit2.Text = "labelUnit2";
            // 
            // groupBoxBMI
            // 
            this.groupBoxBMI.Controls.Add(this.textName);
            this.groupBoxBMI.Controls.Add(this.textFt);
            this.groupBoxBMI.Controls.Add(this.textInch);
            this.groupBoxBMI.Controls.Add(this.textKg);
            this.groupBoxBMI.Controls.Add(this.textWeight);
            this.groupBoxBMI.Controls.Add(this.labelUnit2);
            this.groupBoxBMI.Controls.Add(this.labelUnit3);
            this.groupBoxBMI.Controls.Add(this.labelWeight);
            this.groupBoxBMI.Controls.Add(this.labelUnit1);
            this.groupBoxBMI.Controls.Add(this.labelHeight);
            this.groupBoxBMI.Controls.Add(this.labelName);
            this.groupBoxBMI.Location = new System.Drawing.Point(13, 12);
            this.groupBoxBMI.Name = "groupBoxBMI";
            this.groupBoxBMI.Size = new System.Drawing.Size(299, 230);
            this.groupBoxBMI.TabIndex = 22;
            this.groupBoxBMI.TabStop = false;
            this.groupBoxBMI.Text = "BMI Calculator";
            // 
            // labelUnit3
            // 
            this.labelUnit3.AutoSize = true;
            this.labelUnit3.Location = new System.Drawing.Point(271, 133);
            this.labelUnit3.Name = "labelUnit3";
            this.labelUnit3.Size = new System.Drawing.Size(60, 15);
            this.labelUnit3.TabIndex = 21;
            this.labelUnit3.Text = "labelUnit3";
            // 
            // textPeriod
            // 
            this.textPeriod.Location = new System.Drawing.Point(206, 80);
            this.textPeriod.Name = "textPeriod";
            this.textPeriod.Size = new System.Drawing.Size(175, 23);
            this.textPeriod.TabIndex = 6;
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.Controls.Add(this.rbUS);
            this.groupBoxUnit.Controls.Add(this.rbSI);
            this.groupBoxUnit.Location = new System.Drawing.Point(318, 12);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(82, 230);
            this.groupBoxUnit.TabIndex = 23;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Unit";
            // 
            // groupBoxResultBMI
            // 
            this.groupBoxResultBMI.Controls.Add(this.textBMI);
            this.groupBoxResultBMI.Controls.Add(this.textBMICat);
            this.groupBoxResultBMI.Controls.Add(this.textBoxNormalWeight);
            this.groupBoxResultBMI.Controls.Add(this.labelNormalWeight);
            this.groupBoxResultBMI.Controls.Add(this.labelBMICat);
            this.groupBoxResultBMI.Controls.Add(this.labelBMIRes);
            this.groupBoxResultBMI.Location = new System.Drawing.Point(13, 278);
            this.groupBoxResultBMI.Name = "groupBoxResultBMI";
            this.groupBoxResultBMI.Size = new System.Drawing.Size(387, 230);
            this.groupBoxResultBMI.TabIndex = 24;
            this.groupBoxResultBMI.TabStop = false;
            this.groupBoxResultBMI.Text = "Result";
            // 
            // textBMI
            // 
            this.textBMI.Enabled = false;
            this.textBMI.Location = new System.Drawing.Point(90, 30);
            this.textBMI.Name = "textBMI";
            this.textBMI.Size = new System.Drawing.Size(289, 23);
            this.textBMI.TabIndex = 0;
            this.textBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBMICat
            // 
            this.textBMICat.Enabled = false;
            this.textBMICat.Location = new System.Drawing.Point(90, 80);
            this.textBMICat.Name = "textBMICat";
            this.textBMICat.Size = new System.Drawing.Size(289, 23);
            this.textBMICat.TabIndex = 1;
            this.textBMICat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxNormalWeight
            // 
            this.textBoxNormalWeight.Enabled = false;
            this.textBoxNormalWeight.Location = new System.Drawing.Point(90, 130);
            this.textBoxNormalWeight.Name = "textBoxNormalWeight";
            this.textBoxNormalWeight.Size = new System.Drawing.Size(289, 23);
            this.textBoxNormalWeight.TabIndex = 2;
            this.textBoxNormalWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNormalWeight
            // 
            this.labelNormalWeight.AutoSize = true;
            this.labelNormalWeight.Location = new System.Drawing.Point(7, 133);
            this.labelNormalWeight.Name = "labelNormalWeight";
            this.labelNormalWeight.Size = new System.Drawing.Size(40, 15);
            this.labelNormalWeight.TabIndex = 25;
            this.labelNormalWeight.Text = "Range";
            // 
            // labelBMICat
            // 
            this.labelBMICat.AutoSize = true;
            this.labelBMICat.Location = new System.Drawing.Point(6, 83);
            this.labelBMICat.Name = "labelBMICat";
            this.labelBMICat.Size = new System.Drawing.Size(55, 15);
            this.labelBMICat.TabIndex = 4;
            this.labelBMICat.Text = "Category";
            // 
            // labelBMIRes
            // 
            this.labelBMIRes.AutoSize = true;
            this.labelBMIRes.Location = new System.Drawing.Point(7, 33);
            this.labelBMIRes.Name = "labelBMIRes";
            this.labelBMIRes.Size = new System.Drawing.Size(28, 15);
            this.labelBMIRes.TabIndex = 3;
            this.labelBMIRes.Text = "BMI";
            // 
            // groupBoxSaving
            // 
            this.groupBoxSaving.Controls.Add(this.textDeposit);
            this.groupBoxSaving.Controls.Add(this.textPeriod);
            this.groupBoxSaving.Controls.Add(this.textInterest);
            this.groupBoxSaving.Controls.Add(this.textFee);
            this.groupBoxSaving.Controls.Add(this.labelMonthlyDeposit);
            this.groupBoxSaving.Controls.Add(this.labelPeriod);
            this.groupBoxSaving.Controls.Add(this.labelInterest);
            this.groupBoxSaving.Controls.Add(this.labelFee);
            this.groupBoxSaving.Location = new System.Drawing.Point(447, 13);
            this.groupBoxSaving.Name = "groupBoxSaving";
            this.groupBoxSaving.Size = new System.Drawing.Size(387, 230);
            this.groupBoxSaving.TabIndex = 10;
            this.groupBoxSaving.TabStop = false;
            this.groupBoxSaving.Text = "Saving Calculator";
            // 
            // textDeposit
            // 
            this.textDeposit.Location = new System.Drawing.Point(206, 30);
            this.textDeposit.Name = "textDeposit";
            this.textDeposit.Size = new System.Drawing.Size(175, 23);
            this.textDeposit.TabIndex = 5;
            // 
            // textInterest
            // 
            this.textInterest.Location = new System.Drawing.Point(206, 130);
            this.textInterest.Name = "textInterest";
            this.textInterest.Size = new System.Drawing.Size(175, 23);
            this.textInterest.TabIndex = 7;
            // 
            // textFee
            // 
            this.textFee.Location = new System.Drawing.Point(206, 180);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(175, 23);
            this.textFee.TabIndex = 8;
            // 
            // labelMonthlyDeposit
            // 
            this.labelMonthlyDeposit.AutoSize = true;
            this.labelMonthlyDeposit.Location = new System.Drawing.Point(6, 34);
            this.labelMonthlyDeposit.Name = "labelMonthlyDeposit";
            this.labelMonthlyDeposit.Size = new System.Drawing.Size(94, 15);
            this.labelMonthlyDeposit.TabIndex = 4;
            this.labelMonthlyDeposit.Text = "Monthly deposit";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(6, 83);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(74, 15);
            this.labelPeriod.TabIndex = 5;
            this.labelPeriod.Text = "Period (year)";
            // 
            // labelInterest
            // 
            this.labelInterest.AutoSize = true;
            this.labelInterest.Location = new System.Drawing.Point(6, 133);
            this.labelInterest.Name = "labelInterest";
            this.labelInterest.Size = new System.Drawing.Size(80, 15);
            this.labelInterest.TabIndex = 6;
            this.labelInterest.Text = "Interest (in %)";
            // 
            // labelFee
            // 
            this.labelFee.AutoSize = true;
            this.labelFee.Location = new System.Drawing.Point(6, 183);
            this.labelFee.Name = "labelFee";
            this.labelFee.Size = new System.Drawing.Size(59, 15);
            this.labelFee.TabIndex = 7;
            this.labelFee.Text = "Fee (in %)";
            // 
            // buttonCalculateSaving
            // 
            this.buttonCalculateSaving.Location = new System.Drawing.Point(447, 249);
            this.buttonCalculateSaving.Name = "buttonCalculateSaving";
            this.buttonCalculateSaving.Size = new System.Drawing.Size(387, 23);
            this.buttonCalculateSaving.TabIndex = 9;
            this.buttonCalculateSaving.Text = "Calculate Saving";
            this.buttonCalculateSaving.UseVisualStyleBackColor = true;
            this.buttonCalculateSaving.Click += new System.EventHandler(this.buttonCalculateSaving_Click);
            // 
            // groupBoxFutureValue
            // 
            this.groupBoxFutureValue.Controls.Add(this.textAmountPaid);
            this.groupBoxFutureValue.Controls.Add(this.textAmountEarned);
            this.groupBoxFutureValue.Controls.Add(this.textFinalBalance);
            this.groupBoxFutureValue.Controls.Add(this.textTotalFee);
            this.groupBoxFutureValue.Controls.Add(this.labelAmountPaid);
            this.groupBoxFutureValue.Controls.Add(this.labelAmountEarned);
            this.groupBoxFutureValue.Controls.Add(this.labelFinalBalance);
            this.groupBoxFutureValue.Controls.Add(this.labelTotalFee);
            this.groupBoxFutureValue.Location = new System.Drawing.Point(447, 278);
            this.groupBoxFutureValue.Name = "groupBoxFutureValue";
            this.groupBoxFutureValue.Size = new System.Drawing.Size(387, 230);
            this.groupBoxFutureValue.TabIndex = 27;
            this.groupBoxFutureValue.TabStop = false;
            this.groupBoxFutureValue.Text = "Future Value";
            // 
            // textAmountPaid
            // 
            this.textAmountPaid.Enabled = false;
            this.textAmountPaid.Location = new System.Drawing.Point(206, 30);
            this.textAmountPaid.Name = "textAmountPaid";
            this.textAmountPaid.Size = new System.Drawing.Size(175, 23);
            this.textAmountPaid.TabIndex = 8;
            this.textAmountPaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textAmountEarned
            // 
            this.textAmountEarned.Enabled = false;
            this.textAmountEarned.Location = new System.Drawing.Point(206, 80);
            this.textAmountEarned.Name = "textAmountEarned";
            this.textAmountEarned.Size = new System.Drawing.Size(175, 23);
            this.textAmountEarned.TabIndex = 11;
            this.textAmountEarned.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textFinalBalance
            // 
            this.textFinalBalance.Enabled = false;
            this.textFinalBalance.Location = new System.Drawing.Point(206, 130);
            this.textFinalBalance.Name = "textFinalBalance";
            this.textFinalBalance.Size = new System.Drawing.Size(175, 23);
            this.textFinalBalance.TabIndex = 10;
            this.textFinalBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textTotalFee
            // 
            this.textTotalFee.Enabled = false;
            this.textTotalFee.Location = new System.Drawing.Point(206, 180);
            this.textTotalFee.Name = "textTotalFee";
            this.textTotalFee.Size = new System.Drawing.Size(175, 23);
            this.textTotalFee.TabIndex = 9;
            this.textTotalFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Location = new System.Drawing.Point(6, 33);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(77, 15);
            this.labelAmountPaid.TabIndex = 8;
            this.labelAmountPaid.Text = "Amount paid";
            // 
            // labelAmountEarned
            // 
            this.labelAmountEarned.AutoSize = true;
            this.labelAmountEarned.Location = new System.Drawing.Point(6, 83);
            this.labelAmountEarned.Name = "labelAmountEarned";
            this.labelAmountEarned.Size = new System.Drawing.Size(90, 15);
            this.labelAmountEarned.TabIndex = 9;
            this.labelAmountEarned.Text = "Amount earned";
            // 
            // labelFinalBalance
            // 
            this.labelFinalBalance.AutoSize = true;
            this.labelFinalBalance.Location = new System.Drawing.Point(6, 130);
            this.labelFinalBalance.Name = "labelFinalBalance";
            this.labelFinalBalance.Size = new System.Drawing.Size(76, 15);
            this.labelFinalBalance.TabIndex = 10;
            this.labelFinalBalance.Text = "Final balance";
            // 
            // labelTotalFee
            // 
            this.labelTotalFee.AutoSize = true;
            this.labelTotalFee.Location = new System.Drawing.Point(6, 180);
            this.labelTotalFee.Name = "labelTotalFee";
            this.labelTotalFee.Size = new System.Drawing.Size(55, 15);
            this.labelTotalFee.TabIndex = 11;
            this.labelTotalFee.Text = "Total Fee";
            // 
            // groupBoxBMR
            // 
            this.groupBoxBMR.Controls.Add(this.listBoxBMR);
            this.groupBoxBMR.Controls.Add(this.buttonCalculateBMR);
            this.groupBoxBMR.Controls.Add(this.groupBoxWAL);
            this.groupBoxBMR.Controls.Add(this.labelAge);
            this.groupBoxBMR.Controls.Add(this.textAge);
            this.groupBoxBMR.Controls.Add(this.groupBoxGender);
            this.groupBoxBMR.Location = new System.Drawing.Point(13, 526);
            this.groupBoxBMR.Name = "groupBoxBMR";
            this.groupBoxBMR.Size = new System.Drawing.Size(815, 323);
            this.groupBoxBMR.TabIndex = 22;
            this.groupBoxBMR.TabStop = false;
            this.groupBoxBMR.Text = "BMRCalculator";
            // 
            // listBoxBMR
            // 
            this.listBoxBMR.ItemHeight = 15;
            this.listBoxBMR.Location = new System.Drawing.Point(440, 23);
            this.listBoxBMR.Name = "listBoxBMR";
            this.listBoxBMR.Size = new System.Drawing.Size(369, 274);
            this.listBoxBMR.TabIndex = 27;
            // 
            // buttonCalculateBMR
            // 
            this.buttonCalculateBMR.Location = new System.Drawing.Point(6, 202);
            this.buttonCalculateBMR.Name = "buttonCalculateBMR";
            this.buttonCalculateBMR.Size = new System.Drawing.Size(180, 95);
            this.buttonCalculateBMR.TabIndex = 14;
            this.buttonCalculateBMR.Text = "Calculate BMR";
            this.buttonCalculateBMR.UseVisualStyleBackColor = true;
            this.buttonCalculateBMR.Click += new System.EventHandler(this.buttonCalculateBMR_Click);
            // 
            // groupBoxWAL
            // 
            this.groupBoxWAL.Controls.Add(this.rb0);
            this.groupBoxWAL.Controls.Add(this.rb1);
            this.groupBoxWAL.Controls.Add(this.rb2);
            this.groupBoxWAL.Controls.Add(this.rb3);
            this.groupBoxWAL.Controls.Add(this.rb4);
            this.groupBoxWAL.Location = new System.Drawing.Point(193, 22);
            this.groupBoxWAL.Name = "groupBoxWAL";
            this.groupBoxWAL.Size = new System.Drawing.Size(194, 275);
            this.groupBoxWAL.TabIndex = 26;
            this.groupBoxWAL.TabStop = false;
            this.groupBoxWAL.Text = "Weekly activity level";
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Location = new System.Drawing.Point(8, 30);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(31, 19);
            this.rb0.TabIndex = 13;
            this.rb0.TabStop = true;
            this.rb0.Text = "0";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(8, 80);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(31, 19);
            this.rb1.TabIndex = 13;
            this.rb1.TabStop = true;
            this.rb1.Text = "1";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(8, 130);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(31, 19);
            this.rb2.TabIndex = 13;
            this.rb2.TabStop = true;
            this.rb2.Text = "2";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.rb3.Location = new System.Drawing.Point(8, 180);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(31, 19);
            this.rb3.TabIndex = 13;
            this.rb3.TabStop = true;
            this.rb3.Text = "3";
            this.rb3.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Location = new System.Drawing.Point(8, 230);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(31, 19);
            this.rb4.TabIndex = 13;
            this.rb4.TabStop = true;
            this.rb4.Text = "4";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(7, 154);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "Age";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(90, 151);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(72, 23);
            this.textAge.TabIndex = 12;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.rbFemale);
            this.groupBoxGender.Controls.Add(this.rbMale);
            this.groupBoxGender.Location = new System.Drawing.Point(7, 22);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(155, 112);
            this.groupBoxGender.TabIndex = 24;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(6, 30);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(63, 19);
            this.rbFemale.TabIndex = 11;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(6, 80);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(51, 19);
            this.rbMale.TabIndex = 11;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 866);
            this.Controls.Add(this.groupBoxBMI);
            this.Controls.Add(this.groupBoxUnit);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.groupBoxResultBMI);
            this.Controls.Add(this.groupBoxSaving);
            this.Controls.Add(this.groupBoxFutureValue);
            this.Controls.Add(this.groupBoxBMR);
            this.Controls.Add(this.buttonCalculateSaving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResultBMI.ResumeLayout(false);
            this.groupBoxResultBMI.PerformLayout();
            this.groupBoxSaving.ResumeLayout(false);
            this.groupBoxSaving.PerformLayout();
            this.groupBoxFutureValue.ResumeLayout(false);
            this.groupBoxFutureValue.PerformLayout();
            this.groupBoxBMR.ResumeLayout(false);
            this.groupBoxBMR.PerformLayout();
            this.groupBoxWAL.ResumeLayout(false);
            this.groupBoxWAL.PerformLayout();
            this.groupBoxGender.ResumeLayout(false);
            this.groupBoxGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textKg;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.RadioButton rbUS;
        private System.Windows.Forms.RadioButton rbSI;
        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox textFt;
        private System.Windows.Forms.TextBox textInch;
        private System.Windows.Forms.Label labelUnit1;
        private System.Windows.Forms.Label labelUnit2;
        private System.Windows.Forms.GroupBox groupBoxBMI;
        private System.Windows.Forms.GroupBox groupBoxUnit;
        private System.Windows.Forms.GroupBox groupBoxResultBMI;
        private System.Windows.Forms.Label labelUnit3;
        private System.Windows.Forms.TextBox textBMICat;
        private System.Windows.Forms.TextBox textBMI;
        private System.Windows.Forms.TextBox textBoxNormalWeight;
        private System.Windows.Forms.Label labelNormalWeight;
        private System.Windows.Forms.Label labelBMICat;
        private System.Windows.Forms.Label labelBMIRes;
        private System.Windows.Forms.GroupBox groupBoxSaving;
        private System.Windows.Forms.TextBox textPeriod;
        private System.Windows.Forms.TextBox textInterest;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.TextBox textDeposit;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelInterest;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.Label labelMonthlyDeposit;
        private System.Windows.Forms.Button buttonCalculateSaving;
        private System.Windows.Forms.GroupBox groupBoxFutureValue;
        private System.Windows.Forms.TextBox textAmountEarned;
        private System.Windows.Forms.TextBox textAmountPaid;
        private System.Windows.Forms.TextBox textFinalBalance;
        private System.Windows.Forms.TextBox textTotalFee;
        private System.Windows.Forms.Label labelTotalFee;
        private System.Windows.Forms.Label labelFinalBalance;
        private System.Windows.Forms.Label labelAmountEarned;
        private System.Windows.Forms.Label labelAmountPaid;
        private System.Windows.Forms.GroupBox groupBoxBMR;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Button buttonCalculateBMR;
        private System.Windows.Forms.GroupBox groupBoxWAL;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.ListBox listBoxBMR;
    }
}