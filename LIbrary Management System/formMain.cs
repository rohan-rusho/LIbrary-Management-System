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
    public partial class dashboard : Form
    {
        public static object Instance { get; internal set; }

        public dashboard()
        {
            InitializeComponent();
        }
        private void dashboard_Load(object sender, EventArgs e)
        {
           
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
            //msgbox.Show("Welcome To LIBRARY MANAGEMENT SYSTEM");
            MessageBox.Show ("Welcome To LIBRARY MANAGEMENT SYSTEM '" + MainClass.usrnm + "'", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            

            
        }

       

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.ShowDialog();
        }

        private void addNewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (AddBooks frm = new AddBooks())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                   // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }
        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (ViewBook frm = new ViewBook())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                    // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (Add_Students frm = new Add_Students())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                    // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (ViewStudent frm = new ViewStudent())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                    // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }

        private void issueNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (IssueBooks frm = new IssueBooks())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                    // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }

        private void iSSUEBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rETURNHEREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (ReturnBook frm = new ReturnBook())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                    // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }

        private void eNTERHEREToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmOverlay = new Form();
            try
            {
                using (CompleteBookDetails frm = new CompleteBookDetails())
                {
                    frmOverlay.StartPosition = FormStartPosition.CenterScreen;
                    frmOverlay.FormBorderStyle = FormBorderStyle.None;
                    frmOverlay.Opacity = 0.5d;
                    frmOverlay.BackColor = Color.Black;
                    frmOverlay.WindowState = FormWindowState.Maximized;
                    // frmOverlay.TopMost = true;
                    frmOverlay.Location = this.Location;
                    frmOverlay.ShowInTaskbar = false;
                    frmOverlay.Show();
                    frm.Owner = frmOverlay;
                    frm.ShowDialog();
                    frmOverlay.Dispose();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { frmOverlay.Dispose(); }
        }

        private void rETURNBOOKToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bOOKSToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentcount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            txtclock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
