using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class changepassword : System.Web.UI.Page
{
    public string pass,uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (LoginClass.CheckLogin == null)
        {
            Response.Redirect("loginpage.aspx");
        }

        if (LoginClass.UserType != 0)
        {
            ButtonApproval.Visible = true;
            ButtonAdminHistory.Visible = true;
        }
        welcomeuser.Text = "Welcome " + LoginClass.name + " !";


        uname = LoginClass.CheckLogin;
        pass = Textpassword.Text;
        welcomeuser.Text = "Welcome " + LoginClass.name + " !";
        using (dataclassDataContext Data = new dataclassDataContext())
        {
             login Mylogin = Data.logins.SingleOrDefault(l => l.uid == uname);
                 if (pass != "")
                    {
                        int i = 0;
                        i = pass.Length;
                        while (i < Mylogin.password.Length)
                        {
                            pass = pass + " ";
                            i++;
                        }
                    }
                    if (pass != Mylogin.password)
                    {
                        if (pass != "")
                        {
                            Label2.Visible = true;
                            pass = Textpassword.Text;
                        }
                    }                   
                    else
                    {
                        Label2.Visible = false;
                    }
                }
        }
    


    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        LoginClass.CheckLogin = null;
        LoginClass.name = null;
        Response.Redirect("loginpage.aspx");
    }
   
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        using (dataclassDataContext Data = new dataclassDataContext())
        {
            login Mylogin = Data.logins.SingleOrDefault(l => l.uid == uname);
            Mylogin.password = TextBox1.Text;
            Data.SubmitChanges();

            string str = "<script>alert(\"Your Password has been successfully changed\");</script>";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", str, false);
        }
        Reset();
    }

    protected void ButtonReset_Click(object sender, EventArgs e)
    {
        Reset();
    }
    protected void Reset()
    {
        Textpassword.Text = null;
        TextBox1.Text = null;
        Textconfirmpassword.Text = null;
        Label2.Visible = false;
        
    }
    protected void ButtonApproval_Click(object sender, EventArgs e)
    {
        Session["usrtyp"] = LoginClass.UserType - 1;
        Page.Response.Redirect("approvallist.aspx");
    }

    protected void home_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("home.aspx");
    }
    protected void mysuggestions_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("mysuggestions.aspx");
    }
    protected void changepassword_click(object sender, EventArgs e)
    {
        Page.Response.Redirect("changepassword.aspx");
    }
    protected void profile_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("profile.aspx");
    }
    protected void allsuggestions_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("allsuggestions.aspx");
    }
    protected void ButtonAdminHistory_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("adminhistory.aspx");
    }
    
}