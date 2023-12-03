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
using System.Net.Mail;
using System.Net;

namespace LIbrary_Management_System
{
    public partial class CompleteBookDetails : Form
    {
        public CompleteBookDetails()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CompleteBookDetails_Load(object sender, EventArgs e)
        {

            detailsp.Visible = false;
            panel1.Visible = false;


            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            cmd.CommandText = "select * from IRBook where Book_Return_Date is null";
            
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds);
            txtgridissed.DataSource = ds.Tables[0];

            //-----------------------

            cmd.CommandText = "select * from IRBook where Book_Return_Date is not null";

            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            txtgridreturn.DataSource =ds1.Tables[0];

        }
        int bid;
        private void txtgridissed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtgridissed.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(txtgridissed.Rows[e.RowIndex].Cells[0].Value.ToString());
                // MessageBox.Show(txtView.Rows[e.RowIndex].Cells[0].Value.ToString());

            }

            detailsp.Visible = true;
            panel1.Visible = true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;


            con.Open();
            cmd.CommandText = " Select * from IRBook where ID=" + bid + " ";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            con.Close();
            da.Fill(ds);


            //rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtmailbox.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
           
            panel1.Visible = false;
            detailsp.Visible = false;
            txtmailbox.Clear();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;

            smtp.Credentials = new NetworkCredential("21225103292@cse.bubt.edu.bd", "dhjh emux rhnr saok");
            MailMessage mail = new MailMessage("21225103292@cse.bubt.edu.bd", txtmailbox.Text , "Reminder: Overdue Book Return Notice", txtmailbody.Text );
            mail.Priority = MailPriority.High;
            smtp.Send(mail);
            MessageBox.Show("Mail Send Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
