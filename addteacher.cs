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
    public partial class addteacher : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.; Database=school; Integrated Security=SSPI;");
        SqlCommand cmd;
        string query;

        public addteacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            

        }
    }
}
