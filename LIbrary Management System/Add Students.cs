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
    public partial class Add_Students : Form
    {
        public Add_Students()
        {
            InitializeComponent();
        }

        private void txtBookPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Unsaved DATA.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
               
                this.Close();
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtID.Clear();
            txtGender.Clear();
            txtDepertment.Clear();
            txtSemester.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtID.Text != "" && txtGender.Text != "" && txtDepertment.Text != "" && txtSemester.Text != "" && txtSemester.Text != "" && txtEmail.Text != "" && txtMobile.Text != "")
            {
            String name =txtName.Text;
            String id =txtID.Text;
            String gender = txtGender.Text;
            String depert = txtDepertment.Text;
            String semester = txtSemester.Text;
            String email = txtEmail.Text;
            String mobile = txtMobile.Text;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into Student_Info (s_Name,s_ID,s_gender,s_depertment,c_semester,s_email,s_mobile) values ('" + name + "','" + id + "','" + gender + "','" + depert + "','" + semester + "','" + email + "','" + mobile + "')";

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Student Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtName.Clear();
            txtID.Clear();
            txtGender.Clear();
            txtDepertment.Clear();
            txtSemester.Clear();
            txtEmail.Clear();
            txtMobile.Clear();

        }
            else
            {
                MessageBox.Show("Please Fill Empty Value", "Suggest", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

}

        private void Add_Students_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
