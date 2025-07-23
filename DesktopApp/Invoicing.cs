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
    public partial class Invoicing : Form
    {
        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CMPG212\vanHeerden_35317906_June_Exam\vanHeerden_35317906_June_Exam_Desktop_App\PatientDB.mdf;Integrated Security = True";
        SqlCommand command;
        SqlConnection conn;
        //SqlDataAdapter adapter;
        SqlDataReader reader;
        Dashboard db;
        private string selectedIndex;
        public Invoicing()
        {
            InitializeComponent();
        }

        public Invoicing(Dashboard dashboard)
        {
            InitializeComponent();
            db = dashboard;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                db.iID = selectedIndex;
                db.button4.Show();
                this.Close();
            }
        }    
        
        private void Invoicing_Load(object sender, EventArgs e)
        {
            clear();
        }

        public void clear() {
            listBox1.Items.Clear();
            listBox1.Items.Add("Apt ID\tApt Type\t\t\t\tPatient\t\t\tStatus");
            try
            {
                conn = new SqlConnection(constring);
                conn.Open();
                command = new SqlCommand("SELECT AptID, AptType, AptPatient, AptStatus FROM AptTable ", conn);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (reader["AptType"].ToString().Length > 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3));
                    }
                    else if (reader["AptType"].ToString().Length > 18 && reader["AptType"].ToString().Length <= 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3));

                    }
                    else
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3));
                    }
                }
                reader.Close();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            button1.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] line = listBox1.SelectedItem.ToString().Split('\t');
            selectedIndex = line[0];
            button1.Show();
        }
    }
}
