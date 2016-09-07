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
    public partial class Admission : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
        SqlCommand cmd;
        string query;
        public Admission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dob = cb_date.Text+"/"+cb_month.Text+"/"+cb_year.Text;
            string gender;
            if(rb_male.Checked==true)
            {
                gender=rb_male.Text;
            }
            else{
                gender=rb_female.Text;
            }
            query = "Insert into admission(admissionid, admissiondate, name, fathername, mothername, dob, gender, address, admission_for, previous_schoolname) values('" + txt_admission_no.Text + "', '" + txt_date_admission.Text + "', '" + txt_name.Text + "','" + txt_fathername.Text + "','" + txt_mothername.Text + "', '" + dob + "', '" + gender + "', '" + txt_permanent_address.Text + "', '" + cb_class.Text + "', '" + txt_previous_school.Text + "')";
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        
    }
}
