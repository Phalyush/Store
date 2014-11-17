using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
public partial class Header : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Enter_Click(object sender, EventArgs e)
    {
        IDictionary<string, string> paramseters = new Dictionary<string, string>();
        paramseters.Add("Login", EnterLogin.Text);
        paramseters.Add("Password", EnterPassword.Text);
        string query = "SELECT * FROM Seller where [Login]=@Login and [Password]=@Password";
        SqlHelp sh = new SqlHelp();

        if (sh.ExecuteQuery(query, paramseters).Rows.Count==0)
        {
            error.Visible = true;
        }
        else
        {
            Response.Redirect("AdminPage.aspx");
        }
    }
   
}
