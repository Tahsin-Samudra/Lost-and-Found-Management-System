namespace LostAndFoundManagementSystem
{
    partial class ReturnHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnHistory));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.gnaDgvReturnTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gnaTxtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.gnaBtnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddReturn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gnaBtnRefresh = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gnaBtnUpdate = new Guna.UI2.WinForms.Guna2CircleButton();
            this.gnaBtnBack = new Guna.UI2.WinForms.Guna2Button();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.ReturnedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnaDgvReturnTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Return History";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 228);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1183, 10);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 229);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1183, 10);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(92, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Return Items and track return history";
            // 
            // gnaDgvReturnTable
            // 
            this.gnaDgvReturnTable.AllowUserToAddRows = false;
            this.gnaDgvReturnTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gnaDgvReturnTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gnaDgvReturnTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gnaDgvReturnTable.ColumnHeadersHeight = 50;
            this.gnaDgvReturnTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gnaDgvReturnTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture,
            this.ReturnedOn,
            this.ItemName,
            this.ReturnedBy,
            this.ReturnedTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gnaDgvReturnTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.gnaDgvReturnTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gnaDgvReturnTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gnaDgvReturnTable.Location = new System.Drawing.Point(0, 374);
            this.gnaDgvReturnTable.Name = "gnaDgvReturnTable";
            this.gnaDgvReturnTable.ReadOnly = true;
            this.gnaDgvReturnTable.RowHeadersVisible = false;
            this.gnaDgvReturnTable.RowTemplate.Height = 90;
            this.gnaDgvReturnTable.Size = new System.Drawing.Size(1188, 416);
            this.gnaDgvReturnTable.TabIndex = 3;
            this.gnaDgvReturnTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gnaDgvReturnTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Violet;
            this.gnaDgvReturnTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnaDgvReturnTable.ThemeStyle.HeaderStyle.Height = 50;
            this.gnaDgvReturnTable.ThemeStyle.ReadOnly = true;
            this.gnaDgvReturnTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gnaDgvReturnTable.ThemeStyle.RowsStyle.Height = 90;
            this.gnaDgvReturnTable.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gnaDgvReturnTable_CellFormatting);
            // 
            // gnaTxtSearch
            // 
            this.gnaTxtSearch.BorderRadius = 30;
            this.gnaTxtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnaTxtSearch.DefaultText = "";
            this.gnaTxtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.gnaTxtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.gnaTxtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gnaTxtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.gnaTxtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnaTxtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaTxtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gnaTxtSearch.Location = new System.Drawing.Point(12, 135);
            this.gnaTxtSearch.Name = "gnaTxtSearch";
            this.gnaTxtSearch.PlaceholderText = "";
            this.gnaTxtSearch.SelectedText = "";
            this.gnaTxtSearch.Size = new System.Drawing.Size(510, 58);
            this.gnaTxtSearch.TabIndex = 4;
            // 
            // gnaBtnSearch
            // 
            this.gnaBtnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnaBtnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnaBtnSearch.FillColor = System.Drawing.Color.Violet;
            this.gnaBtnSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnSearch.ForeColor = System.Drawing.Color.White;
            this.gnaBtnSearch.Location = new System.Drawing.Point(557, 135);
            this.gnaBtnSearch.Name = "gnaBtnSearch";
            this.gnaBtnSearch.Size = new System.Drawing.Size(117, 58);
            this.gnaBtnSearch.TabIndex = 5;
            this.gnaBtnSearch.Text = "mag";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(4, 357);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1183, 10);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(4, 358);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(1183, 10);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddReturn.FillColor = System.Drawing.Color.Black;
            this.btnAddReturn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddReturn.ForeColor = System.Drawing.Color.White;
            this.btnAddReturn.Image = ((System.Drawing.Image)(resources.GetObject("btnAddReturn.Image")));
            this.btnAddReturn.ImageSize = new System.Drawing.Size(25, 25);
            this.btnAddReturn.Location = new System.Drawing.Point(844, 288);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddReturn.Size = new System.Drawing.Size(55, 50);
            this.btnAddReturn.TabIndex = 6;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(25, 25);
            this.btnDelete.Location = new System.Drawing.Point(926, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(55, 50);
            this.btnDelete.TabIndex = 6;
            // 
            // gnaBtnRefresh
            // 
            this.gnaBtnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnaBtnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnaBtnRefresh.FillColor = System.Drawing.Color.Black;
            this.gnaBtnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnRefresh.ForeColor = System.Drawing.Color.White;
            this.gnaBtnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("gnaBtnRefresh.Image")));
            this.gnaBtnRefresh.ImageSize = new System.Drawing.Size(25, 25);
            this.gnaBtnRefresh.Location = new System.Drawing.Point(1010, 288);
            this.gnaBtnRefresh.Name = "gnaBtnRefresh";
            this.gnaBtnRefresh.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gnaBtnRefresh.Size = new System.Drawing.Size(55, 50);
            this.gnaBtnRefresh.TabIndex = 6;
            // 
            // gnaBtnUpdate
            // 
            this.gnaBtnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnaBtnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnaBtnUpdate.FillColor = System.Drawing.Color.Black;
            this.gnaBtnUpdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnUpdate.ForeColor = System.Drawing.Color.White;
            this.gnaBtnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("gnaBtnUpdate.Image")));
            this.gnaBtnUpdate.ImageSize = new System.Drawing.Size(25, 25);
            this.gnaBtnUpdate.Location = new System.Drawing.Point(1093, 288);
            this.gnaBtnUpdate.Name = "gnaBtnUpdate";
            this.gnaBtnUpdate.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gnaBtnUpdate.Size = new System.Drawing.Size(55, 50);
            this.gnaBtnUpdate.TabIndex = 6;
            // 
            // gnaBtnBack
            // 
            this.gnaBtnBack.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnBack.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gnaBtnBack.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gnaBtnBack.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gnaBtnBack.FillColor = System.Drawing.Color.Black;
            this.gnaBtnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnBack.ForeColor = System.Drawing.Color.White;
            this.gnaBtnBack.Location = new System.Drawing.Point(1098, 34);
            this.gnaBtnBack.Name = "gnaBtnBack";
            this.gnaBtnBack.Size = new System.Drawing.Size(59, 51);
            this.gnaBtnBack.TabIndex = 7;
            this.gnaBtnBack.Text = "<";
            // 
            // Picture
            // 
            this.Picture.DataPropertyName = "Picture";
            this.Picture.HeaderText = "pic";
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ReturnedOn
            // 
            this.ReturnedOn.DataPropertyName = "ReturnedOn";
            this.ReturnedOn.HeaderText = "ReturnedOn";
            this.ReturnedOn.Name = "ReturnedOn";
            this.ReturnedOn.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ReturnedBy
            // 
            this.ReturnedBy.DataPropertyName = "Returned_By";
            this.ReturnedBy.HeaderText = "ReturnedBy";
            this.ReturnedBy.Name = "ReturnedBy";
            this.ReturnedBy.ReadOnly = true;
            // 
            // ReturnedTime
            // 
            this.ReturnedTime.DataPropertyName = "ReturnedTime";
            this.ReturnedTime.HeaderText = "ReturnedTime";
            this.ReturnedTime.Name = "ReturnedTime";
            this.ReturnedTime.ReadOnly = true;
            // 
            // ReturnHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1188, 790);
            this.Controls.Add(this.gnaBtnBack);
            this.Controls.Add(this.gnaBtnUpdate);
            this.Controls.Add(this.gnaBtnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.gnaBtnSearch);
            this.Controls.Add(this.gnaTxtSearch);
            this.Controls.Add(this.gnaDgvReturnTable);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReturnHistory";
            this.Text = "ReturnPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReturnPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gnaDgvReturnTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView gnaDgvReturnTable;
        private Guna.UI2.WinForms.Guna2TextBox gnaTxtSearch;
        private Guna.UI2.WinForms.Guna2Button gnaBtnSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddReturn;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton gnaBtnRefresh;
        private Guna.UI2.WinForms.Guna2CircleButton gnaBtnUpdate;
        private Guna.UI2.WinForms.Guna2Button gnaBtnBack;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedTime;
    }
}