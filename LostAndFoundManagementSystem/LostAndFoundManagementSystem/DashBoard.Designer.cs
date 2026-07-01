namespace LostAndFoundManagementSystem
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDashBoard = new System.Windows.Forms.Panel();
            this.pbxDashMenu = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_LFMS = new System.Windows.Forms.Label();
            this.gnaSubmissionHistory = new Guna.UI2.WinForms.Guna2Button();
            this.gnaBtnReturnHistory = new Guna.UI2.WinForms.Guna2Button();
            this.gnaAddAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.sidebarUpDown = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.gnaPnlSubmitBtn = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblSubmitCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gnaPnlReturn = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUCCalendarLoader = new System.Windows.Forms.Panel();
            this.gnaBtnFilter = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvShowLostItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Picture = new System.Windows.Forms.DataGridViewImageColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lost_Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_shelf_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlDashBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDashMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.gnaPnlSubmitBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gnaPnlReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLostItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashBoard
            // 
            this.pnlDashBoard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlDashBoard.Controls.Add(this.pbxDashMenu);
            this.pnlDashBoard.Controls.Add(this.label2);
            this.pnlDashBoard.Controls.Add(this.lbl_LFMS);
            this.pnlDashBoard.Controls.Add(this.gnaSubmissionHistory);
            this.pnlDashBoard.Controls.Add(this.gnaBtnReturnHistory);
            this.pnlDashBoard.Controls.Add(this.gnaAddAdmin);
            this.pnlDashBoard.Controls.Add(this.btnLogOut);
            this.pnlDashBoard.Controls.Add(this.guna2Button5);
            this.pnlDashBoard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDashBoard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashBoard.Name = "pnlDashBoard";
            this.pnlDashBoard.Size = new System.Drawing.Size(70, 803);
            this.pnlDashBoard.TabIndex = 0;
            // 
            // pbxDashMenu
            // 
            this.pbxDashMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxDashMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxDashMenu.Image")));
            this.pbxDashMenu.Location = new System.Drawing.Point(13, 29);
            this.pbxDashMenu.Name = "pbxDashMenu";
            this.pbxDashMenu.Size = new System.Drawing.Size(44, 40);
            this.pbxDashMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDashMenu.TabIndex = 9;
            this.pbxDashMenu.TabStop = false;
            this.pbxDashMenu.Click += new System.EventHandler(this.pbxDashMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(94, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "_ A D M I N  L O G _";
            // 
            // lbl_LFMS
            // 
            this.lbl_LFMS.AutoSize = true;
            this.lbl_LFMS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_LFMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LFMS.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_LFMS.Location = new System.Drawing.Point(108, 35);
            this.lbl_LFMS.Name = "lbl_LFMS";
            this.lbl_LFMS.Size = new System.Drawing.Size(109, 39);
            this.lbl_LFMS.TabIndex = 1;
            this.lbl_LFMS.Text = "LFMS";
            // 
            // gnaSubmissionHistory
            // 
            this.gnaSubmissionHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaSubmissionHistory.FillColor = System.Drawing.Color.Black;
            this.gnaSubmissionHistory.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gnaSubmissionHistory.ForeColor = System.Drawing.Color.White;
            this.gnaSubmissionHistory.Image = ((System.Drawing.Image)(resources.GetObject("gnaSubmissionHistory.Image")));
            this.gnaSubmissionHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnaSubmissionHistory.ImageOffset = new System.Drawing.Point(10, 0);
            this.gnaSubmissionHistory.ImageSize = new System.Drawing.Size(25, 25);
            this.gnaSubmissionHistory.Location = new System.Drawing.Point(3, 211);
            this.gnaSubmissionHistory.Name = "gnaSubmissionHistory";
            this.gnaSubmissionHistory.Size = new System.Drawing.Size(322, 76);
            this.gnaSubmissionHistory.TabIndex = 2;
            this.gnaSubmissionHistory.Text = "       Submission History";
            this.gnaSubmissionHistory.Click += new System.EventHandler(this.gnaSubmissionHistory_Click);
            // 
            // gnaBtnReturnHistory
            // 
            this.gnaBtnReturnHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaBtnReturnHistory.FillColor = System.Drawing.Color.Black;
            this.gnaBtnReturnHistory.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gnaBtnReturnHistory.ForeColor = System.Drawing.Color.White;
            this.gnaBtnReturnHistory.Image = ((System.Drawing.Image)(resources.GetObject("gnaBtnReturnHistory.Image")));
            this.gnaBtnReturnHistory.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnaBtnReturnHistory.ImageOffset = new System.Drawing.Point(10, 0);
            this.gnaBtnReturnHistory.ImageSize = new System.Drawing.Size(25, 25);
            this.gnaBtnReturnHistory.Location = new System.Drawing.Point(3, 306);
            this.gnaBtnReturnHistory.Name = "gnaBtnReturnHistory";
            this.gnaBtnReturnHistory.Size = new System.Drawing.Size(322, 76);
            this.gnaBtnReturnHistory.TabIndex = 2;
            this.gnaBtnReturnHistory.Text = "      Return History";
            this.gnaBtnReturnHistory.Click += new System.EventHandler(this.gnaBtnReturnHistory_Click);
            // 
            // gnaAddAdmin
            // 
            this.gnaAddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaAddAdmin.FillColor = System.Drawing.Color.Black;
            this.gnaAddAdmin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.gnaAddAdmin.ForeColor = System.Drawing.Color.White;
            this.gnaAddAdmin.Image = ((System.Drawing.Image)(resources.GetObject("gnaAddAdmin.Image")));
            this.gnaAddAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gnaAddAdmin.ImageOffset = new System.Drawing.Point(10, 0);
            this.gnaAddAdmin.ImageSize = new System.Drawing.Size(25, 25);
            this.gnaAddAdmin.Location = new System.Drawing.Point(3, 399);
            this.gnaAddAdmin.Name = "gnaAddAdmin";
            this.gnaAddAdmin.Size = new System.Drawing.Size(322, 76);
            this.gnaAddAdmin.TabIndex = 2;
            this.gnaAddAdmin.Text = "    Add Admin";
            this.gnaAddAdmin.Click += new System.EventHandler(this.gnaAddAdmin_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FillColor = System.Drawing.Color.Black;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogOut.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnLogOut.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLogOut.Location = new System.Drawing.Point(3, 624);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(322, 76);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "   Log out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button5.FillColor = System.Drawing.Color.Black;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button5.Image")));
            this.guna2Button5.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button5.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button5.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button5.Location = new System.Drawing.Point(3, 706);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(325, 76);
            this.guna2Button5.TabIndex = 2;
            this.guna2Button5.Text = "  Setting";
            // 
            // sidebarUpDown
            // 
            this.sidebarUpDown.Interval = 10;
            this.sidebarUpDown.Tick += new System.EventHandler(this.sidebarUpDown_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel1.Controls.Add(this.gnaPnlSubmitBtn);
            this.panel1.Controls.Add(this.gnaPnlReturn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.gnaBtnFilter);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Controls.Add(this.dgvShowLostItems);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(70, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 803);
            this.panel1.TabIndex = 1;
            // 
            // gnaPnlSubmitBtn
            // 
            this.gnaPnlSubmitBtn.BackColor = System.Drawing.Color.Transparent;
            this.gnaPnlSubmitBtn.BorderRadius = 25;
            this.gnaPnlSubmitBtn.Controls.Add(this.pictureBox2);
            this.gnaPnlSubmitBtn.Controls.Add(this.guna2Panel2);
            this.gnaPnlSubmitBtn.Controls.Add(this.guna2Panel1);
            this.gnaPnlSubmitBtn.Controls.Add(this.lblSubmitCount);
            this.gnaPnlSubmitBtn.Controls.Add(this.label1);
            this.gnaPnlSubmitBtn.Controls.Add(this.pictureBox1);
            this.gnaPnlSubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaPnlSubmitBtn.FillColor = System.Drawing.Color.Gold;
            this.gnaPnlSubmitBtn.Location = new System.Drawing.Point(13, 101);
            this.gnaPnlSubmitBtn.Name = "gnaPnlSubmitBtn";
            this.gnaPnlSubmitBtn.Size = new System.Drawing.Size(266, 213);
            this.gnaPnlSubmitBtn.TabIndex = 7;
            this.gnaPnlSubmitBtn.Click += new System.EventHandler(this.gnaPnlSubmitBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-13, 46);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 54);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel2.Location = new System.Drawing.Point(222, 129);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(10, 70);
            this.guna2Panel2.TabIndex = 10;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.FillColor = System.Drawing.Color.Olive;
            this.guna2Panel1.Location = new System.Drawing.Point(199, 145);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(11, 54);
            this.guna2Panel1.TabIndex = 9;
            // 
            // lblSubmitCount
            // 
            this.lblSubmitCount.AutoSize = true;
            this.lblSubmitCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmitCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSubmitCount.Location = new System.Drawing.Point(40, 169);
            this.lblSubmitCount.Name = "lblSubmitCount";
            this.lblSubmitCount.Size = new System.Drawing.Size(104, 17);
            this.lblSubmitCount.TabIndex = 0;
            this.lblSubmitCount.Text = "Submit Count : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Submit Lost Item";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // gnaPnlReturn
            // 
            this.gnaPnlReturn.BackColor = System.Drawing.Color.Transparent;
            this.gnaPnlReturn.BorderRadius = 25;
            this.gnaPnlReturn.Controls.Add(this.guna2Panel3);
            this.gnaPnlReturn.Controls.Add(this.pictureBox3);
            this.gnaPnlReturn.Controls.Add(this.label5);
            this.gnaPnlReturn.Controls.Add(this.label3);
            this.gnaPnlReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gnaPnlReturn.FillColor = System.Drawing.Color.YellowGreen;
            this.gnaPnlReturn.Location = new System.Drawing.Point(300, 104);
            this.gnaPnlReturn.Name = "gnaPnlReturn";
            this.gnaPnlReturn.Size = new System.Drawing.Size(265, 210);
            this.gnaPnlReturn.TabIndex = 8;
            this.gnaPnlReturn.Click += new System.EventHandler(this.gnaPnlReturn_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderRadius = 5;
            this.guna2Panel3.FillColor = System.Drawing.Color.DarkOliveGreen;
            this.guna2Panel3.Location = new System.Drawing.Point(194, 171);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(57, 10);
            this.guna2Panel3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(105, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Returned Items : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Return Lost Item";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlUCCalendarLoader);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(868, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(383, 803);
            this.panel2.TabIndex = 6;
            // 
            // pnlUCCalendarLoader
            // 
            this.pnlUCCalendarLoader.AutoScroll = true;
            this.pnlUCCalendarLoader.Location = new System.Drawing.Point(3, 12);
            this.pnlUCCalendarLoader.Name = "pnlUCCalendarLoader";
            this.pnlUCCalendarLoader.Size = new System.Drawing.Size(385, 331);
            this.pnlUCCalendarLoader.TabIndex = 13;
            // 
            // gnaBtnFilter
            // 
            this.gnaBtnFilter.FillColor = System.Drawing.Color.Black;
            this.gnaBtnFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gnaBtnFilter.ForeColor = System.Drawing.Color.White;
            this.gnaBtnFilter.Location = new System.Drawing.Point(513, 35);
            this.gnaBtnFilter.Name = "gnaBtnFilter";
            this.gnaBtnFilter.Size = new System.Drawing.Size(52, 44);
            this.gnaBtnFilter.TabIndex = 3;
            this.gnaBtnFilter.Text = "k";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 17;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(22, 35);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(470, 44);
            this.guna2TextBox1.TabIndex = 2;
            this.guna2TextBox1.TextOffset = new System.Drawing.Point(17, 0);
            // 
            // dgvShowLostItems
            // 
            this.dgvShowLostItems.AllowUserToAddRows = false;
            this.dgvShowLostItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvShowLostItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvShowLostItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowLostItems.BackgroundColor = System.Drawing.Color.Ivory;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowLostItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvShowLostItems.ColumnHeadersHeight = 50;
            this.dgvShowLostItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvShowLostItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Picture,
            this.ItemName,
            this.Type,
            this.Status,
            this.Lost_Place,
            this.Item_shelf_no,
            this.ItemID});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvShowLostItems.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShowLostItems.GridColor = System.Drawing.Color.White;
            this.dgvShowLostItems.Location = new System.Drawing.Point(13, 329);
            this.dgvShowLostItems.Name = "dgvShowLostItems";
            this.dgvShowLostItems.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowLostItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShowLostItems.RowHeadersVisible = false;
            this.dgvShowLostItems.RowHeadersWidth = 51;
            this.dgvShowLostItems.RowTemplate.Height = 140;
            this.dgvShowLostItems.Size = new System.Drawing.Size(850, 474);
            this.dgvShowLostItems.TabIndex = 5;
            this.dgvShowLostItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvShowLostItems.ThemeStyle.BackColor = System.Drawing.Color.Ivory;
            this.dgvShowLostItems.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvShowLostItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.dgvShowLostItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvShowLostItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvShowLostItems.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvShowLostItems.ThemeStyle.ReadOnly = true;
            this.dgvShowLostItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvShowLostItems.ThemeStyle.RowsStyle.Height = 140;
            this.dgvShowLostItems.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvShowLostItems_CellFormatting);
            // 
            // Picture
            // 
            this.Picture.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Picture.DataPropertyName = "Picture";
            this.Picture.FillWeight = 141.1397F;
            this.Picture.HeaderText = "Pics";
            this.Picture.MinimumWidth = 200;
            this.Picture.Name = "Picture";
            this.Picture.ReadOnly = true;
            this.Picture.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Picture.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Picture.Width = 200;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Type.DataPropertyName = "Type";
            this.Type.FillWeight = 396.5398F;
            this.Type.HeaderText = "Type";
            this.Type.MinimumWidth = 130;
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 130;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 0.8551595F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 130;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // Lost_Place
            // 
            this.Lost_Place.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Lost_Place.DataPropertyName = "Lost_Place";
            this.Lost_Place.FillWeight = 0.401345F;
            this.Lost_Place.HeaderText = "Lost_Place";
            this.Lost_Place.MinimumWidth = 130;
            this.Lost_Place.Name = "Lost_Place";
            this.Lost_Place.ReadOnly = true;
            this.Lost_Place.Width = 130;
            // 
            // Item_shelf_no
            // 
            this.Item_shelf_no.DataPropertyName = "Item_shelf_no";
            this.Item_shelf_no.FillWeight = 8.385362F;
            this.Item_shelf_no.HeaderText = "ShelfNo";
            this.Item_shelf_no.MinimumWidth = 130;
            this.Item_shelf_no.Name = "Item_shelf_no";
            this.Item_shelf_no.ReadOnly = true;
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Visible = false;
            // 
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1321, 803);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDashBoard);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashBoard_FormClosing);
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.pnlDashBoard.ResumeLayout(false);
            this.pnlDashBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDashMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gnaPnlSubmitBtn.ResumeLayout(false);
            this.gnaPnlSubmitBtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gnaPnlReturn.ResumeLayout(false);
            this.gnaPnlReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowLostItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashBoard;
        private System.Windows.Forms.Label lbl_LFMS;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2Button gnaSubmissionHistory;
        private Guna.UI2.WinForms.Guna2Button gnaBtnReturnHistory;
        private Guna.UI2.WinForms.Guna2Button gnaAddAdmin;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Timer sidebarUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbxDashMenu;
        private Guna.UI2.WinForms.Guna2Panel gnaPnlReturn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel gnaPnlSubmitBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblSubmitCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlUCCalendarLoader;
        private Guna.UI2.WinForms.Guna2Button gnaBtnFilter;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvShowLostItems;
        private System.Windows.Forms.DataGridViewImageColumn Picture;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lost_Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_shelf_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
    }
}