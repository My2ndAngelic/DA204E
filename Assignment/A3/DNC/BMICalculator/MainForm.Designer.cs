
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

        private BMICalc bmiCalc = new BMICalc();

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
            this.textYear = new System.Windows.Forms.TextBox();
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
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
            this.labelYear = new System.Windows.Forms.Label();
            this.labelInterest = new System.Windows.Forms.Label();
            this.labelFee = new System.Windows.Forms.Label();
            this.buttonCalculateSaving = new System.Windows.Forms.Button();
            this.groupBoxFV = new System.Windows.Forms.GroupBox();
            this.textAmountPaid = new System.Windows.Forms.TextBox();
            this.textAmountEarned = new System.Windows.Forms.TextBox();
            this.textFinalBalance = new System.Windows.Forms.TextBox();
            this.textTotalFee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAmountEarned = new System.Windows.Forms.Label();
            this.labelAmountPaid = new System.Windows.Forms.Label();
            this.groupBMR = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBoxGender = new System.Windows.Forms.GroupBox();
            this.textAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.groupBoxBMI.SuspendLayout();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.groupBoxSaving.SuspendLayout();
            this.groupBoxFV.SuspendLayout();
            this.groupBMR.SuspendLayout();
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
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(206, 80);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(175, 23);
            this.textYear.TabIndex = 1;
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
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.textBMI);
            this.groupBoxResult.Controls.Add(this.textBMICat);
            this.groupBoxResult.Controls.Add(this.textBoxNormalWeight);
            this.groupBoxResult.Controls.Add(this.labelNormalWeight);
            this.groupBoxResult.Controls.Add(this.labelBMICat);
            this.groupBoxResult.Controls.Add(this.labelBMIRes);
            this.groupBoxResult.Location = new System.Drawing.Point(13, 278);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(387, 230);
            this.groupBoxResult.TabIndex = 24;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
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
            this.groupBoxSaving.Controls.Add(this.textYear);
            this.groupBoxSaving.Controls.Add(this.textInterest);
            this.groupBoxSaving.Controls.Add(this.textFee);
            this.groupBoxSaving.Controls.Add(this.labelMonthlyDeposit);
            this.groupBoxSaving.Controls.Add(this.labelYear);
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
            this.textDeposit.TabIndex = 0;
            // 
            // textInterest
            // 
            this.textInterest.Location = new System.Drawing.Point(206, 130);
            this.textInterest.Name = "textInterest";
            this.textInterest.Size = new System.Drawing.Size(175, 23);
            this.textInterest.TabIndex = 2;
            // 
            // textFee
            // 
            this.textFee.Location = new System.Drawing.Point(206, 180);
            this.textFee.Name = "textFee";
            this.textFee.Size = new System.Drawing.Size(175, 23);
            this.textFee.TabIndex = 3;
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
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(6, 83);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(74, 15);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Period (year)";
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
            this.buttonCalculateSaving.TabIndex = 11;
            this.buttonCalculateSaving.Text = "Calculate Saving";
            this.buttonCalculateSaving.UseVisualStyleBackColor = true;
            this.buttonCalculateSaving.Click += new System.EventHandler(this.buttonCalculateSaving_Click);
            // 
            // groupBoxFV
            // 
            this.groupBoxFV.Controls.Add(this.textAmountPaid);
            this.groupBoxFV.Controls.Add(this.textAmountEarned);
            this.groupBoxFV.Controls.Add(this.textFinalBalance);
            this.groupBoxFV.Controls.Add(this.textTotalFee);
            this.groupBoxFV.Controls.Add(this.label1);
            this.groupBoxFV.Controls.Add(this.label2);
            this.groupBoxFV.Controls.Add(this.labelAmountEarned);
            this.groupBoxFV.Controls.Add(this.labelAmountPaid);
            this.groupBoxFV.Location = new System.Drawing.Point(447, 278);
            this.groupBoxFV.Name = "groupBoxFV";
            this.groupBoxFV.Size = new System.Drawing.Size(387, 230);
            this.groupBoxFV.TabIndex = 27;
            this.groupBoxFV.TabStop = false;
            this.groupBoxFV.Text = "Future Value";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Final balance";
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
            // labelAmountPaid
            // 
            this.labelAmountPaid.AutoSize = true;
            this.labelAmountPaid.Location = new System.Drawing.Point(6, 33);
            this.labelAmountPaid.Name = "labelAmountPaid";
            this.labelAmountPaid.Size = new System.Drawing.Size(77, 15);
            this.labelAmountPaid.TabIndex = 8;
            this.labelAmountPaid.Text = "Amount paid";
            // 
            // groupBMR
            // 
            this.groupBMR.Controls.Add(this.labelAge);
            this.groupBMR.Controls.Add(this.textAge);
            this.groupBMR.Controls.Add(this.groupBoxGender);
            this.groupBMR.Location = new System.Drawing.Point(13, 526);
            this.groupBMR.Name = "groupBMR";
            this.groupBMR.Size = new System.Drawing.Size(815, 227);
            this.groupBMR.TabIndex = 22;
            this.groupBMR.TabStop = false;
            this.groupBMR.Text = "BMRCalculator";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(68, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Imperial";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 80);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 19);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Metric";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBoxGender
            // 
            this.groupBoxGender.Controls.Add(this.radioButton1);
            this.groupBoxGender.Controls.Add(this.radioButton2);
            this.groupBoxGender.Location = new System.Drawing.Point(7, 22);
            this.groupBoxGender.Name = "groupBoxGender";
            this.groupBoxGender.Size = new System.Drawing.Size(155, 112);
            this.groupBoxGender.TabIndex = 24;
            this.groupBoxGender.TabStop = false;
            this.groupBoxGender.Text = "Gender";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(90, 156);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(72, 23);
            this.textAge.TabIndex = 22;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(6, 159);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(28, 15);
            this.labelAge.TabIndex = 25;
            this.labelAge.Text = "Age";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 785);
            this.Controls.Add(this.groupBoxBMI);
            this.Controls.Add(this.groupBoxUnit);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxSaving);
            this.Controls.Add(this.groupBoxFV);
            this.Controls.Add(this.groupBMR);
            this.Controls.Add(this.buttonCalculateSaving);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.groupBoxSaving.ResumeLayout(false);
            this.groupBoxSaving.PerformLayout();
            this.groupBoxFV.ResumeLayout(false);
            this.groupBoxFV.PerformLayout();
            this.groupBMR.ResumeLayout(false);
            this.groupBMR.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxResult;
        private System.Windows.Forms.Label labelUnit3;
        private System.Windows.Forms.TextBox textBMICat;
        private System.Windows.Forms.TextBox textBMI;
        private System.Windows.Forms.TextBox textBoxNormalWeight;
        private System.Windows.Forms.Label labelNormalWeight;
        private System.Windows.Forms.Label labelBMICat;
        private System.Windows.Forms.Label labelBMIRes;
        private System.Windows.Forms.GroupBox groupBoxSaving;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textInterest;
        private System.Windows.Forms.TextBox textFee;
        private System.Windows.Forms.TextBox textDeposit;
        private System.Windows.Forms.Label labelFee;
        private System.Windows.Forms.Label labelInterest;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelMonthlyDeposit;
        private System.Windows.Forms.Button buttonCalculateSaving;
        private System.Windows.Forms.GroupBox groupBoxFV;
        private System.Windows.Forms.TextBox textAmountEarned;
        private System.Windows.Forms.TextBox textAmountPaid;
        private System.Windows.Forms.TextBox textFinalBalance;
        private System.Windows.Forms.TextBox textTotalFee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAmountEarned;
        private System.Windows.Forms.Label labelAmountPaid;
        private System.Windows.Forms.GroupBox groupBMR;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textAge;
        private System.Windows.Forms.GroupBox groupBoxGender;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}