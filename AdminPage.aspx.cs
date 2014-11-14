using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //ShowUserDataContext ud = new ShowUserDataContext();
        //var mobilePhone = from mp in ud.GetTable<MobilePhone>()
        //                  select mp.Name;
        //MobilePhonesDropDown.DataSource = mobilePhone;
        //MobilePhonesDropDown.DataBind();
        if (Response.Cookies["adminUser"] == null)
        {
            Response.Redirect("~/Main.aspx");
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}