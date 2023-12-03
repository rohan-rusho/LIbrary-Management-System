using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrary_Management_System
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
            load.Visible = false;
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            txtDateTimepi.Value = DateTime.Now;
            
            load.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "Select Book_Name from Book_Info order by ID";
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                for(int i=0;i<sdr.FieldCount;i++)
                {
                    txtcombo.Items.Add(sdr.GetString(i));
                }
            }
            sdr.Close();
            con.Close();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (txtsearchBox.Text != "")
            {
                load.Visible = true;
                txtsName.Clear();
                txtsDepartment.Clear();
                txtsemester.Clear();
                txtemail.Clear();
                txtmobile.Clear();
            }
            else
            {
                load.Visible = false;
            }

        }

        int count;
        private void btnSearchSt_Click(object sender, EventArgs e)
        {
            if(txtsearchBox.Text!="")
            {
                String sid = txtsearchBox.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "select * from Student_Info where s_ID = '" + sid + "'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da.Fill(ds);

                //----------------------------------------------------------------------------------------------
                //for code to count , how many boks has been issued on this student id
                con.Open();
                cmd.CommandText = "select count(s_id) from IRBook where s_ID = '" + sid + "' and Book_Return_Date is null";
                SqlDataAdapter da1 = new SqlDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                cmd.ExecuteNonQuery();
                con.Close();
                da1.Fill(ds1);

                count = int.Parse(ds1.Tables[0].Rows[0][0].ToString());

                //----------------------------------------------------------------------------------------------

                if (ds.Tables[0].Rows.Count !=0)
                {
                    txtsName.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtsDepartment.Text= ds.Tables[0].Rows[0][4].ToString();
                    txtsemester.Text= ds.Tables[0].Rows[0][5].ToString();
                    txtemail.Text= ds.Tables[0].Rows[0][6].ToString();
                    txtmobile.Text = ds.Tables[0].Rows[0][7].ToString();
                    
                }
                else
                {
                    txtsName.Clear();
                    txtsDepartment.Clear();
                    txtsemester.Clear();
                    txtemail.Clear();
                    txtmobile.Clear();
                    
                    MessageBox.Show("Invalid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (txtsName.Text != "")
            {
                if (txtcombo.SelectedIndex != -1 && count <= 2)
                {
                    String ssid = txtsearchBox.Text;
                    String sname = txtsName.Text;
                    String sdept = txtsDepartment.Text;
                    String semester = txtsemester.Text;
                    String semail = txtemail.Text;
                    String smobile = txtmobile.Text;
                    String bname = txtcombo.Text;
                    String bookissuedate = txtDateTimepi.Text;
                    String sid = txtsearchBox.Text;

                    int book_q=0;
                    

                        SqlConnection con = new SqlConnection();
                        con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
                        SqlCommand cmd1 = new SqlCommand();
                        cmd1.Connection = con;
                        con.Open();
                        cmd1.CommandText = "select * from Book_Info where Book_Name= '" + txtcombo.Text + "'";
                        DataTable dl2 = new DataTable();
                        SqlDataAdapter da2 = new SqlDataAdapter(cmd1);
                        da2.Fill(dl2);
                        foreach (DataRow dr2 in dl2.Rows)
                        {
                            book_q = Convert.ToInt32(dr2["Qty"].ToString());
                        }

                        cmd1.ExecuteNonQuery();
                        con.Close();
                    if (book_q >= 1)
                    {


                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;

                        con.Open();
                        cmd.CommandText = "insert into IRBook (s_ID,s_Name,s_Department,s_semester,s_email,s_mobile,Book_Name,Book_Issue_Date) values ('" + ssid + "','" + sname + "','" + sdept + "','" + semester + "','" + semail + "','" + smobile + "','" + bname + "','" + bookissuedate + "')";

                        cmd.ExecuteNonQuery();
                        con.Close();



                        MessageBox.Show("Book Issued Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);



                        SqlCommand cmd2 = new SqlCommand();
                        cmd2.Connection = con;

                        con.Open();
                        cmd2.CommandText = "update  Book_Info set Qty= (Qty-1) where Book_Name= '" + txtcombo.Text + "'";
                        cmd2.ExecuteNonQuery();
                        con.Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("Sorry, Out of Stock Currently.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    MessageBox.Show("Select Book OR Maximum Number Of Book Has Been Issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            else
            {
                MessageBox.Show("Enter a valid Student ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            IssueBooks_Load(this, null);
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            load.Visible = false;
            txtsearchBox.Clear();
            txtsName.Clear();
            txtsDepartment.Clear();
            txtsemester.Clear();
            txtemail.Clear();
            txtmobile.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)== DialogResult.OK)
            {
                this.Close();
            }
        }

        private void txtDateTimepi_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
