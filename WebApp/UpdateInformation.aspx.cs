//35317906 - Jacques van Heerden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vanHeerden_35317906_June_Exam_Web_App
{
    public partial class UpdateInformation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                lblStatus0.Text = "";
                lblStatus.Text = "";
                
                HttpCookie _userInfo = Request.Cookies["UserInfo"];
                
                if (_userInfo != null)
                {
                    TextBox1.Text = _userInfo["Name"];
                    TextBox2.Text = _userInfo["Surname"];
                    TextBox3.Text = _userInfo["Number"];
                    TextBox4.Text = _userInfo["Email"];
                    TextBox5.Text = _userInfo["Allergies"];
                    TextBox6.Text = _userInfo["EmergContact"];

                    //Converting the value of the passwor from the Cookie into a session.
                    Session["Password"] = _userInfo["Password"];
                    TextBox7.Text = Session["Password"].ToString();
                }
                else
                {
                    TextBox7.Text = "Cookie Expired";
                }
            }
            
        }

        protected void Dashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        protected void btnUpdate0_Click(object sender, EventArgs e)
        {
            if (TextBox8.Text == TextBox9.Text && TextBox9.Text.Length > 10)
            {
                lblStatus.Text = "New password has been set";
                Session["Password"] = TextBox9.Text;
            }
            else 
            {
                TextBox8.Text = "";
                TextBox9.Text = "";
                lblStatus.Text = "Passwords does not match or meet the minimum length requirement of 10 characters";
            }
        }
    }
}