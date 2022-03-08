using System.ComponentModel;

namespace GUIFormWFDNF
{
    partial class FormContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxLName = new System.Windows.Forms.TextBox();
            this.textBoxOMail = new System.Windows.Forms.TextBox();
            this.textBoxPMail = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(178, 55);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(398, 20);
            this.textBoxFName.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(178, 123);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(398, 20);
            this.textBoxLName.TabIndex = 1;
            // 
            // textBoxOMail
            // 
            this.textBoxOMail.Location = new System.Drawing.Point(178, 201);
            this.textBoxOMail.Name = "textBoxOMail";
            this.textBoxOMail.Size = new System.Drawing.Size(398, 20);
            this.textBoxOMail.TabIndex = 2;
            // 
            // textBoxPMail
            // 
            this.textBoxPMail.Location = new System.Drawing.Point(178, 265);
            this.textBoxPMail.Name = "textBoxPMail";
            this.textBoxPMail.Size = new System.Drawing.Size(398, 20);
            this.textBoxPMail.TabIndex = 3;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(178, 321);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(398, 20);
            this.textBoxPhone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(27, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(27, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Office Email";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(27, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personal Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(27, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(27, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Country";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(82, 553);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(135, 55);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(395, 553);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 55);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(178, 372);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(398, 21);
            this.comboBoxCountry.TabIndex = 18;
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 637);
            this.Controls.Add(this.comboBoxCountry);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPMail);
            this.Controls.Add(this.textBoxOMail);
            this.Controls.Add(this.textBoxLName);
            this.Controls.Add(this.textBoxFName);
            this.Name = "FormContact";
            this.Text = "FormContact";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxCountry;

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxOMail;
        private System.Windows.Forms.TextBox textBoxPMail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonCancel;

        #endregion
    }
}