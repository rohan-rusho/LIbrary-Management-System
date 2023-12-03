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
    public partial class ViewStudent : Form
    {
        public ViewStudent()
        {
            InitializeComponent();
            load.Visible = false;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtsearchBox_TextChanged(object sender, EventArgs e)
        {
            if(txtsearchBox.Text!="")
            {

                load.Visible = true;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Select * from Student_Info where s_ID LIKE '"+ txtsearchBox.Text + "%' order by ID";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);
                txtview.DataSource = ds.Tables[0];
            }
            else
            {
                load.Visible = false;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Select * from Student_Info order by ID";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);

                txtview.DataSource = ds.Tables[0];
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewStudent_Load(object sender, EventArgs e)
        {
            detailsp.Visible = false;
            MaximizeBox = false;
            MinimizeBox = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from Student_Info order by ID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            con.Close();
            da.Fill(ds);

            txtview.DataSource = ds.Tables[0];
        }

        private void txtview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int bid;
        Int64 rowid;
        private void txtview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtview.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(txtview.Rows[e.RowIndex].Cells[0].Value.ToString()); 
            }
            
            detailsp.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = " Select * from Student_Info where ID=" + bid + " order by ID ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            con.Close();
            da.Fill(ds);


            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtsName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtsid.Text = ds.Tables[0].Rows[0][2].ToString();
            txtsgender.Text = ds.Tables[0].Rows[0][3].ToString();
            txtsdept.Text = ds.Tables[0].Rows[0][4].ToString();
            txtcsemester.Text = ds.Tables[0].Rows[0][5].ToString();
            txtsemail.Text = ds.Tables[0].Rows[0][6].ToString();
            txtsmobile.Text = ds.Tables[0].Rows[0][7].ToString();
            
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {

            load.Visible = false;
            txtsearchBox.Clear();
            detailsp.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "select * from Student_Info order by ID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            con.Close();
            da.Fill(ds);

            txtview.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data Will Be Deleted...Confirm?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String sname = txtsName.Text;
                String sid = txtsid.Text;
                String sgender = txtsgender.Text;
                String sdept = txtsdept.Text;
                String csemester = txtcsemester.Text;
                String semail = txtsemail.Text;
                String smobile = txtsmobile.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "delete from Student_Info where ID='"+rowid+"'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);
                ViewStudent_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            detailsp.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtsName.Text != "" && txtsid.Text != "" && txtsgender.Text != "" && txtsdept.Text != "" && txtcsemester.Text != "" && txtsemail.Text != "" && txtsmobile.Text!=  "")
            {
                if (MessageBox.Show("Data Will Be Updated. Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    String sname = txtsName.Text;
                    String sid = txtsid.Text;
                    String sgender = txtsgender.Text;
                    String sdept = txtsdept.Text;
                    String csemester = txtcsemester.Text;
                    String semail = txtsemail.Text;
                    String smobile = txtsmobile.Text;

                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;

                    con.Open();
                    cmd.CommandText = "update Student_Info set s_Name='" + sname + "',    s_ID='" + sid + "', s_gender='" + sgender + "', s_depertment= '" + sdept + "',c_semester = '" + csemester + "', s_email = '" + semail + "',s_mobile= '" + smobile + "' where ID=" + rowid + " ";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    da.Fill(ds);
                    ViewStudent_Load(this, null);
                }
            }
            else
            {
                MessageBox.Show("Empty Field Not Allowesd", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtsName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
