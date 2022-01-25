
namespace BMICalculator
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
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeight = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.labelNameDisp = new System.Windows.Forms.Label();
            this.rbUS = new System.Windows.Forms.RadioButton();
            this.rbSI = new System.Windows.Forms.RadioButton();
            this.buttonCalculateBMI = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelBMI = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(153, 83);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(100, 23);
            this.textHeight.TabIndex = 4;
            this.textHeight.TextChanged += new System.EventHandler(this.textHeight_TextChanged);
            // 
            // textWeight
            // 
            this.textWeight.Location = new System.Drawing.Point(153, 113);
            this.textWeight.Name = "textWeight";
            this.textWeight.Size = new System.Drawing.Size(100, 23);
            this.textWeight.TabIndex = 5;
            this.textWeight.TextChanged += new System.EventHandler(this.textWeight_TextChanged);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(153, 49);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 23);
            this.textName.TabIndex = 6;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // labelNameDisp
            // 
            this.labelNameDisp.AutoSize = true;
            this.labelNameDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNameDisp.Location = new System.Drawing.Point(153, 241);
            this.labelNameDisp.Name = "labelNameDisp";
            this.labelNameDisp.Size = new System.Drawing.Size(2, 17);
            this.labelNameDisp.TabIndex = 9;
            this.labelNameDisp.Click += new System.EventHandler(this.labelWeight_Click);
            // 
            // rbUS
            // 
            this.rbUS.AutoSize = true;
            this.rbUS.Location = new System.Drawing.Point(553, 72);
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
            this.rbSI.Location = new System.Drawing.Point(553, 97);
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
            this.buttonCalculateBMI.Location = new System.Drawing.Point(97, 179);
            this.buttonCalculateBMI.Name = "buttonCalculateBMI";
            this.buttonCalculateBMI.Size = new System.Drawing.Size(156, 23);
            this.buttonCalculateBMI.TabIndex = 12;
            this.buttonCalculateBMI.Text = "Calculate BMI";
            this.buttonCalculateBMI.UseVisualStyleBackColor = true;
            this.buttonCalculateBMI.Click += new System.EventHandler(this.buttonCalculateBMI_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 49);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Name";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(21, 83);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(43, 15);
            this.labelHeight.TabIndex = 14;
            this.labelHeight.Text = "Height";
            this.labelHeight.Click += new System.EventHandler(this.labelHeight_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(21, 116);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(45, 15);
            this.labelWeight.TabIndex = 15;
            this.labelWeight.Text = "Weight";
            this.labelWeight.Click += new System.EventHandler(this.labelWeight_Click);
            // 
            // labelBMI
            // 
            this.labelBMI.AutoSize = true;
            this.labelBMI.Location = new System.Drawing.Point(153, 287);
            this.labelBMI.Name = "labelBMI";
            this.labelBMI.Size = new System.Drawing.Size(53, 15);
            this.labelBMI.TabIndex = 16;
            this.labelBMI.Text = "labelBMI";
            this.labelBMI.Click += new System.EventHandler(this.labelBMI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelBMI);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonCalculateBMI);
            this.Controls.Add(this.rbSI);
            this.Controls.Add(this.rbUS);
            this.Controls.Add(this.labelNameDisp);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textWeight);
            this.Controls.Add(this.textHeight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator by Evan Huynh";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWeight;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label labelNameDisp;
        private System.Windows.Forms.RadioButton rbUS;
        private System.Windows.Forms.RadioButton rbSI;
        private System.Windows.Forms.Button buttonCalculateBMI;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelBMI;
    }
}