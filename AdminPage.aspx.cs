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

        ShowUserDataContext ud = new ShowUserDataContext();
        var query = (from mob in ud.MobilePhones
                     join mo in ud.PhoneModels on mob.Id equals mo.Name_Id
                     select new
                     {
                         Id = mo.Id,
                         MobileName = mob.Name
                     }
    ).ToList();
        GridView1.DataSource = query;
        GridView1.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}