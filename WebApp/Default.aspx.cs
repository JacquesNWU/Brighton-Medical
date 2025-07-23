//35317906 - Jacques van Heerden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace vanHeerden_35317906_June_Exam_Web_App
{
    public partial class Default : System.Web.UI.Page
    {
        public SqlConnection conn;
        public SqlCommand command;
        public DataSet dataset;
        public SqlDataAdapter adapter;
        public SqlDataReader reader;
        public string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CMPG212\vanHeerden_35317906_June_Exam\vanHeerden_35317906_June_Exam_Web_App\App_Data\PatientDB.mdf;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
 
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            createCookie();       
        }

        public void createCookie() {
            

            conn = new SqlConnection(constr);
            try
            {
                conn.Open();

                command = new SqlCommand(@"SELECT * FROM PatTable WHERE Username LIKE @Username AND Password LIKE @Password",conn);
                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    HttpCookie _userInfo = new HttpCookie("UserInfo");
                    _userInfo["Name"] = reader.GetValue(1).ToString();
                    _userInfo["Surname"] = reader.GetValue(2).ToString();
                    _userInfo["Number"] = reader.GetValue(3).ToString();
                    _userInfo["Email"] = reader.GetValue(4).ToString();
                    _userInfo["Allergies"] = reader.GetValue(5).ToString();
                    _userInfo["EmergContact"] = reader.GetValue(6).ToString();
                    _userInfo["Username"] = reader.GetValue(8).ToString();
                    _userInfo["Password"] = reader.GetValue(7).ToString();
                    Response.Cookies.Add(_userInfo);
                    _userInfo.Expires = DateTime.Now.AddDays(2);
                    Response.Redirect("Dashboard.aspx");
                }
                else {
                    lblOut.Text = "Username and Password does not match, try Jacvan for Username and Password for Password";
                }
                
                conn.Close();
            }
            catch (SqlException error) {
                lblOut.Text = error.Message;
            }
        }
    }
}