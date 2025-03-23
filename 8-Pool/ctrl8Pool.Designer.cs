namespace FirsGUNA
{
    partial class ctrl8Pool
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbTable = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nameOfTableToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.typeOfTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbTypeOfTable = new System.Windows.Forms.ToolStripComboBox();
            this.designToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfHeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfBodyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorOfSwitchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnEnd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnSwitch = new Guna.UI2.WinForms.Guna2CircleButton();
            this.picTable = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cdControl = new System.Windows.Forms.ColorDialog();
            this.gbTable.SuspendLayout();
            this.cmsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTable
            // 
            this.gbTable.BackColor = System.Drawing.Color.Transparent;
            this.gbTable.BorderColor = System.Drawing.Color.SlateBlue;
            this.gbTable.ContextMenuStrip = this.cmsTable;
            this.gbTable.Controls.Add(this.lblTimer);
            this.gbTable.Controls.Add(this.btnEnd);
            this.gbTable.Controls.Add(this.btnSwitch);
            this.gbTable.Controls.Add(this.picTable);
            this.gbTable.CustomBorderColor = System.Drawing.Color.Green;
            this.gbTable.FillColor = System.Drawing.Color.DarkSlateGray;
            this.gbTable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTable.ForeColor = System.Drawing.Color.White;
            this.gbTable.Location = new System.Drawing.Point(3, 3);
            this.gbTable.Name = "gbTable";
            this.gbTable.Size = new System.Drawing.Size(374, 257);
            this.gbTable.TabIndex = 0;
            this.gbTable.Text = "Programming Advice";
            this.gbTable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmsTable
            // 
            this.cmsTable.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameOfTableToolStripMenuItem1,
            this.typeOfTableToolStripMenuItem,
            this.designToolStripMenuItem});
            this.cmsTable.Name = "cmsTable";
            this.cmsTable.Size = new System.Drawing.Size(187, 172);
            this.cmsTable.Opening += new System.ComponentModel.CancelEventHandler(this.cmsTable_Opening_1);
            // 
            // nameOfTableToolStripMenuItem1
            // 
            this.nameOfTableToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.nameOfTableToolStripMenuItem1.Image = global::FirsGUNA.Properties.Resources.NameOfTable;
            this.nameOfTableToolStripMenuItem1.Name = "nameOfTableToolStripMenuItem1";
            this.nameOfTableToolStripMenuItem1.Size = new System.Drawing.Size(186, 56);
            this.nameOfTableToolStripMenuItem1.Text = "Name Of Table";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.TextChanged += new System.EventHandler(this.toolStripTextBox1_TextChanged);
            // 
            // typeOfTableToolStripMenuItem
            // 
            this.typeOfTableToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbTypeOfTable});
            this.typeOfTableToolStripMenuItem.Image = global::FirsGUNA.Properties.Resources.TypeOfTable;
            this.typeOfTableToolStripMenuItem.Name = "typeOfTableToolStripMenuItem";
            this.typeOfTableToolStripMenuItem.Size = new System.Drawing.Size(186, 56);
            this.typeOfTableToolStripMenuItem.Text = "Type Of Table";
            this.typeOfTableToolStripMenuItem.Click += new System.EventHandler(this.typeOfTableToolStripMenuItem_Click);
            // 
            // cbTypeOfTable
            // 
            this.cbTypeOfTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeOfTable.Items.AddRange(new object[] {
            "Normal",
            "VIP"});
            this.cbTypeOfTable.Name = "cbTypeOfTable";
            this.cbTypeOfTable.Size = new System.Drawing.Size(121, 23);
            this.cbTypeOfTable.SelectedIndexChanged += new System.EventHandler(this.cbTypeOfTable_SelectedIndexChanged);
            // 
            // designToolStripMenuItem
            // 
            this.designToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorOfHeaderToolStripMenuItem,
            this.colorOfBodyToolStripMenuItem,
            this.colorOfSwitchToolStripMenuItem});
            this.designToolStripMenuItem.Image = global::FirsGUNA.Properties.Resources.Design;
            this.designToolStripMenuItem.Name = "designToolStripMenuItem";
            this.designToolStripMenuItem.Size = new System.Drawing.Size(186, 56);
            this.designToolStripMenuItem.Text = "Design";
            // 
            // colorOfHeaderToolStripMenuItem
            // 
            this.colorOfHeaderToolStripMenuItem.Name = "colorOfHeaderToolStripMenuItem";
            this.colorOfHeaderToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorOfHeaderToolStripMenuItem.Text = "Color Of Header";
            this.colorOfHeaderToolStripMenuItem.Click += new System.EventHandler(this.colorOfHeaderToolStripMenuItem_Click);
            // 
            // colorOfBodyToolStripMenuItem
            // 
            this.colorOfBodyToolStripMenuItem.Name = "colorOfBodyToolStripMenuItem";
            this.colorOfBodyToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorOfBodyToolStripMenuItem.Text = "Color Of Body";
            this.colorOfBodyToolStripMenuItem.Click += new System.EventHandler(this.colorOfBodyToolStripMenuItem_Click);
            // 
            // colorOfSwitchToolStripMenuItem
            // 
            this.colorOfSwitchToolStripMenuItem.Name = "colorOfSwitchToolStripMenuItem";
            this.colorOfSwitchToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.colorOfSwitchToolStripMenuItem.Text = "Color Of Switch";
            this.colorOfSwitchToolStripMenuItem.Click += new System.EventHandler(this.colorOfSwitchToolStripMenuItem_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(278, 204);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(88, 21);
            this.lblTimer.TabIndex = 3;
            this.lblTimer.Text = "00 : 00 : 00";
            this.lblTimer.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnd.FillColor = System.Drawing.Color.Green;
            this.btnEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(298, 127);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEnd.Size = new System.Drawing.Size(54, 47);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "End";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSwitch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSwitch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSwitch.FillColor = System.Drawing.Color.Green;
            this.btnSwitch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(298, 74);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnSwitch.Size = new System.Drawing.Size(54, 47);
            this.btnSwitch.TabIndex = 1;
            this.btnSwitch.Tag = "On";
            this.btnSwitch.Text = "Start";
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // picTable
            // 
            this.picTable.Cursor = System.Windows.Forms.Cursors.Help;
            this.picTable.Image = global::FirsGUNA.Properties.Resources.QuestionMark;
            this.picTable.Location = new System.Drawing.Point(4, 44);
            this.picTable.Name = "picTable";
            this.picTable.Size = new System.Drawing.Size(268, 193);
            this.picTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTable.TabIndex = 0;
            this.picTable.TabStop = false;
            this.picTable.Tag = "?";
            this.picTable.DoubleClick += new System.EventHandler(this.picTable_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrl8Pool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTable);
            this.Name = "ctrl8Pool";
            this.Size = new System.Drawing.Size(380, 263);
            this.gbTable.ResumeLayout(false);
            this.gbTable.PerformLayout();
            this.cmsTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picTable;
        private Guna.UI2.WinForms.Guna2CircleButton btnEnd;
        private Guna.UI2.WinForms.Guna2CircleButton btnSwitch;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2GroupBox gbTable;
        private System.Windows.Forms.ToolStripMenuItem nameOfTableToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem typeOfTableToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdControl;
        private System.Windows.Forms.ToolStripMenuItem designToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOfHeaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOfBodyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorOfSwitchToolStripMenuItem;
        public System.Windows.Forms.ToolStripComboBox cbTypeOfTable;
        public System.Windows.Forms.ContextMenuStrip cmsTable;
    }
}
