using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentEdit;
using StudentAdd;

namespace School
{
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void btn_addstudent_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.Show();
            s.Size = new System.Drawing.Size(900, 650);
            s.MaximizeBox = false;
        }

        private void btn_editstudent_Click(object sender, EventArgs e)
        {
            editstudent ed = new editstudent();
            ed.Show();
            ed.Size = new System.Drawing.Size(900, 650);
            ed.MaximizeBox = false;
        }

        private void btn_deletestudent_Click(object sender, EventArgs e)
        {
            deletestudent ds = new deletestudent();
            ds.Show();
            ds.Size = new Size(500, 325);
            ds.MaximizeBox = false;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //SR.sample ssr = new SR.sample();
           // ssr.Show();
            search src = new search();
            src.Show();            
        }

        private void btn_StudentClass_Click(object sender, EventArgs e)
        {

        } 
        

      
    }
}
