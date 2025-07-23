//35317906 - Jacques van Heerden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vanHeerden_35317906_June_Exam_Web_App
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie _userInfo = Request.Cookies["UserInfo"];
            if (_userInfo != null) {
                lblWelcome.Text = "Welcome to your dashboard "+_userInfo["Name"]+" "+ _userInfo["Surname"]+", the details in this message was retrieved from a Cookie";
            }
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookAppointment.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateInformation.aspx");
        }
    }
}