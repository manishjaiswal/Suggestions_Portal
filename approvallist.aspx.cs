using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class approvallist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (LoginClass.CheckLogin == null)
        {
            Response.Redirect("loginpage.aspx");
        }
        if (LoginClass.UserType == 0) {
            Response.Redirect("home.aspx");
        }
        else
        {
            ButtonApproval.Visible = true;
            ButtonAdminHistory.Visible = true;
        }
        int type = LoginClass.UserType - 1;
        welcomeuser.Text = "Welcome " + LoginClass.name + " !";
    }
    protected void ButtonLogout_Click(object sender, EventArgs e)
    {
        LoginClass.CheckLogin = null;
        LoginClass.name = null;
        Response.Redirect("loginpage.aspx");
    }
    protected void gv_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "Onclickb")
        {
            int RowClicked = Convert.ToInt32(e.CommandArgument);
            int PID = Convert.ToInt32(gv.DataKeys[RowClicked].Value);
            Page.Response.Redirect("approvalpage.aspx?text=" + PID);
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