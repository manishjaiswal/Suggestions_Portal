using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class userpage : System.Web.UI.Page
{
    int suglen;
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

    }
    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        LoginClass.CheckLogin = null;
        LoginClass.name = null;
        Response.Redirect("loginpage.aspx");
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string check = TextBoxSubject.Text;
        if (check.Length >= 49)
        {
            Labelerror.Visible = true;
        }
        else
        {
            Labelerror.Visible = false;
           using (dataclassDataContext Data = new dataclassDataContext())
            {
                Table Mytable = new Table();
                Mytable.suggestionid = Data.Tables.Count() + 1;
                Mytable.department = DropDowndept.Text;
                Mytable.subject = TextBoxSubject.Text;
                Mytable.suggestion = TextBoxSuggestion.Text;
                suglen = TextBoxSuggestion.Text.Length;
                if (suglen <= 75)
                    Mytable.suggestion_temp = TextBoxSuggestion.Text;
                else
                {
                    Mytable.suggestion_temp = TextBoxSuggestion.Text.Substring(0, 72);
                    Mytable.suggestion_temp += ".....";
                }
                Mytable.date_time = DateTime.Now;
                Mytable.name = LoginClass.name;
                Mytable.username = LoginClass.CheckLogin;
                Data.Tables.InsertOnSubmit(Mytable);
                Data.SubmitChanges();

                string str = "<script>alert(\"Your suggestion has been successfully submitted\");</script>";
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Script", str, false);

                TextBoxSubject.Text = null;
                TextBoxSuggestion.Text = null;
                Labelerror.Visible = false;
            }
        }
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
    protected void changepassword_click(object sender, EventArgs e)
    {
        Page.Response.Redirect("changepassword.aspx");
    }
    protected void Buttonreset_Click(object sender, EventArgs e)
    {
        TextBoxSubject.Text = null;
        TextBoxSuggestion.Text = null;
        Labelerror.Visible = false;
    }
}