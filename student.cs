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

namespace StudentAdd
{
    public partial class student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
        SqlCommand cmd;
        string query;

        public student()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string dob = cb_date.Text+"/"+cb_month.Text+"/"+cb_year.Text;
            string gender;
            if(rb_male.Checked==true)
            {
                gender=rb_male.Text;
            }
            else{
                gender=radioButton1.Text;
            }
            query = "Insert into student(studname, rollno, fathername, mothername, dob, gender, class, contact, hno, city, address1, address2, state, pincode) values('" + txtname.Text + "','" + txtrollno.Text + "', '" + txtfathername.Text + "','" + txtmothername.Text + "','" + dob + "','" + gender + "','" + cb_class.Text + "','" + txtcontactno.Text + "','" + txthno.Text + "','" + txtcity.Text + "','" + txtaddress1.Text + "','" + txtaddress2.Text + "','" + txtstate.Text + "','" + txtpincode.Text + "')";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfathername.Clear();
            txtmothername.Clear();
            txtcontactno.Clear();
            txthno.Clear();
            txtcity.Clear();
            txtaddress1.Clear();
            txtaddress2.Clear();
            txtstate.Clear();
            txtpincode.Clear();
        } 

    }
}
