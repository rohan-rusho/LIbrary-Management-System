namespace LIbrary_Management_System
{
    partial class ViewBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBook));
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.load = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnrefresh = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detailsp = new System.Windows.Forms.Panel();
            this.txtDateBox = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.txtBookGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBookPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPublication = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtView = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.detailsp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtView)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.White;
            this.guna2CustomGradientPanel1.Controls.Add(this.load);
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.Controls.Add(this.pictureBox1);
            this.guna2CustomGradientPanel1.Controls.Add(this.label7);
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(12, 9);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(946, 109);
            this.guna2CustomGradientPanel1.TabIndex = 14;
            this.guna2CustomGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2CustomGradientPanel1_Paint);
            // 
            // load
            // 
            this.load.FillColor = System.Drawing.Color.Transparent;
            this.load.Image = ((System.Drawing.Image)(resources.GetObject("load.Image")));
            this.load.ImageRotate = 0F;
            this.load.Location = new System.Drawing.Point(835, 0);
            this.load.Name = "load";
            this.load.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.load.Size = new System.Drawing.Size(111, 106);
            this.load.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.load.TabIndex = 27;
            this.load.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(549, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 55);
            this.label1.TabIndex = 16;
            this.label1.Text = "Books";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(396, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.OrangeRed;
            this.label7.Location = new System.Drawing.Point(284, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 55);
            this.label7.TabIndex = 14;
            this.label7.Text = "View";
            // 
            // txtsearchBox
            // 
            this.txtsearchBox.Animated = true;
            this.txtsearchBox.AutoRoundedCorners = true;
            this.txtsearchBox.BorderRadius = 17;
            this.txtsearchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearchBox.DefaultText = "";
            this.txtsearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearchBox.ForeColor = System.Drawing.Color.Black;
            this.txtsearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearchBox.Location = new System.Drawing.Point(380, 127);
            this.txtsearchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearchBox.Name = "txtsearchBox";
            this.txtsearchBox.PasswordChar = '\0';
            this.txtsearchBox.PlaceholderText = "";
            this.txtsearchBox.SelectedText = "";
            this.txtsearchBox.Size = new System.Drawing.Size(215, 37);
            this.txtsearchBox.TabIndex = 16;
            this.txtsearchBox.TextChanged += new System.EventHandler(this.txtsearchBox_TextChanged);
            // 
            // btnrefresh
            // 
            this.btnrefresh.Animated = true;
            this.btnrefresh.AutoRoundedCorners = true;
            this.btnrefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnrefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnrefresh.BorderRadius = 15;
            this.btnrefresh.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnrefresh.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnrefresh.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnrefresh.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnrefresh.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnrefresh.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnrefresh.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnrefresh.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnrefresh.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnrefresh.FillColor = System.Drawing.Color.OrangeRed;
            this.btnrefresh.FocusedColor = System.Drawing.Color.Black;
            this.btnrefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnrefresh.ForeColor = System.Drawing.Color.White;
            this.btnrefresh.Location = new System.Drawing.Point(612, 128);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(80, 33);
            this.btnrefresh.TabIndex = 22;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseTransparentBackground = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Book Name";
            // 
            // detailsp
            // 
            this.detailsp.BackColor = System.Drawing.Color.PeachPuff;
            this.detailsp.Controls.Add(this.txtDateBox);
            this.detailsp.Controls.Add(this.btnDelete);
            this.detailsp.Controls.Add(this.btnUpdate);
            this.detailsp.Controls.Add(this.btnCancel);
            this.detailsp.Controls.Add(this.txtBookGenre);
            this.detailsp.Controls.Add(this.label10);
            this.detailsp.Controls.Add(this.txtQuantity);
            this.detailsp.Controls.Add(this.txtBookPrice);
            this.detailsp.Controls.Add(this.label6);
            this.detailsp.Controls.Add(this.label8);
            this.detailsp.Controls.Add(this.label9);
            this.detailsp.Controls.Add(this.txtPublication);
            this.detailsp.Controls.Add(this.txtAuthor);
            this.detailsp.Controls.Add(this.txtBookName);
            this.detailsp.Controls.Add(this.label4);
            this.detailsp.Controls.Add(this.label3);
            this.detailsp.Controls.Add(this.label5);
            this.detailsp.Location = new System.Drawing.Point(12, 485);
            this.detailsp.Name = "detailsp";
            this.detailsp.Size = new System.Drawing.Size(946, 266);
            this.detailsp.TabIndex = 25;
            this.detailsp.Paint += new System.Windows.Forms.PaintEventHandler(this.detailsp_Paint);
            // 
            // txtDateBox
            // 
            this.txtDateBox.Animated = true;
            this.txtDateBox.AutoRoundedCorners = true;
            this.txtDateBox.BackColor = System.Drawing.Color.Transparent;
            this.txtDateBox.BorderRadius = 17;
            this.txtDateBox.Checked = true;
            this.txtDateBox.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDateBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDateBox.Location = new System.Drawing.Point(662, 42);
            this.txtDateBox.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtDateBox.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtDateBox.Name = "txtDateBox";
            this.txtDateBox.Size = new System.Drawing.Size(206, 36);
            this.txtDateBox.TabIndex = 27;
            this.txtDateBox.Value = new System.DateTime(2023, 10, 22, 15, 42, 16, 311);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderRadius = 18;
            this.btnDelete.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.FocusedColor = System.Drawing.Color.Black;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(533, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 38);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseTransparentBackground = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Animated = true;
            this.btnUpdate.AutoRoundedCorners = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BorderRadius = 18;
            this.btnUpdate.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FillColor = System.Drawing.Color.OrangeRed;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Black;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(788, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 38);
            this.btnUpdate.TabIndex = 57;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseTransparentBackground = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.AutoRoundedCorners = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderRadius = 18;
            this.btnCancel.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.btnCancel.FillColor = System.Drawing.Color.DimGray;
            this.btnCancel.FocusedColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(689, 197);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 38);
            this.btnCancel.TabIndex = 56;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseTransparentBackground = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBookGenre
            // 
            this.txtBookGenre.Animated = true;
            this.txtBookGenre.AutoRoundedCorners = true;
            this.txtBookGenre.BorderRadius = 15;
            this.txtBookGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookGenre.DefaultText = "";
            this.txtBookGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookGenre.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtBookGenre.ForeColor = System.Drawing.Color.Black;
            this.txtBookGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookGenre.Location = new System.Drawing.Point(219, 208);
            this.txtBookGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookGenre.Name = "txtBookGenre";
            this.txtBookGenre.PasswordChar = '\0';
            this.txtBookGenre.PlaceholderText = "";
            this.txtBookGenre.SelectedText = "";
            this.txtBookGenre.Size = new System.Drawing.Size(229, 32);
            this.txtBookGenre.TabIndex = 55;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(52, 212);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "Book Genre";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Animated = true;
            this.txtQuantity.AutoRoundedCorners = true;
            this.txtQuantity.BorderRadius = 15;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(662, 137);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(162, 32);
            this.txtQuantity.TabIndex = 52;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Animated = true;
            this.txtBookPrice.AutoRoundedCorners = true;
            this.txtBookPrice.BorderRadius = 15;
            this.txtBookPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookPrice.DefaultText = "";
            this.txtBookPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookPrice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtBookPrice.ForeColor = System.Drawing.Color.Black;
            this.txtBookPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookPrice.Location = new System.Drawing.Point(662, 86);
            this.txtBookPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.PasswordChar = '\0';
            this.txtBookPrice.PlaceholderText = "";
            this.txtBookPrice.SelectedText = "";
            this.txtBookPrice.Size = new System.Drawing.Size(162, 32);
            this.txtBookPrice.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(489, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 23);
            this.label6.TabIndex = 48;
            this.label6.Text = "Book Quantity";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(489, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Book Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(488, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 23);
            this.label9.TabIndex = 50;
            this.label9.Text = "Book Purchase Date";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtPublication
            // 
            this.txtPublication.Animated = true;
            this.txtPublication.AutoRoundedCorners = true;
            this.txtPublication.BorderRadius = 15;
            this.txtPublication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublication.DefaultText = "";
            this.txtPublication.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPublication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPublication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublication.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublication.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublication.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtPublication.ForeColor = System.Drawing.Color.Black;
            this.txtPublication.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublication.Location = new System.Drawing.Point(219, 161);
            this.txtPublication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPublication.Name = "txtPublication";
            this.txtPublication.PasswordChar = '\0';
            this.txtPublication.PlaceholderText = "";
            this.txtPublication.SelectedText = "";
            this.txtPublication.Size = new System.Drawing.Size(229, 32);
            this.txtPublication.TabIndex = 47;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Animated = true;
            this.txtAuthor.AutoRoundedCorners = true;
            this.txtAuthor.BorderRadius = 15;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Location = new System.Drawing.Point(219, 103);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.PlaceholderText = "";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(229, 32);
            this.txtAuthor.TabIndex = 46;
            // 
            // txtBookName
            // 
            this.txtBookName.Animated = true;
            this.txtBookName.AutoRoundedCorners = true;
            this.txtBookName.BorderRadius = 15;
            this.txtBookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBookName.DefaultText = "";
            this.txtBookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.txtBookName.ForeColor = System.Drawing.Color.Black;
            this.txtBookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBookName.Location = new System.Drawing.Point(219, 46);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.PasswordChar = '\0';
            this.txtBookName.PlaceholderText = "";
            this.txtBookName.SelectedText = "";
            this.txtBookName.Size = new System.Drawing.Size(229, 32);
            this.txtBookName.TabIndex = 45;
            this.txtBookName.TextChanged += new System.EventHandler(this.txtBookName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(52, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Book Publication";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Book Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 42;
            this.label5.Text = "Book Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Carnelian Cond", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(425, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 80);
            this.label11.TabIndex = 26;
            this.label11.Text = "Details";
            // 
            // txtView
            // 
            this.txtView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.txtView.BackgroundColor = System.Drawing.Color.Wheat;
            this.txtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.txtView.Location = new System.Drawing.Point(12, 173);
            this.txtView.Name = "txtView";
            this.txtView.Size = new System.Drawing.Size(946, 281);
            this.txtView.TabIndex = 24;
            this.txtView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.txtView_CellClick);
            // 
            // ViewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1000, 520);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.detailsp);
            this.Controls.Add(this.txtView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.txtsearchBox);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewBook";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewBook";
            this.Load += new System.EventHandler(this.ViweBook_Load);
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.load)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.detailsp.ResumeLayout(false);
            this.detailsp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtsearchBox;
        private Guna.UI2.WinForms.Guna2Button btnrefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel detailsp;
        private Guna.UI2.WinForms.Guna2TextBox txtPublication;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtBookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private Guna.UI2.WinForms.Guna2TextBox txtBookPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtBookGenre;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtDateBox;
        private Guna.UI2.WinForms.Guna2CirclePictureBox load;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView txtView;
    }
}