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
   

    public partial class AddBooks : Form
    {
       
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            DateTimePicker1.Value = DateTime.Now;
           // DateTimePicker1.MaxDate = DateTime.Today;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != ""  && txtGenre.Text!= "" && txtBookPrice.Text != "" && txtQuantity.Text != "")
            {
                String bname = txtBookName.Text;
                String bauthor = txtAuthor.Text;
                String bgenre = txtGenre.Text;
                String publication = txtPublication.Text;
                String pdate = DateTimePicker1.Text;
                String price = txtBookPrice.Text;
                String quan = txtQuantity.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;"; 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into Book_Info (Book_Name,[Author_Name(s)],Genre,Publisher,Purchase_Date,Price,Qty) values ('" + bname + "','" + bauthor + "','" + bgenre + "','" + publication + "','" + pdate + "','" + price + "','" + quan + "')";

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Book Added Succesfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBookName.Clear();
                txtAuthor.Clear();
                txtPublication.Clear();
                txtGenre.Clear();
                txtBookPrice.Clear();
                txtQuantity.Clear();

            }
            else
            {
                MessageBox.Show("Empty Field Not Allowed","Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtGenre.Clear();
            txtQuantity.Clear();
            txtBookPrice.Clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("This will DELETE your Unsaved DATA.", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
