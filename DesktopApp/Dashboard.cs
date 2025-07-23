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
    public partial class Dashboard : Form
    {
        //Register Patient Variables
        public string dName;
        public string dSurname;
        public string dEmail;
        public string dNumber;

        //Create New Appointment Variables
        public string cName;
        public string cAptType;
        public string cDateTime;

        //Invoice/Complete Var
        public string iID;

        string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CMPG212\vanHeerden_35317906_June_Exam\vanHeerden_35317906_June_Exam_Desktop_App\PatientDB.mdf;Integrated Security = True";
        SqlCommand command;
        SqlConnection conn;
        //SqlDataAdapter adapter;
        SqlDataReader reader;
        //DataSet dataset;
        DateTime selectedDate;
        public Dashboard()
        {
            InitializeComponent();
        }

        public void today()
        {
            monthCalendar1.SelectionStart = DateTime.Today;

        }

        private void viewAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_Appointments editApt = new Edit_Appointments(this);
            editApt.ShowDialog();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            listBox1.Items.Clear();
            conn = new SqlConnection(constring);


            DateTime getTime;
            string TimeS;
            string DateS;


            try
            {
                conn.Open();

                //listBox1.Items.Add(selectedDate.ToShortDateString());
                selectedDate = monthCalendar1.SelectionStart;
                command = new SqlCommand("SELECT * FROM AptTable WHERE CAST(AptDateTime as Date)=@Date", conn);
                command.Parameters.AddWithValue("@Date", selectedDate);
                reader = command.ExecuteReader();

                listBox1.Items.Clear();
                listBox1.Items.Add("==============================================================================================================");
                listBox1.Items.Add("APT ID\tApt Type\t\t\t\tApt Patient\t\tApt Date and Time\t\tApt Status");
                listBox1.Items.Add("==============================================================================================================");
                while (reader.Read())
                {
                    getTime = (DateTime)reader["AptDateTime"];
                    DateS = getTime.ToShortDateString();
                    TimeS = getTime.ToShortTimeString();

                    if (reader["AptType"].ToString().Length > 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t\t" + TimeS + " " + DateS + "\t\t" + reader.GetValue(4));
                    }
                    else if (reader["AptType"].ToString().Length > 18 && reader["AptType"].ToString().Length <= 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t" + reader.GetValue(2) + "\t\t" + TimeS + " " + DateS + "\t\t" + reader.GetValue(4));
                    }
                    else
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t\t" + reader.GetValue(2) + "\t\t" + TimeS + " " + DateS + "\t\t" + reader.GetValue(4));
                    }

                    
                }

                command.Dispose();
                conn.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            today();
        }

        private void createAppointmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Create_Appointment createApt = new Create_Appointment(this);
            createApt.ShowDialog();
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration register = new Registration(this);
            register.ShowDialog();
        }


        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Invoicing invoice = new Invoicing(this);
            invoice.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Click on any date to view the appointments scheduled/cancelled for that day");
            //button2.Enabled = false;
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);
            string sqlQuery = "INSERT INTO PatTable (PatName, PatSurname, PatEmail, PatNumber) VALUES (@Name, @Surname, @Email, @Number)";
            try
            {
                conn.Open();
                using (command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@Name", dName);
                    command.Parameters.AddWithValue("@Surname", dSurname);
                    command.Parameters.AddWithValue("@Email", dEmail);
                    command.Parameters.AddWithValue("@Number", dNumber);
                }
                command.ExecuteNonQuery();
                //MessageBox.Show("Changes Saved");
                conn.Close();
                Create_Appointment create = new Create_Appointment();
                create.clear();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            button2.Hide();
            //button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cAptType + " , " + cName + " , " + cDateTime);
            conn = new SqlConnection(constring);
            string sqlQuery = "INSERT INTO AptTable (AptType, AptPatient, AptDateTime, AptStatus) VALUES (@Type, @Patient, @DateTime, @Status)";
            try
            {
                conn.Open();
                using (command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@Type", cAptType);
                    command.Parameters.AddWithValue("@Patient", cName);
                    command.Parameters.AddWithValue("@DateTime", cDateTime);
                    command.Parameters.AddWithValue("@Status", "Scheduled");
                }
                command.ExecuteNonQuery();
                MessageBox.Show("Changes Saved");
                conn.Close();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            button3.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = "";
            string type;
            //MessageBox.Show(iID);
            conn = new SqlConnection(constring);
            string sqlQuery = "UPDATE AptTable SET AptStatus = 'Completed' WHERE AptID = @ID";
            try
            {
                conn.Open();
                using (command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@ID", iID);
                }
                command.ExecuteNonQuery();
                conn.Close();

                sqlQuery = "SELECT AptType, AptPatient FROM AptTable WHERE AptID = @ID";
                SqlDataReader reader;

                decimal cost = 0.0M;
                conn.Open();
                using (command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@ID", iID);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        name = reader["AptPatient"].ToString();
                        type = reader["AptType"].ToString();

                        switch (type)
                        {
                            case "Laboratory / medical result analysis":
                                cost = 360.0M;
                                break;
                            case "Surgical appointment":
                                cost = 1500.0M;
                                break;
                            case "Routine Check-up":
                                cost = 500.0M;
                                break;
                            case "Urgent Medical Check-up":
                                cost = 2000.0M;
                                break;
                        }
                    }
                }
                conn.Close();

                MessageBox.Show("Invoiced successfully sent to: " + name + ".\nPayment Due: " + cost.ToString("C"));
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message);
            }
            button4.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(constring);

            string query = "UPDATE AptTable SET AptType = @type, AptPatient = @patient, AptDateTime = @datetime WHERE AptID = @ID";
            //MessageBox.Show(iID);
            try
            {

                conn.Open();
                using (command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@type", cAptType);
                    command.Parameters.AddWithValue("@patient", cName);
                    command.Parameters.AddWithValue("@datetime", cDateTime);
                    command.Parameters.AddWithValue("@ID", iID);
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            button5.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(iID);
            conn = new SqlConnection(constring);
            string sqlQuery = "UPDATE AptTable SET AptStatus = 'Cancelled' WHERE AptID = @ID";
            try
            {
                conn.Open();
                using (command = new SqlCommand(sqlQuery, conn))
                {
                    command.Parameters.AddWithValue("@ID", iID);
                }
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            button6.Hide();
        }

        

        private void button7_Click(object sender, EventArgs e){
            listBox1.Items.Clear();
            string query = @"SELECT * FROM AptTable WHERE AptStatus='Completed'";
            conn = new SqlConnection(constring);

            listBox1.Items.Add("==============================================================================================================");
            listBox1.Items.Add("APT ID\tApt Type\t\t\t\tApt Patient\t\tApt Date and Time\t\tApt Status");
            listBox1.Items.Add("==============================================================================================================");

            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["AptType"].ToString().Length > 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                    else if (reader["AptType"].ToString().Length > 19 && reader["AptType"].ToString().Length <= 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                    else
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string query = @"SELECT * FROM AptTable WHERE AptStatus='Cancelled'";
            conn = new SqlConnection(constring);

            listBox1.Items.Add("==============================================================================================================");
            listBox1.Items.Add("APT ID\tApt Type\t\t\t\tApt Patient\t\tApt Date and Time\t\tApt Status");
            listBox1.Items.Add("==============================================================================================================");

            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["AptType"].ToString().Length > 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                    else if (reader["AptType"].ToString().Length > 18 && reader["AptType"].ToString().Length <= 30)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                    else
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + "\t\t\t" + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string query = @"SELECT * FROM PatTable";
            conn = new SqlConnection(constring);

            listBox1.Items.Add("=========================================================================================");
            listBox1.Items.Add("ID\tName and Surname\t\tEmail\t\t\t\tNumber");
            listBox1.Items.Add("=========================================================================================");

            try
            {
                conn.Open();
                command = new SqlCommand(query, conn);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["PatEmail"].ToString().Length > 24)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + " " + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t" + reader.GetValue(4));
                    }
                    else if (reader["PatEmail"].ToString().Length >=18 && reader["PatEmail"].ToString().Length <= 24)
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + " " + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t" + reader.GetValue(4));
                    }
                    else
                    {
                        listBox1.Items.Add(reader.GetValue(0) + "\t" + reader.GetValue(1) + " " + reader.GetValue(2) + "\t\t" + reader.GetValue(3) + "\t\t\t" + reader.GetValue(4));
                    }
                }
                conn.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}

