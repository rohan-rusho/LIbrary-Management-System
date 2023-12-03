using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using LIbrary_Management_System;
using System.Drawing;

namespace LIbrary_Management_System
{


    internal class MainClass
    {
        

        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-0NN6H79; Initial Catalog=Library_Management_System; Integrated Security=True;");
        public static string usrnm;
        public static bool IsValidUser(string user, string pass)
        {
            bool isValid = false;
            string qry = @"Select * from librarian where userName = '" + user + "' and userPass = '" + pass + "' ";
            SqlCommand cmd = new SqlCommand(qry, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                isValid = true;
                usrnm = user;
            }

            return isValid;

        }
        
            



            





    }

}
