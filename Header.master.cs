using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Header : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Enter_Click(object sender, EventArgs e)
    {
        EnterIntoAdminPage Entrance = new EnterIntoAdminPage(EnterLogin.Text, EnterPassword.Text);
        if (Entrance.Autorization())
        {
            HttpCookie adminAuth = new HttpCookie("adminUser", EnterLogin.Text);
            
            Response.Redirect("~/AdminPage.aspx");
        }
        
        {
            error.Visible = true;
        }
    }
   
}
