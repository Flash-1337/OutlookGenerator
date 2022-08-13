namespace OutlookGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.topLeftLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.generateButton = new Guna.UI2.WinForms.Guna2Button();
            this.closeButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.accountGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountNumericUpDown = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.amountLabel = new System.Windows.Forms.Label();
            this.clearButton = new Guna.UI2.WinForms.Guna2Button();
            this.openLaunchFolderButton = new Guna.UI2.WinForms.Guna2Button();
            this.copyButton = new Guna.UI2.WinForms.Guna2Button();
            this.removeAccountButton = new Guna.UI2.WinForms.Guna2Button();
            this.driverComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // borderlessForm
            // 
            this.borderlessForm.BorderRadius = 7;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.DragStartTransparencyValue = 1D;
            this.borderlessForm.ResizeForm = false;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // topLeftLabel
            // 
            this.topLeftLabel.AutoSize = true;
            this.topLeftLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftLabel.Location = new System.Drawing.Point(43, 10);
            this.topLeftLabel.Name = "topLeftLabel";
            this.topLeftLabel.Size = new System.Drawing.Size(260, 25);
            this.topLeftLabel.TabIndex = 0;
            this.topLeftLabel.Text = "Outlook Account Generator";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(25, 25);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // generateButton
            // 
            this.generateButton.Animated = true;
            this.generateButton.BorderRadius = 3;
            this.generateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.generateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.generateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.generateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.generateButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.generateButton.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(12, 289);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(407, 45);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Animated = true;
            this.closeButton.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.closeButton.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.closeButton.HoverState.IconColor = System.Drawing.SystemColors.Window;
            this.closeButton.IconColor = System.Drawing.SystemColors.Window;
            this.closeButton.Location = new System.Drawing.Point(655, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // accountGridView
            // 
            this.accountGridView.AllowUserToAddRows = false;
            this.accountGridView.AllowUserToDeleteRows = false;
            this.accountGridView.AllowUserToResizeColumns = false;
            this.accountGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.accountGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.accountGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accountGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.accountGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.accountGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.accountGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.accountGridView.ColumnHeadersHeight = 20;
            this.accountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accountGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Password});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.accountGridView.DefaultCellStyle = dataGridViewCellStyle7;
            this.accountGridView.EnableHeadersVisualStyles = false;
            this.accountGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountGridView.Location = new System.Drawing.Point(12, 41);
            this.accountGridView.MultiSelect = false;
            this.accountGridView.Name = "accountGridView";
            this.accountGridView.ReadOnly = true;
            this.accountGridView.RowHeadersVisible = false;
            this.accountGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.accountGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.accountGridView.RowTemplate.Height = 20;
            this.accountGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accountGridView.ShowCellErrors = false;
            this.accountGridView.ShowCellToolTips = false;
            this.accountGridView.ShowEditingIcon = false;
            this.accountGridView.ShowRowErrors = false;
            this.accountGridView.Size = new System.Drawing.Size(407, 242);
            this.accountGridView.TabIndex = 4;
            this.accountGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.accountGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.accountGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.accountGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.accountGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.accountGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.accountGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.accountGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.accountGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.accountGridView.ThemeStyle.HeaderStyle.Height = 20;
            this.accountGridView.ThemeStyle.ReadOnly = true;
            this.accountGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.accountGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.accountGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.accountGridView.ThemeStyle.RowsStyle.Height = 20;
            this.accountGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Email";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.BackColor = System.Drawing.Color.Transparent;
            this.amountNumericUpDown.BorderThickness = 0;
            this.amountNumericUpDown.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountNumericUpDown.DisabledState.ForeColor = System.Drawing.Color.White;
            this.amountNumericUpDown.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.amountNumericUpDown.FocusedState.ForeColor = System.Drawing.Color.White;
            this.amountNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.amountNumericUpDown.Location = new System.Drawing.Point(568, 41);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 36);
            this.amountNumericUpDown.TabIndex = 5;
            this.amountNumericUpDown.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.amountNumericUpDown.UpDownButtonForeColor = System.Drawing.Color.White;
            this.amountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(426, 50);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(136, 17);
            this.amountLabel.TabIndex = 6;
            this.amountLabel.Text = "Amount to generate:";
            // 
            // clearButton
            // 
            this.clearButton.Animated = true;
            this.clearButton.BorderRadius = 3;
            this.clearButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(425, 83);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(263, 45);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear Saved Accounts";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openLaunchFolderButton
            // 
            this.openLaunchFolderButton.Animated = true;
            this.openLaunchFolderButton.BorderRadius = 3;
            this.openLaunchFolderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.openLaunchFolderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.openLaunchFolderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.openLaunchFolderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.openLaunchFolderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.openLaunchFolderButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLaunchFolderButton.ForeColor = System.Drawing.Color.White;
            this.openLaunchFolderButton.Location = new System.Drawing.Point(425, 185);
            this.openLaunchFolderButton.Name = "openLaunchFolderButton";
            this.openLaunchFolderButton.Size = new System.Drawing.Size(263, 45);
            this.openLaunchFolderButton.TabIndex = 8;
            this.openLaunchFolderButton.Text = "Open Launch Folder";
            this.openLaunchFolderButton.Click += new System.EventHandler(this.openLaunchFolder_Click);
            // 
            // copyButton
            // 
            this.copyButton.Animated = true;
            this.copyButton.BorderRadius = 3;
            this.copyButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.copyButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.copyButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.copyButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.copyButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.copyButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.ForeColor = System.Drawing.Color.White;
            this.copyButton.Location = new System.Drawing.Point(425, 236);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(263, 45);
            this.copyButton.TabIndex = 9;
            this.copyButton.Text = "Copy Selected Alt\'s Info";
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // removeAccountButton
            // 
            this.removeAccountButton.Animated = true;
            this.removeAccountButton.BorderRadius = 3;
            this.removeAccountButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.removeAccountButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.removeAccountButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.removeAccountButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.removeAccountButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.removeAccountButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeAccountButton.ForeColor = System.Drawing.Color.White;
            this.removeAccountButton.Location = new System.Drawing.Point(425, 134);
            this.removeAccountButton.Name = "removeAccountButton";
            this.removeAccountButton.Size = new System.Drawing.Size(263, 45);
            this.removeAccountButton.TabIndex = 10;
            this.removeAccountButton.Text = "Remove Selected Account";
            this.removeAccountButton.Click += new System.EventHandler(this.removeAccountButton_Click);
            // 
            // driverComboBox
            // 
            this.driverComboBox.BackColor = System.Drawing.Color.Transparent;
            this.driverComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.driverComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.driverComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driverComboBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.driverComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.driverComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.driverComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.driverComboBox.ForeColor = System.Drawing.Color.White;
            this.driverComboBox.ItemHeight = 30;
            this.driverComboBox.Location = new System.Drawing.Point(425, 289);
            this.driverComboBox.Name = "driverComboBox";
            this.driverComboBox.Size = new System.Drawing.Size(263, 36);
            this.driverComboBox.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(700, 346);
            this.Controls.Add(this.driverComboBox);
            this.Controls.Add(this.removeAccountButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.openLaunchFolderButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountNumericUpDown);
            this.Controls.Add(this.accountGridView);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.topLeftLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Text = "Outlook Generator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.Label topLeftLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private Guna.UI2.WinForms.Guna2Button generateButton;
        private Guna.UI2.WinForms.Guna2ControlBox closeButton;
        private Guna.UI2.WinForms.Guna2DataGridView accountGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.Label amountLabel;
        private Guna.UI2.WinForms.Guna2NumericUpDown amountNumericUpDown;
        private Guna.UI2.WinForms.Guna2Button openLaunchFolderButton;
        private Guna.UI2.WinForms.Guna2Button clearButton;
        private Guna.UI2.WinForms.Guna2Button copyButton;
        private Guna.UI2.WinForms.Guna2Button removeAccountButton;
        private Guna.UI2.WinForms.Guna2ComboBox driverComboBox;
    }
}

