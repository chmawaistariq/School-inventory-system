using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace School
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btn_Admission_Click(object sender, EventArgs e)
        {
            Admission _admission = new Admission();
            _admission.Show();
            _admission.Size = new System.Drawing.Size(900, 650);
        }

        private void btn_Tuition_Fees_Click(object sender, EventArgs e)
        {
            studentfees _payment = new studentfees();
            _payment.Show();
            _payment.Size = new System.Drawing.Size(900, 400);
        }

        private void btn_Teacher_Click(object sender, EventArgs e)
        {
            addteacher _addteacher = new addteacher();
            _addteacher.Show();
            _addteacher.Size = new System.Drawing.Size(900, 450);
        }
    }
}
