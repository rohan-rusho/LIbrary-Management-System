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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            txtreturndate.Value = DateTime.Now;
            //txtreturndate.MaxDate = DateTime.Today;
            load.Visible = false;
            detailsp.Visible = false;
            txtsearchBox.Clear();

        }

        private void txtsearchBox_TextChanged(object sender, EventArgs e)
        {
            if(txtsearchBox.Text != "")
            {
                load.Visible = true;

            }
            else
            {
                detailsp.Visible = false;
                load.Visible = false;
                dataGridView1.DataSource = null;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearchSt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            
            cmd.CommandText = "select * from IRBook where s_ID ='"+txtsearchBox.Text+"' and Book_Return_Date is null";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            else
            {
                dataGridView1.DataSource = null;

                MessageBox.Show("Invalid Student ID OR No Book Issued.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            } 
                
            
        }

        String bname;
        String bdate;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            detailsp.Visible = true;
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                rowid = Int64.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                bname = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                bdate = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            }
            txtbName.Text = bname;
            txtissuedate.Text = bdate;

        }

        private void btnrtn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
           
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = "update IRBook set Book_Return_Date ='" + txtreturndate.Text + "' where s_ID = '" +txtsearchBox.Text+"' and ID ="+rowid+" ";
            cmd.ExecuteNonQuery();
            con.Close();



            SqlCommand cmd2 = new SqlCommand();
            cmd2.Connection = con;

            con.Open();
            cmd2.CommandText = "update  Book_Info set Qty= (Qty+1) where Book_Name= '" + txtbName.Text + "'";
            cmd2.ExecuteNonQuery();
            con.Close();


            MessageBox.Show("Book Returned Succesfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ReturnBook_Load(this, null);
           
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txtsearchBox.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            detailsp.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
