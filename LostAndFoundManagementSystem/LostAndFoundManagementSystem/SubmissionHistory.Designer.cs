namespace LostAndFoundManagementSystem
{
    partial class SubmissionHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmissionHistory));
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gnaBtnAutonomousSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gnaDgvSubGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SubmissionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Submitted_By = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmissionTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubmittedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnaBtnCreateLostItem = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gnaBtnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gnaBtnUpdateSubmission = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gnaDgvSubGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.CustomImages.Parent = this.btnPrev;
            this.btnPrev.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Location = new System.Drawing.Point(11, 11);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(43, 39);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.Text = "<";
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1154, 10);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(24, 211);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1154, 11);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(24, 320);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1154, 10);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(24, 318);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1154, 11);
            this.flowLayoutPanel4.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.label1.Location = new System.Drawing.Point(35, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "Submissions Grid";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(38, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lost Item Management";
            // 
            // gnaBtnAutonomousSearch
            // 
            this.gnaBtnAutonomousSearch.BorderRadius = 17;
            this.gnaBtnAutonomousSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnaBtnAutonomousSearch.DefaultText = "";
            this.gnaBtnAutonomousSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gnaBtnAutonomousSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gnaBtnAutonomousSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gnaBtnAutonomousSearch.DisabledState.Parent = this.gnaBtnAutonomousSearch;
            this.gnaBtnAutonomousSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gnaBtnAutonomousSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnaBtnAutonomousSearch.FocusedState.Parent = this.gnaBtnAutonomousSearch;
            this.gnaBtnAutonomousSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnaBtnAutonomousSearch.HoverState.Parent = this.gnaBtnAutonomousSearch;
            this.gnaBtnAutonomousSearch.Location = new System.Drawing.Point(30, 248);
            this.gnaBtnAutonomousSearch.Name = "gnaBtnAutonomousSearch";
            this.gnaBtnAutonomousSearch.PasswordChar = '\0';
            this.gnaBtnAutonomousSearch.PlaceholderText = "";
            this.gnaBtnAutonomousSearch.SelectedText = "";
            this.gnaBtnAutonomousSearch.ShadowDecoration.Parent = this.gnaBtnAutonomousSearch;
            this.gnaBtnAutonomousSearch.Size = new System.Drawing.Size(627, 45);
            this.gnaBtnAutonomousSearch.TabIndex = 13;
            this.gnaBtnAutonomousSearch.TextOffset = new System.Drawing.Point(9, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.LimeGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(675, 247);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(171, 45);
            this.guna2Button1.TabIndex = 14;
            this.guna2Button1.Text = "Search";
            // 
            // gnaDgvSubGrid
            // 
            this.gnaDgvSubGrid.AllowUserToAddRows = false;
            this.gnaDgvSubGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.gnaDgvSubGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gnaDgvSubGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gnaDgvSubGrid.BackgroundColor = System.Drawing.Color.White;
            this.gnaDgvSubGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gnaDgvSubGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gnaDgvSubGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 13F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gnaDgvSubGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gnaDgvSubGrid.ColumnHeadersHeight = 50;
            this.gnaDgvSubGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubmissionID,
            this.Picture,
            this.ItemName,
            this.Submitted_By,
            this.SubmissionTime,
            this.SubmittedOn});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gnaDgvSubGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.gnaDgvSubGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gnaDgvSubGrid.EnableHeadersVisualStyles = false;
            this.gnaDgvSubGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gnaDgvSubGrid.Location = new System.Drawing.Point(0, 370);
            this.gnaDgvSubGrid.Name = "gnaDgvSubGrid";
            this.gnaDgvSubGrid.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gnaDgvSubGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.gnaDgvSubGrid.RowHeadersVisible = false;
            this.gnaDgvSubGrid.RowTemplate.Height = 100;
            this.gnaDgvSubGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gnaDgvSubGrid.Size = new System.Drawing.Size(1198, 473);
            this.gnaDgvSubGrid.TabIndex = 15;
            this.gnaDgvSubGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.gnaDgvSubGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gnaDgvSubGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gnaDgvSubGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gnaDgvSubGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gnaDgvSubGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gnaDgvSubGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gnaDgvSubGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gnaDgvSubGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Green;
            this.gnaDgvSubGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gnaDgvSubGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gnaDgvSubGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gnaDgvSubGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gnaDgvSubGrid.ThemeStyle.HeaderStyle.Height = 50;
            this.gnaDgvSubGrid.ThemeStyle.ReadOnly = true;
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.Height = 100;
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gnaDgvSubGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gnaDgvSubGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gnaDgvSubGrid_CellFormatting);
            this.gnaDgvSubGrid.Click += new System.EventHandler(this.gnaDgvSubGrid_Click);
            // 
            // SubmissionID
            // 
            this.SubmissionID.DataPropertyName = "SubmissionID";
            this.SubmissionID.HeaderText = "Sub Id";
            this.SubmissionID.Name = "SubmissionID";
            this.SubmissionID.ReadOnly = true;
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "Pic";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Submitted_By
            // 
            this.Submitted_By.DataPropertyName = "Submitted_By";
            this.Submitted_By.HeaderText = "Submitted By";
            this.Submitted_By.Name = "Submitted_By";
            this.Submitted_By.ReadOnly = true;
            // 
            // SubmissionTime
            // 
            this.SubmissionTime.DataPropertyName = "SubmissionTime";
            this.SubmissionTime.HeaderText = "SubmissionTime";
            this.SubmissionTime.Name = "SubmissionTime";
            this.SubmissionTime.ReadOnly = true;
            // 
            // SubmittedOn
            // 
            this.SubmittedOn.DataPropertyName = "SubmittedOn";
            this.SubmittedOn.HeaderText = "Submitted On";
            this.SubmittedOn.Name = "SubmittedOn";
            this.SubmittedOn.ReadOnly = true;
            // 
            // gnaBtnCreateLostItem
            // 
            this.gnaBtnCreateLostItem.CheckedState.Parent = this.gnaBtnCreateLostItem;
            this.gnaBtnCreateLostItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaBtnCreateLostItem.CustomImages.Parent = this.gnaBtnCreateLostItem;
            this.gnaBtnCreateLostItem.FillColor = System.Drawing.Color.Black;
            this.gnaBtnCreateLostItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnCreateLostItem.ForeColor = System.Drawing.Color.White;
            this.gnaBtnCreateLostItem.HoverState.Parent = this.gnaBtnCreateLostItem;
            this.gnaBtnCreateLostItem.Image = ((System.Drawing.Image)(resources.GetObject("gnaBtnCreateLostItem.Image")));
            this.gnaBtnCreateLostItem.ImageSize = new System.Drawing.Size(30, 30);
            this.gnaBtnCreateLostItem.Location = new System.Drawing.Point(990, 140);
            this.gnaBtnCreateLostItem.Name = "gnaBtnCreateLostItem";
            this.gnaBtnCreateLostItem.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gnaBtnCreateLostItem.ShadowDecoration.Parent = this.gnaBtnCreateLostItem;
            this.gnaBtnCreateLostItem.Size = new System.Drawing.Size(53, 50);
            this.gnaBtnCreateLostItem.TabIndex = 16;
            this.gnaBtnCreateLostItem.Click += new System.EventHandler(this.gnaBtnCreateLostItem_Click);
            // 
            // gnaBtnDelete
            // 
            this.gnaBtnDelete.CheckedState.Parent = this.gnaBtnDelete;
            this.gnaBtnDelete.CustomImages.Parent = this.gnaBtnDelete;
            this.gnaBtnDelete.FillColor = System.Drawing.Color.Black;
            this.gnaBtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnDelete.ForeColor = System.Drawing.Color.White;
            this.gnaBtnDelete.HoverState.Parent = this.gnaBtnDelete;
            this.gnaBtnDelete.Image = ((System.Drawing.Image)(resources.GetObject("gnaBtnDelete.Image")));
            this.gnaBtnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.gnaBtnDelete.Location = new System.Drawing.Point(1058, 140);
            this.gnaBtnDelete.Name = "gnaBtnDelete";
            this.gnaBtnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gnaBtnDelete.ShadowDecoration.Parent = this.gnaBtnDelete;
            this.gnaBtnDelete.Size = new System.Drawing.Size(53, 50);
            this.gnaBtnDelete.TabIndex = 16;
            this.gnaBtnDelete.Click += new System.EventHandler(this.gnaBtnDelete_Click);
            // 
            // gnaBtnUpdateSubmission
            // 
            this.gnaBtnUpdateSubmission.CheckedState.Parent = this.gnaBtnUpdateSubmission;
            this.gnaBtnUpdateSubmission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaBtnUpdateSubmission.CustomImages.Parent = this.gnaBtnUpdateSubmission;
            this.gnaBtnUpdateSubmission.FillColor = System.Drawing.Color.Black;
            this.gnaBtnUpdateSubmission.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnUpdateSubmission.ForeColor = System.Drawing.Color.White;
            this.gnaBtnUpdateSubmission.HoverState.Parent = this.gnaBtnUpdateSubmission;
            this.gnaBtnUpdateSubmission.Image = ((System.Drawing.Image)(resources.GetObject("gnaBtnUpdateSubmission.Image")));
            this.gnaBtnUpdateSubmission.ImageSize = new System.Drawing.Size(25, 25);
            this.gnaBtnUpdateSubmission.Location = new System.Drawing.Point(1126, 140);
            this.gnaBtnUpdateSubmission.Name = "gnaBtnUpdateSubmission";
            this.gnaBtnUpdateSubmission.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gnaBtnUpdateSubmission.ShadowDecoration.Parent = this.gnaBtnUpdateSubmission;
            this.gnaBtnUpdateSubmission.Size = new System.Drawing.Size(51, 50);
            this.gnaBtnUpdateSubmission.TabIndex = 16;
            this.gnaBtnUpdateSubmission.Click += new System.EventHandler(this.gnaBtnUpdateSubmission_Click);
            // 
            // SubmissionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1198, 843);
            this.Controls.Add(this.gnaBtnUpdateSubmission);
            this.Controls.Add(this.gnaBtnDelete);
            this.Controls.Add(this.gnaBtnCreateLostItem);
            this.Controls.Add(this.gnaDgvSubGrid);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.gnaBtnAutonomousSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnPrev);
            this.Name = "SubmissionHistory";
            this.Text = "SubmissionHistory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubmissionHistory_FormClosing);
            this.Load += new System.EventHandler(this.SubmissionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gnaDgvSubGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox gnaBtnAutonomousSearch;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2DataGridView gnaDgvSubGrid;
        private Guna.UI2.WinForms.Guna2CircleButton gnaBtnCreateLostItem;
        private Guna.UI2.WinForms.Guna2CircleButton gnaBtnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton gnaBtnUpdateSubmission;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmissionID;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Submitted_By;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmissionTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubmittedOn;
    }
}