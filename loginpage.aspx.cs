using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class loginpage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
               

    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string uname = TextUsername.Text;
        string pwd = TextPassword.Text;
        using (dataclassDataContext Data = new dataclassDataContext())
        {
            login MyLogin = Data.logins.SingleOrDefault(login => login.uid == uname);
            if (MyLogin != null)
            {
                string tablepass = MyLogin.password;
                int i = 0, flag = 1;
                i = pwd.Length;
                while (i < tablepass.Length)
                {
                    pwd = pwd + " ";
                    i++;
                }


                if (pwd == tablepass)
                {
                    LoginClass.CheckLogin = uname;
                    LoginClass.UserType = MyLogin.account_type;
                    LoginClass.name = MyLogin.username;
                    Response.Redirect("home.aspx");
                }
                else
                {
                    Label1.Visible = false;
                    Label2.Visible = true;
                }
            }
            else 
            {
                Label1.Visible = true;
                Label2.Visible = false;
            }

        }
    }
    protected void ButtonReset_Click(object sender, EventArgs e)
    {
        TextUsername.Text = null;
        TextPassword.Text = null;
        Label1.Visible = false;
        Label2.Visible = false;
    }
}