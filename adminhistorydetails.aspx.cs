using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class adminhistorydetails : System.Web.UI.Page
{

    int sugid;
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
        if (Page.Request.QueryString["text"] != null)
        {
            sugid = Convert.ToInt32(Page.Request.QueryString["text"]);

            using (dataclassDataContext Data = new dataclassDataContext())
            {
                Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
                labelsubject.Text = Mytable.subject;
                labeldepartment.Text = Mytable.department;

                labelsuggestionbox.Text = Mytable.suggestion;
                labelnumlikes.Text = Mytable.likes.ToString();

                admin1note.Text = Mytable.admin1note;
                admin2note.Text = Mytable.admin3note;
                admin3note.Text = Mytable.admin3note;

                if (Mytable.admin1note == null)
                    admin1note.Text = "NO COMMENTS";
                if (Mytable.admin2note == null)
                    admin2note.Text = "NO COMMENTS";
                if (Mytable.admin3note == null)
                    admin3note.Text = "NO COMMENTS";
                if (Mytable.status == 0)
                    labelstatus.Text = "to be approved by admin1";
                else if (Mytable.status == 1)
                    labelstatus.Text = "to be approved by admin2";
                else if (Mytable.status == 2)
                    labelstatus.Text = "to be approved by admin3";
                else if (Mytable.status == 3)
                    labelstatus.Text = "approved completely";
                else if (Mytable.status == -1)
                    labelstatus.Text = "rejected by admin 1";
                else if (Mytable.status == -2)
                    labelstatus.Text = "rejected by admin 2";
                else if (Mytable.status == -3)
                    labelstatus.Text = "rejected by admin 3";
            }
        }
        welcomeuser.Text = "Welcome " + LoginClass.name + " !";
    }

    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        LoginClass.CheckLogin = null;
        LoginClass.name = null;
        Response.Redirect("loginpage.aspx");
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