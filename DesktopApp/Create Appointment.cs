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
    
    public partial class Create_Appointment : Form
    {
        Dashboard db;
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CMPG212\vanHeerden_35317906_June_Exam\vanHeerden_35317906_June_Exam_Desktop_App\PatientDB.mdf;Integrated Security = True";
        SqlCommand command;
        SqlConnection conn;
        SqlDataReader reader;
        public Create_Appointment()
        {
            InitializeComponent();
        }

        public Create_Appointment(Dashboard dashboard)
        {
            InitializeComponent();
            db = dashboard;
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboBox2.Text))
            {
                try
                {
                    conn = new SqlConnection(constring);
                    conn.Open();

                    db.cName = comboBox1.Text;
                    db.cAptType = comboBox2.Text;
                    db.cDateTime = monthCalendar1.SelectionStart.ToShortDateString() + " " + comboBox3.Text;

                    conn.Close();
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }

                db.button3.Show();
                this.Close();
            }
        }

        private void Create_Appointment_Load(object sender, EventArgs e)
        {
            clear();
            populate();
            //conn = new SqlConnection(constring);
            //conn.Open();
            //command = new SqlCommand("",conn);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            clear();
            populate();
        }

        public void clear() {
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            monthCalendar1.SelectionStart = DateTime.Today;
        }

        public void populate() {
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                string query = "SELECT PatName, PatSurname FROM PatTable";
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    comboBox1.Items.Add(reader.GetValue(0) + " " + reader.GetValue(1));
                }

                reader.Close();
                //MessageBox.Show("Populated");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
