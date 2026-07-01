namespace CalendarUI
{
    partial class Uc_Days
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
            this.gnaPnlUcDay = new Guna.UI2.WinForms.Guna2Panel();
            this.lblShowDay = new System.Windows.Forms.Label();
            this.gnaPnlUcDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // gnaPnlUcDay
            // 
            this.gnaPnlUcDay.BorderRadius = 18;
            this.gnaPnlUcDay.Controls.Add(this.lblShowDay);
            this.gnaPnlUcDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gnaPnlUcDay.FillColor = System.Drawing.Color.Transparent;
            this.gnaPnlUcDay.Location = new System.Drawing.Point(1, 1);
            this.gnaPnlUcDay.Name = "gnaPnlUcDay";
            this.gnaPnlUcDay.ShadowDecoration.Parent = this.gnaPnlUcDay;
            this.gnaPnlUcDay.Size = new System.Drawing.Size(41, 35);
            this.gnaPnlUcDay.TabIndex = 0;
            this.gnaPnlUcDay.Click += new System.EventHandler(this.gnaPnlUcDay_Click);
            // 
            // lblShowDay
            // 
            this.lblShowDay.AutoSize = true;
            this.lblShowDay.BackColor = System.Drawing.Color.Transparent;
            this.lblShowDay.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowDay.Location = new System.Drawing.Point(9, 11);
            this.lblShowDay.Name = "lblShowDay";
            this.lblShowDay.Size = new System.Drawing.Size(23, 16);
            this.lblShowDay.TabIndex = 0;
            this.lblShowDay.Text = "00";
            this.lblShowDay.Click += new System.EventHandler(this.lblShowDay_Click);
            // 
            // Uc_Days
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.gnaPnlUcDay);
            this.Name = "Uc_Days";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(43, 37);
            this.gnaPnlUcDay.ResumeLayout(false);
            this.gnaPnlUcDay.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel gnaPnlUcDay;
        private System.Windows.Forms.Label lblShowDay;
    }
}
