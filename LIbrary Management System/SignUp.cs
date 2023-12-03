using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LIbrary_Management_System
{
    public partial class signUpfrm : Form
    {
        public signUpfrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Unsaved DATA.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Hide();
                this.Close();
                Login frm = new Login();
                frm.ShowDialog();
            }
        }

        private void signUpfrm_Load(object sender, EventArgs e)
        {

        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFname.Text != "" && txtID.Text != "" && txtusername.Text != "" && txtpassword.Text != "" && txtemail.Text != "" && txtphone.Text != "")
            {
                String fname = txtFname.Text;
                String id = txtID.Text;
                String username = txtusername.Text;
                String password = txtpassword.Text;
                String email = txtemail.Text;
                String phone = txtphone.Text;
                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into librarian (fullName,userID,userName,userPass,email,phone) values ('" + fname + "','" + id + "','" + username + "','" + password + "','" + email + "','" + phone + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Account Created Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFname.Clear();
                txtID.Clear();
                txtusername.Clear();
                txtpassword.Clear();
                txtemail.Clear();
                txtphone.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtID.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtemail.Clear();
            txtphone.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
