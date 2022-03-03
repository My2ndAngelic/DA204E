using System.ComponentModel;

namespace RecipeDNC
{
    partial class FormIngredient
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
            this.groupBoxIngredient = new System.Windows.Forms.GroupBox();
            this.listBoxIngredient = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxIngredient = new System.Windows.Forms.TextBox();
            this.labelNumOfIngLeft = new System.Windows.Forms.Label();
            this.labelNumOfIngRight = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxIngredient.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIngredient
            // 
            this.groupBoxIngredient.Controls.Add(this.listBoxIngredient);
            this.groupBoxIngredient.Controls.Add(this.buttonDelete);
            this.groupBoxIngredient.Controls.Add(this.buttonEdit);
            this.groupBoxIngredient.Controls.Add(this.buttonAdd);
            this.groupBoxIngredient.Controls.Add(this.textBoxIngredient);
            this.groupBoxIngredient.Location = new System.Drawing.Point(12, 60);
            this.groupBoxIngredient.Name = "groupBoxIngredient";
            this.groupBoxIngredient.Size = new System.Drawing.Size(517, 454);
            this.groupBoxIngredient.TabIndex = 0;
            this.groupBoxIngredient.TabStop = false;
            this.groupBoxIngredient.Text = "Ingredients";
            // 
            // listBoxIngredient
            // 
            this.listBoxIngredient.FormattingEnabled = true;
            this.listBoxIngredient.ItemHeight = 15;
            this.listBoxIngredient.Location = new System.Drawing.Point(18, 85);
            this.listBoxIngredient.Name = "listBoxIngredient";
            this.listBoxIngredient.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxIngredient.Size = new System.Drawing.Size(378, 349);
            this.listBoxIngredient.TabIndex = 5;
            this.listBoxIngredient.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxIngredient_KeyDown);
            this.listBoxIngredient.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxIngredient_MouseDown);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(415, 130);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(415, 85);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(415, 41);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxIngredient
            // 
            this.textBoxIngredient.Location = new System.Drawing.Point(18, 41);
            this.textBoxIngredient.Name = "textBoxIngredient";
            this.textBoxIngredient.Size = new System.Drawing.Size(378, 23);
            this.textBoxIngredient.TabIndex = 0;
            // 
            // labelNumOfIngLeft
            // 
            this.labelNumOfIngLeft.AutoSize = true;
            this.labelNumOfIngLeft.Location = new System.Drawing.Point(12, 21);
            this.labelNumOfIngLeft.Name = "labelNumOfIngLeft";
            this.labelNumOfIngLeft.Size = new System.Drawing.Size(39, 15);
            this.labelNumOfIngLeft.TabIndex = 1;
            this.labelNumOfIngLeft.Text = "Name";
            // 
            // labelNumOfIngRight
            // 
            this.labelNumOfIngRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumOfIngRight.Location = new System.Drawing.Point(380, 21);
            this.labelNumOfIngRight.Name = "labelNumOfIngRight";
            this.labelNumOfIngRight.Size = new System.Drawing.Size(149, 15);
            this.labelNumOfIngRight.TabIndex = 2;
            this.labelNumOfIngRight.Text = "Number of ingredients:  00A";
            this.labelNumOfIngRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(160, 533);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(333, 533);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 568);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.labelNumOfIngRight);
            this.Controls.Add(this.labelNumOfIngLeft);
            this.Controls.Add(this.groupBoxIngredient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormIngredient";
            this.Text = "Ingredient Editor";
            this.groupBoxIngredient.ResumeLayout(false);
            this.groupBoxIngredient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIngredient;
        private System.Windows.Forms.TextBox textBoxIngredient;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ListBox listBoxIngredient;
        private System.Windows.Forms.Label labelNumOfIngLeft;
        private System.Windows.Forms.Label labelNumOfIngRight;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}