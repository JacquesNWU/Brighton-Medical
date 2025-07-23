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
    public partial class Form1 : Form
    {
        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\EmployeeDB.mdf;Integrated Security=True";
        public SqlConnection conn;
        public SqlCommand command;
        public DataSet dataset;
        public SqlDataAdapter adapter;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            RequiredField();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearControls();
            textBox1.Text = "Admin";
            textBox2.Text = "Password";
        }

        private void RequiredField() {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                RequiredErr.SetError(textBox1, "Required Username");
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                RequiredErr.SetError(textBox2, "Required Password");
            }
            else 
            {
                String Username = textBox1.Text;
                String Password = textBox2.Text;
                if (Auth(Username, Password, connectionString))
                {
                    Dashboard d1 = new Dashboard();
                    d1.Show();
                    this.Hide();
                    d1.FormClosed += (s, args) => this.Close();
                }
                else
                    MessageBox.Show("Invalid username or password. Try using Admin for username and Password for Password");
                    clearControls();
                
            }

        }

        private bool Auth(string Username, string Password, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM EmpTable WHERE EmpUsername = @Username AND EmpPassword = @Password";
                command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);

                //-----------------------------------------------
                //  EXCEPTION HANDLING FOR USERNAME AND PASSWORD
                //-----------------------------------------------

                try
                {
                    conn.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wrong Username or Password, Please try again" + ex.Message);
                    return false;
                }
            }
        }

        private void clearControls() {
            textBox1.Text = "";
            textBox2.Text = "";
            RequiredErr.SetError(textBox1,"");
            RequiredErr.SetError(textBox2,"");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Try admin for username and password for password");
        }
    }
}
