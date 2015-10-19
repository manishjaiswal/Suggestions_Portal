using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class approvalpage : System.Web.UI.Page
{
    int sugid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (LoginClass.CheckLogin == null)
        {
            Response.Redirect("loginpage.aspx");
        }
        if (LoginClass.UserType == 0)
        {
            Response.Redirect("home.aspx");
        }
        if (LoginClass.UserType != 0)
        {
            ButtonApproval.Visible = true;
            ButtonAdminHistory.Visible = true;
        }
        if (Page.Request.QueryString["text"] != null)
        {
            sugid = Convert.ToInt32(Page.Request.QueryString["text"]);
            if (LoginClass.UserType == 2)
            {
                using (dataclassDataContext Data = new dataclassDataContext())
                {
                    Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
                    if (Mytable.admin1note != null)
                    {
                        admin1.Visible = true;
                        admin1note.Visible = true;
                    }
                }
            }
            if (LoginClass.UserType == 3)
            {
                using (dataclassDataContext Data = new dataclassDataContext())
                {
                    Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
                    if (Mytable.admin1note != null)
                    {
                        admin1.Visible = true;
                        admin1note.Visible = true;
                    }
                    if (Mytable.admin2note != null)
                    {
                        admin2.Visible = true;
                        admin2note.Visible = true;
                    }
                }
            }
            using (dataclassDataContext Data = new dataclassDataContext())
            {
                Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
                labelsubject.Text = Mytable.subject;
                labelsuggestion.Text = Mytable.suggestion;
                labelsuggestor.Text = Mytable.name;
                labelnumlikes.Text = Mytable.likes.ToString();
                admin1note.Text = Mytable.admin1note;
                admin2note.Text = Mytable.admin2note;
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
    protected void Buttonapprove_Click(object sender, EventArgs e)
    {
        using (dataclassDataContext Data = new dataclassDataContext())
        {
            Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
            Mytable.status = LoginClass.UserType;
            Mytable.modstatus = LoginClass.UserType;
            if (LoginClass.UserType == 1)
            {
                Mytable.admin1note = Textboxadminnote.Text;
            }
            if (LoginClass.UserType == 2)
            {
                Mytable.admin2note = Textboxadminnote.Text;
            }
            if (LoginClass.UserType == 3)
            {
                Mytable.admin3note = Textboxadminnote.Text;
            }
            Data.SubmitChanges();
            Response.Redirect("approvallist.aspx");
        }
    }
    protected void Buttonreject_Click(object sender, EventArgs e)
    {
        using (dataclassDataContext Data = new dataclassDataContext())
        {
            Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
            Mytable.status = (-1) * LoginClass.UserType;
            Mytable.modstatus = LoginClass.UserType - 1;
            if (LoginClass.UserType == 1)
            {
                Mytable.admin1note = Textboxadminnote.Text;
            }
            if (LoginClass.UserType == 2)
            {
                Mytable.admin2note = Textboxadminnote.Text;
            }
            if (LoginClass.UserType == 3)
            {
                Mytable.admin3note = Textboxadminnote.Text;
            }
            Data.SubmitChanges();
            Response.Redirect("approvallist.aspx");
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
    protected void changepassword_click(object sender, EventArgs e)
    {
        Page.Response.Redirect("changepassword.aspx");
    }
    protected void ButtonAdminHistory_Click(object sender, EventArgs e)
    {
        Page.Response.Redirect("adminhistory.aspx");
    }
}