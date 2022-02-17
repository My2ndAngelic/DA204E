
namespace RecipeDNC
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddIngredients = new System.Windows.Forms.Button();
            this.buttonAddRecipe = new System.Windows.Forms.Button();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxRecipe = new System.Windows.Forms.ListBox();
            this.buttonEditBegin = new System.Windows.Forms.Button();
            this.buttonEditFinish = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClearSelection = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddIngredients);
            this.groupBox1.Controls.Add(this.buttonAddRecipe);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.labelCategory);
            this.groupBox1.Controls.Add(this.comboBoxCategory);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonAddIngredients
            // 
            this.buttonAddIngredients.Location = new System.Drawing.Point(373, 87);
            this.buttonAddIngredients.Name = "buttonAddIngredients";
            this.buttonAddIngredients.Size = new System.Drawing.Size(75, 23);
            this.buttonAddIngredients.TabIndex = 6;
            this.buttonAddIngredients.Text = "AddIngredients";
            this.buttonAddIngredients.UseVisualStyleBackColor = true;
            this.buttonAddIngredients.Click += new System.EventHandler(this.buttonAddIngredients_Click);
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(30, 538);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(404, 46);
            this.buttonAddRecipe.TabIndex = 5;
            this.buttonAddRecipe.Text = "AddRecipe";
            this.buttonAddRecipe.UseVisualStyleBackColor = true;
            this.buttonAddRecipe.Click += new System.EventHandler(this.buttonAddRecipe_Click);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(15, 128);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(433, 394);
            this.textBoxDescription.TabIndex = 4;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(6, 91);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(38, 15);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "label2";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(124, 88);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(223, 23);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(124, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // listBoxRecipe
            // 
            this.listBoxRecipe.FormattingEnabled = true;
            this.listBoxRecipe.ItemHeight = 15;
            this.listBoxRecipe.Location = new System.Drawing.Point(520, 140);
            this.listBoxRecipe.Name = "listBoxRecipe";
            this.listBoxRecipe.Size = new System.Drawing.Size(530, 394);
            this.listBoxRecipe.TabIndex = 1;
            this.listBoxRecipe.DoubleClick += new System.EventHandler(listBoxRecipe_DoubleClick);
            // 
            // buttonEditBegin
            // 
            this.buttonEditBegin.Location = new System.Drawing.Point(520, 551);
            this.buttonEditBegin.Name = "buttonEditBegin";
            this.buttonEditBegin.Size = new System.Drawing.Size(99, 45);
            this.buttonEditBegin.TabIndex = 2;
            this.buttonEditBegin.Text = "Edit Begin";
            this.buttonEditBegin.UseVisualStyleBackColor = true;
            this.buttonEditBegin.Click += new System.EventHandler(this.buttonEditBegin_Click);
            // 
            // buttonEditFinish
            // 
            this.buttonEditFinish.Location = new System.Drawing.Point(670, 551);
            this.buttonEditFinish.Name = "buttonEditFinish";
            this.buttonEditFinish.Size = new System.Drawing.Size(99, 46);
            this.buttonEditFinish.TabIndex = 3;
            this.buttonEditFinish.Text = "EditFinish";
            this.buttonEditFinish.UseVisualStyleBackColor = true;
            this.buttonEditFinish.Click += new System.EventHandler(this.buttonEditFinish_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(813, 551);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 46);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClearSelection
            // 
            this.buttonClearSelection.Location = new System.Drawing.Point(951, 551);
            this.buttonClearSelection.Name = "buttonClearSelection";
            this.buttonClearSelection.Size = new System.Drawing.Size(99, 46);
            this.buttonClearSelection.TabIndex = 5;
            this.buttonClearSelection.Text = "ClearSelection";
            this.buttonClearSelection.UseVisualStyleBackColor = true;
            this.buttonClearSelection.Click += new System.EventHandler(this.buttonClearSelection_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 634);
            this.Controls.Add(this.buttonClearSelection);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEditFinish);
            this.Controls.Add(this.buttonEditBegin);
            this.Controls.Add(this.listBoxRecipe);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonAddRecipe;
        private System.Windows.Forms.Button buttonAddIngredients;
        private System.Windows.Forms.ListBox listBoxRecipe;
        private System.Windows.Forms.Button buttonEditBegin;
        private System.Windows.Forms.Button buttonEditFinish;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClearSelection;
    }
}