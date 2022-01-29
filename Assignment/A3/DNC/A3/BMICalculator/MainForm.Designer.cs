
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
            this.groupBoxUnit = new System.Windows.Forms.GroupBox();
            this.groupBoxResult = new System.Windows.Forms.GroupBox();
            this.labelBMI = new System.Windows.Forms.TextBox();
            this.labelBMICat = new System.Windows.Forms.TextBox();
            this.groupBoxBMI.SuspendLayout();
            this.groupBoxUnit.SuspendLayout();
            this.groupBoxResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // textKg
            // 
            this.textKg.Location = new System.Drawing.Point(103, 80);
            this.textKg.Name = "textKg";
            this.textKg.Size = new System.Drawing.Size(175, 23);
            this.textKg.TabIndex = 4;
            this.textKg.TextChanged += new System.EventHandler(this.textKg_TextChanged);
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(103, 116);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(175, 23);
            this.textWeight.TabIndex = 5;
            this.textWeight.TextChanged += new System.EventHandler(this.textWeight_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(103, 44);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(175, 23);
            this.textName.TabIndex = 6;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Location = new System.Drawing.Point(6, 32);
            this.rbUS.Name = "rbUS";
            this.rbUS.Size = new System.Drawing.Size(68, 19);
            this.rbUS.TabIndex = 10;
            this.rbUS.TabStop = true;
            this.rbUS.Text = "Imperial";
            this.rbUS.UseVisualStyleBackColor = true;
            this.rbUS.CheckedChanged += new System.EventHandler(this.rbUS_CheckedChanged);
            // 
            // rbSI
            // 
            this.rbSI.AutoSize = true;
            this.rbSI.Location = new System.Drawing.Point(6, 66);
            this.rbSI.Name = "rbSI";
            this.rbSI.Size = new System.Drawing.Size(59, 19);
            this.rbSI.TabIndex = 11;
            this.rbSI.TabStop = true;
            this.rbSI.Text = "Metric";
            this.rbSI.UseVisualStyleBackColor = true;
            this.rbSI.CheckedChanged += new System.EventHandler(this.rbSI_CheckedChanged);
            // 
            // buttonCalculateBMI
            // 
            this.buttonCalculateBMI.Location = new System.Drawing.Point(14, 164);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(395, 46);
            this.buttonCalculateBMI.TabIndex = 12;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMI_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(14, 47);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(14, 83);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(43, 15);
            this.labelHeight.TabIndex = 14;
            this.labelHeight.Text = "Height";
            this.labelHeight.Click += new System.EventHandler(this.labelHeight_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(14, 119);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(45, 15);
            this.labelWeight.TabIndex = 15;
            this.labelWeight.Text = "Weight";
            this.labelWeight.Click += new System.EventHandler(this.labelWeight_Click);
            // 
            // textFt
            // 
            this.textFt.Location = new System.Drawing.Point(103, 80);
            this.textFt.Name = "textFt";
            this.textFt.Size = new System.Drawing.Size(72, 23);
            this.textFt.TabIndex = 18;
            this.textFt.TextChanged += new System.EventHandler(this.textFt_TextChanged);
            // 
            // textInch
            // 
            this.textInch.Location = new System.Drawing.Point(206, 80);
            this.textInch.Name = "textInch";
            this.textInch.Size = new System.Drawing.Size(72, 23);
            this.textInch.TabIndex = 19;
            this.textInch.TextChanged += new System.EventHandler(this.textInch_TextChanged);
            // 
            // labelUnit1
            // 
            this.labelUnit1.AutoSize = true;
            this.labelUnit1.Location = new System.Drawing.Point(168, 70);
            this.labelUnit1.Name = "labelUnit1";
            this.labelUnit1.Size = new System.Drawing.Size(60, 15);
            this.labelUnit1.TabIndex = 20;
            this.labelUnit1.Text = "labelUnit1";
            this.labelUnit1.Click += new System.EventHandler(this.labelUnit1_Click);
            // 
            // labelUnit2
            // 
            this.labelUnit2.AutoSize = true;
            this.labelUnit2.Location = new System.Drawing.Point(271, 70);
            this.labelUnit2.Name = "labelUnit2";
            this.labelUnit2.Size = new System.Drawing.Size(60, 15);
            this.labelUnit2.TabIndex = 21;
            this.labelUnit2.Text = "labelUnit2";
            this.labelUnit2.Click += new System.EventHandler(this.labelUnit2_Click);
            // 
            // groupBoxBMI
            // 
            this.groupBoxBMI.Controls.Add(this.labelUnit2);
            this.groupBoxBMI.Controls.Add(this.labelUnit3);
            this.groupBoxBMI.Controls.Add(this.labelUnit1);
            this.groupBoxBMI.Location = new System.Drawing.Point(13, 13);
            this.groupBoxBMI.Name = "groupBoxBMI";
            this.groupBoxBMI.Size = new System.Drawing.Size(299, 134);
            this.groupBoxBMI.TabIndex = 22;
            this.groupBoxBMI.TabStop = false;
            this.groupBoxBMI.Text = "BMI Calculator";
            // 
            // labelUnit3
            // 
            this.labelUnit3.AutoSize = true;
            this.labelUnit3.Location = new System.Drawing.Point(271, 106);
            this.labelUnit3.Name = "labelUnit3";
            this.labelUnit3.Size = new System.Drawing.Size(60, 15);
            this.labelUnit3.TabIndex = 21;
            this.labelUnit3.Text = "labelUnit3";
            this.labelUnit3.Click += new System.EventHandler(this.labelUnit3_Click);
            // 
            // groupBoxUnit
            // 
            this.groupBoxUnit.Controls.Add(this.rbUS);
            this.groupBoxUnit.Controls.Add(this.rbSI);
            this.groupBoxUnit.Location = new System.Drawing.Point(318, 13);
            this.groupBoxUnit.Name = "groupBoxUnit";
            this.groupBoxUnit.Size = new System.Drawing.Size(91, 134);
            this.groupBoxUnit.TabIndex = 23;
            this.groupBoxUnit.TabStop = false;
            this.groupBoxUnit.Text = "Unit";
            // 
            // groupBoxResult
            // 
            this.groupBoxResult.Controls.Add(this.labelBMICat);
            this.groupBoxResult.Controls.Add(this.labelBMI);
            this.groupBoxResult.Location = new System.Drawing.Point(13, 216);
            this.groupBoxResult.Name = "groupBoxResult";
            this.groupBoxResult.Size = new System.Drawing.Size(396, 222);
            this.groupBoxResult.TabIndex = 24;
            this.groupBoxResult.TabStop = false;
            this.groupBoxResult.Text = "Result";
            this.groupBoxResult.Enter += new System.EventHandler(this.groupBoxResult_Enter);
            // 
            // labelBMI
            // 
            this.labelBMI.Enabled = false;
            this.labelBMI.Location = new System.Drawing.Point(90, 65);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(177, 23);
            this.labelBMI.TabIndex = 0;
            // 
            // labelBMICat
            // 
            this.labelBMICat.Enabled = false;
            this.labelBMICat.Location = new System.Drawing.Point(109, 119);
            this.labelBMICat.Name = "labelBMICat";
            this.labelBMICat.Size = new System.Drawing.Size(248, 23);
            this.labelBMICat.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 657);
            this.Controls.Add(this.textInch);
            this.Controls.Add(this.textFt);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textKg);
            this.Controls.Add(this.groupBoxResult);
            this.Controls.Add(this.groupBoxUnit);
            this.Controls.Add(this.groupBoxBMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator by Evan Huynh";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxBMI.ResumeLayout(false);
            this.groupBoxBMI.PerformLayout();
            this.groupBoxUnit.ResumeLayout(false);
            this.groupBoxUnit.PerformLayout();
            this.groupBoxResult.ResumeLayout(false);
            this.groupBoxResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox labelBMICat;
        private System.Windows.Forms.TextBox labelBMI;
    }
}