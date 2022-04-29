namespace GUIWFDNF4
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.listBoxReminders = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.comboBoxPrioList = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.labelDateAndTime = new System.Windows.Forms.Label();
            this.labelPrioList = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelTimeList = new System.Windows.Forms.Label();
            this.labelPriorityList = new System.Windows.Forms.Label();
            this.labelDesciptionList = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxReminders
            // 
            this.listBoxReminders.FormattingEnabled = true;
            this.listBoxReminders.Location = new System.Drawing.Point(64, 211);
            this.listBoxReminders.Name = "listBoxReminders";
            this.listBoxReminders.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxReminders.Size = new System.Drawing.Size(841, 355);
            this.listBoxReminders.TabIndex = 4;
            this.listBoxReminders.SelectedIndexChanged += new System.EventHandler(this.listBoxReminder_SelectedIndexChanged);
            this.listBoxReminders.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxDescription_KeyDown);
            this.listBoxReminders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxDescription_MouseDown);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(170, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(178, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dateTimePicker1, "Change the date");
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(170, 141);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(178, 20);
            this.textBoxDescription.TabIndex = 2;
            // 
            // comboBoxPrioList
            // 
            this.comboBoxPrioList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrioList.FormattingEnabled = true;
            this.comboBoxPrioList.Location = new System.Drawing.Point(170, 89);
            this.comboBoxPrioList.Name = "comboBoxPrioList";
            this.comboBoxPrioList.Size = new System.Drawing.Size(178, 21);
            this.comboBoxPrioList.TabIndex = 3;
            this.toolTip1.SetToolTip(this.comboBoxPrioList, "Select the priority task");
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(64, 589);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 39);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(227, 589);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(109, 39);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(397, 589);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(109, 39);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItemNew, this.toolStripSeparator1, this.toolStripMenuItemOpen, this.toolStripMenuItemSave, this.toolStripSeparator2, this.toolStripMenuItemExit});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItemFile.Text = "File";
            // 
            // toolStripMenuItemNew
            // 
            this.toolStripMenuItemNew.Name = "toolStripMenuItemNew";
            this.toolStripMenuItemNew.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemNew.Text = "New";
            this.toolStripMenuItemNew.Click += new System.EventHandler(this.toolStripMenuItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemOpen.Text = "Open";
            this.toolStripMenuItemOpen.Click += new System.EventHandler(this.toolStripMenuItemOpen_Click);
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemSave.Text = "Save";
            this.toolStripMenuItemSave.Click += new System.EventHandler(this.toolStripMenuItemSave_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItemAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.toolStripMenuItemFile, this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // labelDateAndTime
            // 
            this.labelDateAndTime.Location = new System.Drawing.Point(64, 44);
            this.labelDateAndTime.Name = "labelDateAndTime";
            this.labelDateAndTime.Size = new System.Drawing.Size(100, 20);
            this.labelDateAndTime.TabIndex = 8;
            this.labelDateAndTime.Text = "labelDateAndTime";
            // 
            // labelPrioList
            // 
            this.labelPrioList.Location = new System.Drawing.Point(64, 92);
            this.labelPrioList.Name = "labelPrioList";
            this.labelPrioList.Size = new System.Drawing.Size(100, 23);
            this.labelPrioList.TabIndex = 9;
            this.labelPrioList.Text = "labelPrioList";
            // 
            // labelDescription
            // 
            this.labelDescription.Location = new System.Drawing.Point(64, 144);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(100, 23);
            this.labelDescription.TabIndex = 10;
            this.labelDescription.Text = "labelDescription";
            // 
            // labelTimeList
            // 
            this.labelTimeList.Location = new System.Drawing.Point(64, 188);
            this.labelTimeList.Name = "labelTimeList";
            this.labelTimeList.Size = new System.Drawing.Size(100, 23);
            this.labelTimeList.TabIndex = 11;
            this.labelTimeList.Text = "labelTimeList";
            // 
            // labelPriorityList
            // 
            this.labelPriorityList.Location = new System.Drawing.Point(255, 188);
            this.labelPriorityList.Name = "labelPriorityList";
            this.labelPriorityList.Size = new System.Drawing.Size(100, 23);
            this.labelPriorityList.TabIndex = 12;
            this.labelPriorityList.Text = "labelPriorityList";
            // 
            // labelDesciptionList
            // 
            this.labelDesciptionList.Location = new System.Drawing.Point(397, 188);
            this.labelDesciptionList.Name = "labelDesciptionList";
            this.labelDesciptionList.Size = new System.Drawing.Size(100, 23);
            this.labelDesciptionList.TabIndex = 13;
            this.labelDesciptionList.Text = "labelDesciptionList";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelCurrentTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelCurrentTime.Location = new System.Drawing.Point(770, 589);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(135, 39);
            this.labelCurrentTime.TabIndex = 14;
            this.labelCurrentTime.Text = "labelCurrentTime";
            this.labelCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 668);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.labelDesciptionList);
            this.Controls.Add(this.labelPriorityList);
            this.Controls.Add(this.labelTimeList);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelPrioList);
            this.Controls.Add(this.labelDateAndTime);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxPrioList);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBoxReminders);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMain_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelCurrentTime;

        private System.Windows.Forms.Timer timer;

        private System.Windows.Forms.ToolTip toolTip1;

        private System.Windows.Forms.Label labelDateAndTime;
        private System.Windows.Forms.Label labelPrioList;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelTimeList;
        private System.Windows.Forms.Label labelPriorityList;
        private System.Windows.Forms.Label labelDesciptionList;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;

        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;

        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemNew;

        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;

        private System.Windows.Forms.MenuStrip menuStrip1;

        private System.Windows.Forms.ComboBox comboBoxPrioList;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDescription;

        private System.Windows.Forms.ListBox listBoxReminders;

        #endregion
    }
}