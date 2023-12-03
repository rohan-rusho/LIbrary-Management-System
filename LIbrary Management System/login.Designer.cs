namespace LIbrary_Management_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.msgbox = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.clearBotton = new Guna.UI2.WinForms.Guna2Button();
            this.signUpbtn = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Animated = true;
            this.usernameBox.AutoRoundedCorners = true;
            this.usernameBox.BorderRadius = 16;
            this.usernameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameBox.DefaultText = "";
            this.usernameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.usernameBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.usernameBox.ForeColor = System.Drawing.Color.Black;
            this.usernameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameBox.IconLeftSize = new System.Drawing.Size(0, 0);
            this.usernameBox.Location = new System.Drawing.Point(92, 225);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.PasswordChar = '\0';
            this.usernameBox.PlaceholderText = "";
            this.usernameBox.SelectedText = "";
            this.usernameBox.Size = new System.Drawing.Size(343, 35);
            this.usernameBox.TabIndex = 0;
            this.usernameBox.TextChanged += new System.EventHandler(this.usernameBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(88, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(88, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Animated = true;
            this.passwordBox.AutoRoundedCorners = true;
            this.passwordBox.BorderRadius = 16;
            this.passwordBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordBox.DefaultText = "";
            this.passwordBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordBox.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.passwordBox.FocusedState.FillColor = System.Drawing.Color.White;
            this.passwordBox.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.passwordBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordBox.ForeColor = System.Drawing.Color.Black;
            this.passwordBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordBox.Location = new System.Drawing.Point(92, 291);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '●';
            this.passwordBox.PlaceholderText = "";
            this.passwordBox.SelectedText = "";
            this.passwordBox.Size = new System.Drawing.Size(343, 35);
            this.passwordBox.TabIndex = 2;
            this.passwordBox.UseSystemPasswordChar = true;
            this.passwordBox.TextChanged += new System.EventHandler(this.passwordBox_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.AutoRoundedCorners = true;
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderColor = System.Drawing.Color.Transparent;
            this.loginButton.BorderRadius = 18;
            this.loginButton.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.loginButton.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.loginButton.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.loginButton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.loginButton.FillColor = System.Drawing.Color.OrangeRed;
            this.loginButton.FocusedColor = System.Drawing.Color.Black;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(298, 333);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(80, 38);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseTransparentBackground = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // msgbox
            // 
            this.msgbox.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgbox.Caption = null;
            this.msgbox.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgbox.Parent = this;
            this.msgbox.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgbox.Text = null;
            // 
            // clearBotton
            // 
            this.clearBotton.Animated = true;
            this.clearBotton.AutoRoundedCorners = true;
            this.clearBotton.BackColor = System.Drawing.Color.Transparent;
            this.clearBotton.BorderColor = System.Drawing.Color.Transparent;
            this.clearBotton.BorderRadius = 18;
            this.clearBotton.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.clearBotton.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.clearBotton.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.clearBotton.CustomBorderColor = System.Drawing.Color.Transparent;
            this.clearBotton.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.clearBotton.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.clearBotton.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.clearBotton.DisabledState.ForeColor = System.Drawing.Color.Transparent;
            this.clearBotton.FillColor = System.Drawing.Color.DimGray;
            this.clearBotton.FocusedColor = System.Drawing.Color.Black;
            this.clearBotton.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.clearBotton.ForeColor = System.Drawing.Color.White;
            this.clearBotton.Location = new System.Drawing.Point(150, 333);
            this.clearBotton.Name = "clearBotton";
            this.clearBotton.Size = new System.Drawing.Size(80, 38);
            this.clearBotton.TabIndex = 7;
            this.clearBotton.Text = "Clear";
            this.clearBotton.UseTransparentBackground = true;
            this.clearBotton.Click += new System.EventHandler(this.clearBotton_Click);
            // 
            // signUpbtn
            // 
            this.signUpbtn.Animated = true;
            this.signUpbtn.AutoRoundedCorners = true;
            this.signUpbtn.BackColor = System.Drawing.Color.Transparent;
            this.signUpbtn.BorderRadius = 12;
            this.signUpbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.signUpbtn.ForeColor = System.Drawing.Color.White;
            this.signUpbtn.Location = new System.Drawing.Point(365, 395);
            this.signUpbtn.Name = "signUpbtn";
            this.signUpbtn.Size = new System.Drawing.Size(158, 27);
            this.signUpbtn.TabIndex = 8;
            this.signUpbtn.Text = "New here ? Try Sign-UP";
            this.signUpbtn.Click += new System.EventHandler(this.signUpbtn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(240, 175);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(60, 47);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 6;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.ImageRotate = 0F;
            this.PictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(537, 433);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.UseTransparentBackground = true;
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.ForeColor = System.Drawing.Color.OrangeRed;
            this.checkBoxpass.Location = new System.Drawing.Point(186, 273);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxpass.TabIndex = 9;
            this.checkBoxpass.Text = "Show-Password";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBoxpass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(535, 434);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.signUpbtn);
            this.Controls.Add(this.clearBotton);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.PictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox usernameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox passwordBox;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2MessageDialog msgbox;
        private Guna.UI2.WinForms.Guna2PictureBox PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Button clearBotton;
        private Guna.UI2.WinForms.Guna2GradientTileButton signUpbtn;
        private System.Windows.Forms.CheckBox checkBoxpass;
    }
}

