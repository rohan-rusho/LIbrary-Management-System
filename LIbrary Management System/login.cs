using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrary_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            loginButton.Parent = PictureBox1;
            loginButton.BackColor = Color.Transparent;
            clearBotton.Parent = PictureBox1;
            clearBotton.BackColor = Color.Transparent;
            usernameBox.Parent = PictureBox1;
            usernameBox.BackColor = Color.Transparent;
            passwordBox.Parent = PictureBox1;
            passwordBox.BackColor = Color.Transparent;
            label1.Parent = PictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = PictureBox1;
            label2.BackColor = Color.Transparent;
            guna2CirclePictureBox1.Parent = PictureBox1;
            guna2CirclePictureBox1.BackColor = Color.Transparent;
            signUpbtn.Parent = PictureBox1;
            signUpbtn.BackColor = Color.Transparent;
            checkBoxpass.Parent = PictureBox1;
            checkBoxpass.BackColor = Color.Transparent;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            


            if (MainClass.IsValidUser(usernameBox.Text, passwordBox.Text) == false)
            {
                msgbox.Show("Invalid Username or Password");
                return;
            }
            else
            {

                this.Hide();
                dashboard frm = new dashboard();
                
                frm.ShowDialog();
                
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passwordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void clearBotton_Click(object sender, EventArgs e)
        {
            usernameBox.Clear();
            passwordBox.Clear();
        }

        private void signUpbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpfrm frm = new signUpfrm();
            frm.ShowDialog();
        }

        private void checkBoxpass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxpass.Checked == true)
            {
                passwordBox.PasswordChar = '\0';
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }
    }
}
