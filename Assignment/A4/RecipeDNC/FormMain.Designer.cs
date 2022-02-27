
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
            this.labelName = new System.Windows.Forms.Label();
            this.listBoxRecipe = new System.Windows.Forms.ListBox();
            this.buttonEditBegin = new System.Windows.Forms.Button();
            this.buttonEditFinish = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.labelMode = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 600);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recipe Editor";
            // 
            // buttonAddIngredients
            // 
            this.buttonAddIngredients.Location = new System.Drawing.Point(334, 36);
            this.buttonAddIngredients.Name = "buttonAddIngredients";
            this.buttonAddIngredients.Size = new System.Drawing.Size(114, 70);
            this.buttonAddIngredients.TabIndex = 6;
            this.buttonAddIngredients.Text = "Edit ingredients";
            this.buttonAddIngredients.UseVisualStyleBackColor = true;
            this.buttonAddIngredients.Click += new System.EventHandler(this.buttonAddIngredients_Click);
            // 
            // buttonAddRecipe
            // 
            this.buttonAddRecipe.Location = new System.Drawing.Point(15, 538);
            this.buttonAddRecipe.Name = "buttonAddRecipe";
            this.buttonAddRecipe.Size = new System.Drawing.Size(433, 45);
            this.buttonAddRecipe.TabIndex = 5;
            this.buttonAddRecipe.Text = "Add Recipe";
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
            this.labelCategory.Location = new System.Drawing.Point(15, 91);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(55, 15);
            this.labelCategory.TabIndex = 3;
            this.labelCategory.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(76, 88);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(223, 23);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(76, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(223, 23);
            this.textBoxName.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(15, 39);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // listBoxRecipe
            // 
            this.listBoxRecipe.FormattingEnabled = true;
            this.listBoxRecipe.ItemHeight = 15;
            this.listBoxRecipe.Location = new System.Drawing.Point(520, 140);
            this.listBoxRecipe.Name = "listBoxRecipe";
            this.listBoxRecipe.Size = new System.Drawing.Size(567, 394);
            this.listBoxRecipe.TabIndex = 1;
            this.listBoxRecipe.SelectedIndexChanged += new System.EventHandler(this.listBoxRecipe_SelectedIndexChanged);
            this.listBoxRecipe.DoubleClick += new System.EventHandler(this.listBoxRecipe_DoubleClick);
            // 
            // buttonEditBegin
            // 
            this.buttonEditBegin.Location = new System.Drawing.Point(520, 551);
            this.buttonEditBegin.Name = "buttonEditBegin";
            this.buttonEditBegin.Size = new System.Drawing.Size(99, 45);
            this.buttonEditBegin.TabIndex = 2;
            this.buttonEditBegin.Text = "Begin Editing";
            this.buttonEditBegin.UseVisualStyleBackColor = true;
            this.buttonEditBegin.Click += new System.EventHandler(this.buttonEditBegin_Click);
            // 
            // buttonEditFinish
            // 
            this.buttonEditFinish.Location = new System.Drawing.Point(675, 551);
            this.buttonEditFinish.Name = "buttonEditFinish";
            this.buttonEditFinish.Size = new System.Drawing.Size(99, 45);
            this.buttonEditFinish.TabIndex = 3;
            this.buttonEditFinish.Text = "Finish Editing";
            this.buttonEditFinish.UseVisualStyleBackColor = true;
            this.buttonEditFinish.Click += new System.EventHandler(this.buttonEditFinish_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(834, 551);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(99, 45);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Location = new System.Drawing.Point(988, 551);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(99, 45);
            this.buttonClearAll.TabIndex = 5;
            this.buttonClearAll.Text = "Clear All";
            this.buttonClearAll.UseVisualStyleBackColor = true;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // labelMode
            // 
            this.labelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMode.Location = new System.Drawing.Point(988, 12);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(99, 27);
            this.labelMode.TabIndex = 6;
            this.labelMode.Text = "Edit Mode";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 634);
            this.Controls.Add(this.labelMode);
            this.Controls.Add(this.buttonClearAll);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEditFinish);
            this.Controls.Add(this.buttonEditBegin);
            this.Controls.Add(this.listBoxRecipe);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "Apu Recipe Book by Evan Huynh";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelName;
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
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Label labelMode;
    }
}