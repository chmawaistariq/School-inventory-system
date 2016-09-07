using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
            SqlDataAdapter da;
            DataSet ds = new System.Data.DataSet();
            string query;
            if (rb_admin.Checked == true)
            {
                query = "select * from user_details where username='" + txt_username.Text.Trim() + "' and password='" + txt_pwd.Text.Trim() + "' and usertype='Admin'";
                da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Admin _admin = new Admin();
                    _admin.Show();
                    //this.Hide();
                }
                else
                MessageBox.Show("Invalid Username and Password...");
            }
            else
            {
                query = "select * from user_details where username='" + txt_username.Text.Trim() + "' and password='" + txt_pwd.Text.Trim() + "' and usertype='Teacher'";
                da = new SqlDataAdapter(query, con);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Teachers _teacher = new Teachers();
                    _teacher.Show();
                    //this.Hide();
                }
                else
                    MessageBox.Show("Invalid Username and Password...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin _admin = new Admin();
            _admin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teachers _teacher = new Teachers();
            _teacher.Show();
        }
    }
}
