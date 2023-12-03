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
    public partial class ViewBook : Form
    {
        public ViewBook()
        {
            InitializeComponent();
        }

        private void ViweBook_Load(object sender, EventArgs e)
        {

            txtDateBox.MaxDate = DateTime.Today;
            load.Visible = false;

            load.BackColor = Color.Transparent;
            detailsp.Visible = false;
            MaximizeBox = false;
            MinimizeBox = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "Select * from Book_Info";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
           cmd.ExecuteNonQuery();
           con.Close();
            da.Fill(ds);

            txtView.DataSource = ds.Tables[0];
        }
         
        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        int bid;
        Int64 rowid;
        private void txtView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(txtView.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(txtView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            detailsp.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = " Select * from Book_Info where Id=" + bid + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            con.Close();
            da.Fill(ds);


            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtBookName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtBookGenre.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPublication.Text = ds.Tables[0].Rows[0][4].ToString();
            txtDateBox.Text = ds.Tables[0].Rows[0][5].ToString();
            txtBookPrice.Text = ds.Tables[0].Rows[0][6].ToString();
            txtQuantity.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            detailsp.Visible = false;
        }

        private void txtsearchBox_TextChanged(object sender, EventArgs e)
        {
            if(txtsearchBox.Text !="")
            {
                load.Visible = true;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Select * from Book_Info where Book_Name LIKE '" + txtsearchBox.Text+ "%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);

                txtView.DataSource = ds.Tables[0];
            }
            else
            {
                load.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Select * from Book_Info";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);

                txtView.DataSource = ds.Tables[0];

            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            load.Visible = false;
            txtsearchBox.Clear();
            detailsp.Visible = false;
            ViweBook_Load(this, null);


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "" && txtAuthor.Text != "" && txtPublication.Text != "" && txtBookGenre.Text != "" && txtBookPrice.Text != "" && txtQuantity.Text != "")
            {
                if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String bname = txtBookName.Text;
                    String bauthor = txtAuthor.Text;
                    String bgenre = txtBookGenre.Text;
                    String publication = txtPublication.Text;
                    String pdate = txtDateBox.Text;
                    String price = txtBookPrice.Text;
                    String quan = txtQuantity.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "update Book_Info set Book_Name='" + bname + "',    [Author_Name(s)]='" + bauthor + "', Genre='" + bgenre + "', Publisher= '" + publication + "',Purchase_Date = '" + pdate + "', Price = '" + price + "',Qty= '" + quan + "' where Id=" + rowid + " ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    da.Fill(ds);

                    ViweBook_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowesd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted. Confirm?", "Confirmation Dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "delete from Book_Info where Id="+rowid+"";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);
            }
        }

        private void detailsp_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
