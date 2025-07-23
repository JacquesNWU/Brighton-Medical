//35317906 - Jacques van Heerden
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace vanHeerden_35317906_June_Exam_Desktop_App
{

    public partial class Registration : Form
    {
        Dashboard db;
        public Registration()
        {
            InitializeComponent();
        }

        public Registration(Dashboard dashboard)
        {
            InitializeComponent();
            db = dashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (!String.IsNullOrEmpty(textBox4.Text))
            {
                db.dName = textBox1.Text;
                db.dSurname = textBox2.Text;
                db.dEmail = textBox3.Text;
                db.dNumber = textBox4.Text;
                db.button2.Show();
                
                this.Close();
                MessageBox.Show("Please save the changes");
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }
    }
}