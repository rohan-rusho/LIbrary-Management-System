namespace LIbrary_Management_System
{
    partial class dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.logoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.bOOKSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTUDENTSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iSSUEBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETURNBOOKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rETURNHEREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eNTERHEREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtclock = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Animated = true;
            this.logoutButton.AutoRoundedCorners = true;
            this.logoutButton.BackColor = System.Drawing.Color.Transparent;
            this.logoutButton.BorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.BorderRadius = 18;
            this.logoutButton.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.logoutButton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.logoutButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.logoutButton.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.logoutButton.FillColor = System.Drawing.Color.Red;
            this.logoutButton.FocusedColor = System.Drawing.Color.Black;
            this.logoutButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.logoutButton.ForeColor = System.Drawing.Color.White;
            this.logoutButton.Location = new System.Drawing.Point(759, 13);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 38);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseTransparentBackground = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // bOOKSToolStripMenuItem1
            // 
            this.bOOKSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewBooksToolStripMenuItem,
            this.viewBookToolStripMenuItem});
            this.bOOKSToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("bOOKSToolStripMenuItem1.Image")));
            this.bOOKSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bOOKSToolStripMenuItem1.Name = "bOOKSToolStripMenuItem1";
            this.bOOKSToolStripMenuItem1.Size = new System.Drawing.Size(107, 54);
            this.bOOKSToolStripMenuItem1.Text = "BOOKS";
            this.bOOKSToolStripMenuItem1.Click += new System.EventHandler(this.bOOKSToolStripMenuItem1_Click);
            // 
            // addNewBooksToolStripMenuItem
            // 
            this.addNewBooksToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewBooksToolStripMenuItem.Image")));
            this.addNewBooksToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewBooksToolStripMenuItem.Name = "addNewBooksToolStripMenuItem";
            this.addNewBooksToolStripMenuItem.Size = new System.Drawing.Size(192, 56);
            this.addNewBooksToolStripMenuItem.Text = "Add New Books";
            this.addNewBooksToolStripMenuItem.Click += new System.EventHandler(this.addNewBooksToolStripMenuItem_Click);
            // 
            // viewBookToolStripMenuItem
            // 
            this.viewBookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewBookToolStripMenuItem.Image")));
            this.viewBookToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewBookToolStripMenuItem.Name = "viewBookToolStripMenuItem";
            this.viewBookToolStripMenuItem.Size = new System.Drawing.Size(192, 56);
            this.viewBookToolStripMenuItem.Text = "View Book";
            this.viewBookToolStripMenuItem.Click += new System.EventHandler(this.viewBookToolStripMenuItem_Click);
            // 
            // sTUDENTSToolStripMenuItem1
            // 
            this.sTUDENTSToolStripMenuItem1.BackColor = System.Drawing.Color.OldLace;
            this.sTUDENTSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.viewStudentsToolStripMenuItem});
            this.sTUDENTSToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sTUDENTSToolStripMenuItem1.Image")));
            this.sTUDENTSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sTUDENTSToolStripMenuItem1.Name = "sTUDENTSToolStripMenuItem1";
            this.sTUDENTSToolStripMenuItem1.Size = new System.Drawing.Size(124, 54);
            this.sTUDENTSToolStripMenuItem1.Text = "STUDENTS";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addStudentToolStripMenuItem.Image")));
            this.addStudentToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(182, 56);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // viewStudentsToolStripMenuItem
            // 
            this.viewStudentsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("viewStudentsToolStripMenuItem.Image")));
            this.viewStudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            this.viewStudentsToolStripMenuItem.Size = new System.Drawing.Size(182, 56);
            this.viewStudentsToolStripMenuItem.Text = "View Students";
            this.viewStudentsToolStripMenuItem.Click += new System.EventHandler(this.viewStudentsToolStripMenuItem_Click);
            // 
            // iSSUEBOOKToolStripMenuItem
            // 
            this.iSSUEBOOKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.issueNowToolStripMenuItem});
            this.iSSUEBOOKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("iSSUEBOOKToolStripMenuItem.Image")));
            this.iSSUEBOOKToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.iSSUEBOOKToolStripMenuItem.Name = "iSSUEBOOKToolStripMenuItem";
            this.iSSUEBOOKToolStripMenuItem.Size = new System.Drawing.Size(133, 54);
            this.iSSUEBOOKToolStripMenuItem.Text = "ISSUE BOOK";
            this.iSSUEBOOKToolStripMenuItem.Click += new System.EventHandler(this.iSSUEBOOKToolStripMenuItem_Click);
            // 
            // issueNowToolStripMenuItem
            // 
            this.issueNowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueNowToolStripMenuItem.Image")));
            this.issueNowToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.issueNowToolStripMenuItem.Name = "issueNowToolStripMenuItem";
            this.issueNowToolStripMenuItem.Size = new System.Drawing.Size(169, 56);
            this.issueNowToolStripMenuItem.Text = "ISSUE NOW";
            this.issueNowToolStripMenuItem.Click += new System.EventHandler(this.issueNowToolStripMenuItem_Click);
            // 
            // rETURNBOOKToolStripMenuItem
            // 
            this.rETURNBOOKToolStripMenuItem.BackColor = System.Drawing.Color.OldLace;
            this.rETURNBOOKToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rETURNHEREToolStripMenuItem});
            this.rETURNBOOKToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rETURNBOOKToolStripMenuItem.Image")));
            this.rETURNBOOKToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rETURNBOOKToolStripMenuItem.Name = "rETURNBOOKToolStripMenuItem";
            this.rETURNBOOKToolStripMenuItem.Size = new System.Drawing.Size(147, 54);
            this.rETURNBOOKToolStripMenuItem.Text = "RETURN BOOK";
            this.rETURNBOOKToolStripMenuItem.Click += new System.EventHandler(this.rETURNBOOKToolStripMenuItem_Click);
            // 
            // rETURNHEREToolStripMenuItem
            // 
            this.rETURNHEREToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rETURNHEREToolStripMenuItem.Image")));
            this.rETURNHEREToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.rETURNHEREToolStripMenuItem.Name = "rETURNHEREToolStripMenuItem";
            this.rETURNHEREToolStripMenuItem.Size = new System.Drawing.Size(182, 56);
            this.rETURNHEREToolStripMenuItem.Text = "RETURN HERE";
            this.rETURNHEREToolStripMenuItem.Click += new System.EventHandler(this.rETURNHEREToolStripMenuItem_Click);
            // 
            // cOMPLETEBOOKDETAILSToolStripMenuItem1
            // 
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eNTERHEREToolStripMenuItem});
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cOMPLETEBOOKDETAILSToolStripMenuItem1.Image")));
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1.Name = "cOMPLETEBOOKDETAILSToolStripMenuItem1";
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1.Size = new System.Drawing.Size(208, 54);
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1.Text = "COMPLETE BOOK DETAILS";
            // 
            // eNTERHEREToolStripMenuItem
            // 
            this.eNTERHEREToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eNTERHEREToolStripMenuItem.Image")));
            this.eNTERHEREToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.eNTERHEREToolStripMenuItem.Name = "eNTERHEREToolStripMenuItem";
            this.eNTERHEREToolStripMenuItem.Size = new System.Drawing.Size(173, 56);
            this.eNTERHEREToolStripMenuItem.Text = "ENTER HERE";
            this.eNTERHEREToolStripMenuItem.Click += new System.EventHandler(this.eNTERHEREToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bOOKSToolStripMenuItem1,
            this.sTUDENTSToolStripMenuItem1,
            this.iSSUEBOOKToolStripMenuItem,
            this.rETURNBOOKToolStripMenuItem,
            this.cOMPLETEBOOKDETAILSToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(861, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtclock
            // 
            this.txtclock.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtclock.BackColor = System.Drawing.Color.Transparent;
            this.txtclock.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclock.ForeColor = System.Drawing.Color.White;
            this.txtclock.Location = new System.Drawing.Point(634, 137);
            this.txtclock.Name = "txtclock";
            this.txtclock.Size = new System.Drawing.Size(260, 42);
            this.txtclock.TabIndex = 6;
            this.txtclock.Text = "Times Goes Here";
            // 
            // clockTimer
            // 
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(861, 456);
            this.Controls.Add(this.txtclock);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Carda Cond", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button logoutButton;
        private System.Windows.Forms.ToolStripMenuItem bOOKSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sTUDENTSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iSSUEBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNBOOKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPLETEBOOKDETAILSToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem issueNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rETURNHEREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eNTERHEREToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtclock;
        private System.Windows.Forms.Timer clockTimer;
    }
}