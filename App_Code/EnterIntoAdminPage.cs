using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EnterIntoAdminPage
/// </summary>
public class EnterIntoAdminPage
{
    string _login;
    string _password;
	public EnterIntoAdminPage(string login, string password)
	{
        this._login = login;
        this._password = password;
	}
    public bool Autorization()
    {
        ShowUserDataContext ud = new ShowUserDataContext();
        var user = from u in ud.GetTable<Seller>()
                   where u.Login == _login &&
                   u.Password == _password
                   select u.FirstName;
        if (user.Count() == 0)
        {
            return false;
        }
        return true;
    }
}