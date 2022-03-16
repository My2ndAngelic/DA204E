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
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.buttonAdd100 = new System.Windows.Forms.Button();
            this.buttonAdd1 = new System.Windows.Forms.Button();
            this.buttonAdd10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(19, 437);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listboxContact
            // 
            this.listboxContact.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.listboxContact.FormattingEnabled = true;
            this.listboxContact.Location = new System.Drawing.Point(19, 80);
            this.listboxContact.Name = "listboxContact";
            this.listboxContact.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listboxContact.Size = new System.Drawing.Size(530, 342);
            this.listboxContact.TabIndex = 1;
            this.listboxContact.SelectedIndexChanged += new System.EventHandler(this.listboxContact_SelectedIndexChanged);
            this.listboxContact.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listboxContact_KeyDown);
            this.listboxContact.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listboxContact_MouseDown);
            // 
            // textBoxContact
            // 
            this.textBoxContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxContact.Location = new System.Drawing.Point(587, 80);
            this.textBoxContact.Multiline = true;
            this.textBoxContact.Name = "textBoxContact";
            this.textBoxContact.Size = new System.Drawing.Size(299, 342);
            this.textBoxContact.TabIndex = 2;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(219, 437);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(125, 35);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(423, 437);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 35);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxTest
            // 
            this.textBoxTest.Enabled = false;
            this.textBoxTest.Location = new System.Drawing.Point(587, 444);
            this.textBoxTest.Multiline = true;
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(299, 132);
            this.textBoxTest.TabIndex = 5;
            // 
            // buttonAdd100
            // 
            this.buttonAdd100.Location = new System.Drawing.Point(423, 23);
            this.buttonAdd100.Name = "buttonAdd100";
            this.buttonAdd100.Size = new System.Drawing.Size(125, 35);
            this.buttonAdd100.TabIndex = 6;
            this.buttonAdd100.Text = "Add 100";
            this.buttonAdd100.UseVisualStyleBackColor = true;
            this.buttonAdd100.Click += new System.EventHandler(this.buttonAdd100_Click);
            // 
            // buttonAdd1
            // 
            this.buttonAdd1.Location = new System.Drawing.Point(19, 23);
            this.buttonAdd1.Name = "buttonAdd1";
            this.buttonAdd1.Size = new System.Drawing.Size(125, 35);
            this.buttonAdd1.TabIndex = 7;
            this.buttonAdd1.Text = "Add 1";
            this.buttonAdd1.UseVisualStyleBackColor = true;
            this.buttonAdd1.Click += new System.EventHandler(this.buttonAdd1_Click);
            // 
            // buttonAdd10
            // 
            this.buttonAdd10.Location = new System.Drawing.Point(219, 23);
            this.buttonAdd10.Name = "buttonAdd10";
            this.buttonAdd10.Size = new System.Drawing.Size(125, 35);
            this.buttonAdd10.TabIndex = 8;
            this.buttonAdd10.Text = "Add 10";
            this.buttonAdd10.UseVisualStyleBackColor = true;
            this.buttonAdd10.Click += new System.EventHandler(this.buttonAdd10_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 599);
            this.Controls.Add(this.buttonAdd10);
            this.Controls.Add(this.buttonAdd1);
            this.Controls.Add(this.buttonAdd100);
            this.Controls.Add(this.textBoxTest);
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

        private System.Windows.Forms.Button buttonAdd1;
        private System.Windows.Forms.Button buttonAdd10;

        private System.Windows.Forms.Button buttonAdd100;

        private System.Windows.Forms.TextBox textBoxTest;

        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Button buttonEdit;

        private System.Windows.Forms.ListBox listboxContact;
        private System.Windows.Forms.TextBox textBoxContact;

        #endregion
    }
}

