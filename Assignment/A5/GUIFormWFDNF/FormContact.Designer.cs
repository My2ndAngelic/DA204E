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
            this.textBoxOPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.comboBoxCountry = new System.Windows.Forms.ComboBox();
            this.groupBoxName = new System.Windows.Forms.GroupBox();
            this.groupBoxEP = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPPhone = new System.Windows.Forms.TextBox();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.textBoxZipcode = new System.Windows.Forms.TextBox();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.groupBoxName.SuspendLayout();
            this.groupBoxEP.SuspendLayout();
            this.groupBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFName
            // 
            this.textBoxFName.Location = new System.Drawing.Point(166, 27);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(398, 20);
            this.textBoxFName.TabIndex = 0;
            // 
            // textBoxLName
            // 
            this.textBoxLName.Location = new System.Drawing.Point(166, 71);
            this.textBoxLName.Name = "textBoxLName";
            this.textBoxLName.Size = new System.Drawing.Size(398, 20);
            this.textBoxLName.TabIndex = 1;
            // 
            // textBoxOMail
            // 
            this.textBoxOMail.Location = new System.Drawing.Point(162, 29);
            this.textBoxOMail.Name = "textBoxOMail";
            this.textBoxOMail.Size = new System.Drawing.Size(398, 20);
            this.textBoxOMail.TabIndex = 2;
            // 
            // textBoxPMail
            // 
            this.textBoxPMail.Location = new System.Drawing.Point(162, 67);
            this.textBoxPMail.Name = "textBoxPMail";
            this.textBoxPMail.Size = new System.Drawing.Size(398, 20);
            this.textBoxPMail.TabIndex = 3;
            // 
            // textBoxOPhone
            // 
            this.textBoxOPhone.Location = new System.Drawing.Point(162, 108);
            this.textBoxOPhone.Name = "textBoxOPhone";
            this.textBoxOPhone.Size = new System.Drawing.Size(398, 20);
            this.textBoxOPhone.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(11, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Office Email";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(11, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personal Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(11, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Office Phone";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(10, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Country";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(73, 654);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(135, 55);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(441, 654);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(135, 55);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // comboBoxCountry
            // 
            this.comboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCountry.FormattingEnabled = true;
            this.comboBoxCountry.Location = new System.Drawing.Point(161, 167);
            this.comboBoxCountry.Name = "comboBoxCountry";
            this.comboBoxCountry.Size = new System.Drawing.Size(398, 21);
            this.comboBoxCountry.TabIndex = 18;
            // 
            // groupBoxName
            // 
            this.groupBoxName.Controls.Add(this.label2);
            this.groupBoxName.Controls.Add(this.label1);
            this.groupBoxName.Controls.Add(this.textBoxLName);
            this.groupBoxName.Controls.Add(this.textBoxFName);
            this.groupBoxName.Location = new System.Drawing.Point(12, 25);
            this.groupBoxName.Name = "groupBoxName";
            this.groupBoxName.Size = new System.Drawing.Size(594, 114);
            this.groupBoxName.TabIndex = 19;
            this.groupBoxName.TabStop = false;
            this.groupBoxName.Text = "groupBoxName";
            // 
            // groupBoxEP
            // 
            this.groupBoxEP.Controls.Add(this.label10);
            this.groupBoxEP.Controls.Add(this.textBoxPPhone);
            this.groupBoxEP.Controls.Add(this.label5);
            this.groupBoxEP.Controls.Add(this.label4);
            this.groupBoxEP.Controls.Add(this.label3);
            this.groupBoxEP.Controls.Add(this.textBoxOPhone);
            this.groupBoxEP.Controls.Add(this.textBoxPMail);
            this.groupBoxEP.Controls.Add(this.textBoxOMail);
            this.groupBoxEP.Location = new System.Drawing.Point(16, 168);
            this.groupBoxEP.Name = "groupBoxEP";
            this.groupBoxEP.Size = new System.Drawing.Size(590, 201);
            this.groupBoxEP.TabIndex = 20;
            this.groupBoxEP.TabStop = false;
            this.groupBoxEP.Text = "groupBox2";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(11, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 14;
            this.label10.Text = "Home Number";
            // 
            // textBoxPPhone
            // 
            this.textBoxPPhone.Location = new System.Drawing.Point(162, 151);
            this.textBoxPPhone.Name = "textBoxPPhone";
            this.textBoxPPhone.Size = new System.Drawing.Size(398, 20);
            this.textBoxPPhone.TabIndex = 13;
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(161, 35);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(398, 20);
            this.textBoxStreet.TabIndex = 21;
            // 
            // textBoxZipcode
            // 
            this.textBoxZipcode.Location = new System.Drawing.Point(161, 119);
            this.textBoxZipcode.Name = "textBoxZipcode";
            this.textBoxZipcode.Size = new System.Drawing.Size(398, 20);
            this.textBoxZipcode.TabIndex = 22;
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(161, 77);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.Size = new System.Drawing.Size(398, 20);
            this.textBoxCity.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 24;
            this.label7.Text = "Street";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(10, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 25;
            this.label8.Text = "City";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(10, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 26;
            this.label9.Text = "Zip code";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.label9);
            this.groupBoxAddress.Controls.Add(this.label8);
            this.groupBoxAddress.Controls.Add(this.label7);
            this.groupBoxAddress.Controls.Add(this.textBoxCity);
            this.groupBoxAddress.Controls.Add(this.textBoxZipcode);
            this.groupBoxAddress.Controls.Add(this.textBoxStreet);
            this.groupBoxAddress.Controls.Add(this.comboBoxCountry);
            this.groupBoxAddress.Controls.Add(this.label6);
            this.groupBoxAddress.Location = new System.Drawing.Point(12, 398);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(589, 231);
            this.groupBoxAddress.TabIndex = 27;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "groupBox3";
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 721);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxEP);
            this.Controls.Add(this.groupBoxName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "FormContact";
            this.Text = "FormContact";
            this.groupBoxName.ResumeLayout(false);
            this.groupBoxName.PerformLayout();
            this.groupBoxEP.ResumeLayout(false);
            this.groupBoxEP.PerformLayout();
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPPhone;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxAddress;

        private System.Windows.Forms.GroupBox groupBoxName;
        private System.Windows.Forms.GroupBox groupBoxEP;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.TextBox textBoxZipcode;
        private System.Windows.Forms.TextBox textBoxCity;

        private System.Windows.Forms.ComboBox comboBoxCountry;

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxLName;
        private System.Windows.Forms.TextBox textBoxOMail;
        private System.Windows.Forms.TextBox textBoxPMail;
        private System.Windows.Forms.TextBox textBoxOPhone;
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