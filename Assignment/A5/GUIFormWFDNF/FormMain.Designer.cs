namespace GUIFormWFDNF
{
    partial class FormMain
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listboxContact = new System.Windows.Forms.ListBox();
            this.textBoxContact = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 405);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 35);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listboxContact
            // 
            this.listboxContact.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listboxContact.FormattingEnabled = true;
            this.listboxContact.Location = new System.Drawing.Point(12, 48);
            this.listboxContact.Name = "listboxContact";
            this.listboxContact.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxContact.Size = new System.Drawing.Size(619, 342);
            this.listboxContact.TabIndex = 0;
            this.listboxContact.SelectedIndexChanged += new System.EventHandler(this.listboxContact_SelectedIndexChanged);
            this.listboxContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listboxContact_KeyDown);
            this.listboxContact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxContact_MouseDown);
            // 
            // textBoxContact
            // 
            this.textBoxContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxContact.Location = new System.Drawing.Point(652, 48);
            this.textBoxContact.Margin = new System.Windows.Forms.Padding(100);
            this.textBoxContact.Multiline = true;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(299, 392);
            this.textBoxContact.TabIndex = 4;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(261, 405);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(125, 35);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(506, 405);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelID
            // 
            this.labelID.Location = new System.Drawing.Point(31, 23);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(44, 22);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "labelID";
            // 
            // labelName
            // 
            this.labelName.Location = new System.Drawing.Point(142, 23);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 22);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "labelName";
            // 
            // labelPhone
            // 
            this.labelPhone.Location = new System.Drawing.Point(363, 23);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(104, 22);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "labelPhone";
            // 
            // labelEmail
            // 
            this.labelEmail.Location = new System.Drawing.Point(485, 23);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(69, 22);
            this.labelEmail.TabIndex = 12;
            this.labelEmail.Text = "labelEmail";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 459);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxContact);
            this.Controls.Add(this.listboxContact);
            this.Controls.Add(this.buttonAdd);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelEmail;

        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Button buttonEdit;

        private System.Windows.Forms.ListBox listboxContact;
        private System.Windows.Forms.TextBox textBoxContact;

        #endregion
    }
}

