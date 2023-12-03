namespace LIbrary_Management_System
{
    partial class CompleteBookDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteBookDetails));
            this.label8 = new System.Windows.Forms.Label();
            this.txtgridissed = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtgridreturn = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsp = new System.Windows.Forms.Panel();
            this.txtmailbody = new System.Windows.Forms.RichTextBox();
            this.btncancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnsend = new Guna.UI2.WinForms.Guna2Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtmailbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.txtgridissed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgridreturn)).BeginInit();
            this.detailsp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Issued Book";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtgridissed
            // 
            this.txtgridissed.AllowUserToAddRows = false;
            this.txtgridissed.AllowUserToDeleteRows = false;
            this.txtgridissed.AllowUserToResizeColumns = false;
            this.txtgridissed.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.txtgridissed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.txtgridissed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgridissed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.txtgridissed.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.txtgridissed.ColumnHeadersHeight = 18;
            this.txtgridissed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.txtgridissed.DefaultCellStyle = dataGridViewCellStyle3;
            this.txtgridissed.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtgridissed.Location = new System.Drawing.Point(12, 38);
            this.txtgridissed.Name = "txtgridissed";
            this.txtgridissed.RowHeadersVisible = false;
            this.txtgridissed.Size = new System.Drawing.Size(978, 224);
            this.txtgridissed.TabIndex = 9;
            this.txtgridissed.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.txtgridissed.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.txtgridissed.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.txtgridissed.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.txtgridissed.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.txtgridissed.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.txtgridissed.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtgridissed.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtgridissed.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.txtgridissed.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgridissed.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.txtgridissed.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.txtgridissed.ThemeStyle.HeaderStyle.Height = 18;
            this.txtgridissed.ThemeStyle.ReadOnly = false;
            this.txtgridissed.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.txtgridissed.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.txtgridissed.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgridissed.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.txtgridissed.ThemeStyle.RowsStyle.Height = 22;
            this.txtgridissed.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtgridissed.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.txtgridissed.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtgridissed_CellClick);
            // 
            // txtgridreturn
            // 
            this.txtgridreturn.AllowUserToAddRows = false;
            this.txtgridreturn.AllowUserToDeleteRows = false;
            this.txtgridreturn.AllowUserToResizeColumns = false;
            this.txtgridreturn.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.txtgridreturn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.txtgridreturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtgridreturn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.txtgridreturn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.txtgridreturn.ColumnHeadersHeight = 18;
            this.txtgridreturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.txtgridreturn.DefaultCellStyle = dataGridViewCellStyle6;
            this.txtgridreturn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtgridreturn.Location = new System.Drawing.Point(12, 303);
            this.txtgridreturn.Name = "txtgridreturn";
            this.txtgridreturn.RowHeadersVisible = false;
            this.txtgridreturn.Size = new System.Drawing.Size(978, 224);
            this.txtgridreturn.TabIndex = 11;
            this.txtgridreturn.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.txtgridreturn.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.txtgridreturn.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.txtgridreturn.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.txtgridreturn.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.txtgridreturn.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.txtgridreturn.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtgridreturn.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtgridreturn.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.txtgridreturn.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgridreturn.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.txtgridreturn.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.txtgridreturn.ThemeStyle.HeaderStyle.Height = 18;
            this.txtgridreturn.ThemeStyle.ReadOnly = false;
            this.txtgridreturn.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.txtgridreturn.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.txtgridreturn.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgridreturn.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.txtgridreturn.ThemeStyle.RowsStyle.Height = 22;
            this.txtgridreturn.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.txtgridreturn.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Returned Book";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // detailsp
            // 
            this.detailsp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.detailsp.Controls.Add(this.txtmailbody);
            this.detailsp.Controls.Add(this.btncancel);
            this.detailsp.Controls.Add(this.btnsend);
            this.detailsp.Controls.Add(this.label10);
            this.detailsp.Controls.Add(this.txtmailbox);
            this.detailsp.Controls.Add(this.label5);
            this.detailsp.Location = new System.Drawing.Point(12, 559);
            this.detailsp.Name = "detailsp";
            this.detailsp.Size = new System.Drawing.Size(978, 190);
            this.detailsp.TabIndex = 13;
            // 
            // txtmailbody
            // 
            this.txtmailbody.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmailbody.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtmailbody.ForeColor = System.Drawing.Color.Black;
            this.txtmailbody.Location = new System.Drawing.Point(181, 65);
            this.txtmailbody.Name = "txtmailbody";
            this.txtmailbody.Size = new System.Drawing.Size(630, 112);
            this.txtmailbody.TabIndex = 97;
            this.txtmailbody.Text = resources.GetString("txtmailbody.Text");
            // 
            // btncancel
            // 
            this.btncancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btncancel.Animated = true;
            this.btncancel.AutoRoundedCorners = true;
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BorderColor = System.Drawing.Color.Transparent;
            this.btncancel.BorderRadius = 15;
            this.btncancel.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btncancel.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btncancel.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btncancel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btncancel.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btncancel.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btncancel.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btncancel.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btncancel.FillColor = System.Drawing.Color.Red;
            this.btncancel.FocusedColor = System.Drawing.Color.Black;
            this.btncancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btncancel.ForeColor = System.Drawing.Color.White;
            this.btncancel.Location = new System.Drawing.Point(827, 114);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(104, 33);
            this.btncancel.TabIndex = 95;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseTransparentBackground = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnsend
            // 
            this.btnsend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsend.Animated = true;
            this.btnsend.AutoRoundedCorners = true;
            this.btnsend.BackColor = System.Drawing.Color.Transparent;
            this.btnsend.BorderColor = System.Drawing.Color.Transparent;
            this.btnsend.BorderRadius = 15;
            this.btnsend.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsend.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnsend.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnsend.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnsend.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnsend.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnsend.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnsend.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnsend.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnsend.FocusedColor = System.Drawing.Color.Black;
            this.btnsend.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(827, 63);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(104, 33);
            this.btnsend.TabIndex = 94;
            this.btnsend.Text = "Send Email";
            this.btnsend.UseTransparentBackground = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(56, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 90;
            this.label10.Text = "Content";
            // 
            // txtmailbox
            // 
            this.txtmailbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtmailbox.Animated = true;
            this.txtmailbox.AutoRoundedCorners = true;
            this.txtmailbox.BorderRadius = 14;
            this.txtmailbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmailbox.DefaultText = "";
            this.txtmailbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmailbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmailbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmailbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmailbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmailbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtmailbox.ForeColor = System.Drawing.Color.Black;
            this.txtmailbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmailbox.Location = new System.Drawing.Point(181, 25);
            this.txtmailbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmailbox.Name = "txtmailbox";
            this.txtmailbox.PasswordChar = '\0';
            this.txtmailbox.PlaceholderText = "";
            this.txtmailbox.ReadOnly = true;
            this.txtmailbox.SelectedText = "";
            this.txtmailbox.Size = new System.Drawing.Size(312, 30);
            this.txtmailbox.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 87;
            this.label5.Text = "Student Email";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 753);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 12);
            this.panel1.TabIndex = 14;
            // 
            // CompleteBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(992, 540);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.detailsp);
            this.Controls.Add(this.txtgridreturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgridissed);
            this.Controls.Add(this.label8);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompleteBookDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBookDetails";
            this.Load += new System.EventHandler(this.CompleteBookDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtgridissed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgridreturn)).EndInit();
            this.detailsp.ResumeLayout(false);
            this.detailsp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DataGridView txtgridissed;
        private Guna.UI2.WinForms.Guna2DataGridView txtgridreturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel detailsp;
        private Guna.UI2.WinForms.Guna2Button btncancel;
        private Guna.UI2.WinForms.Guna2Button btnsend;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtmailbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtmailbody;
    }
}