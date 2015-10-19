using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CSS_viewsuggestion : System.Web.UI.Page
{
    int flag = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (LoginClass.CheckLogin == null)
        {
            Response.Redirect("loginpage.aspx");
        }
        if (Page.Request.QueryString["text"] != null)
        {
            int sugid = Convert.ToInt32(Page.Request.QueryString["text"]);
            using (dataclassDataContext Data = new dataclassDataContext())
            {
                Table Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
                subjectbox.Text = Mytable.subject;
                string original = Mytable.suggestion;
                suggestionbox.Text = original;
                suggestorbox.Text = Mytable.name;
                labelnumlikes.Text = Mytable.likes.ToString();
               
                string ll = Mytable.like_list;
                if (ll != null)
                {
                    char[] list = ll.ToCharArray();
                    string key = LoginClass.CheckLogin;

                    string temp = null;
                    int len = list.Length;
                    int i = 0;
                    while (i < len)
                    {
                        while (list[i] != ',')
                        {
                            temp = temp + list[i].ToString();
                            i++;
                        }
                        if (temp == key)
                        {
                            flag = 1;
                            break;
                        }
                        temp = null;
                        i++;
                    }
                    if (flag == 1)
                        buttonlike.Text = "Unlike";
                }
            }
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
    protected void buttonlike_Click(object sender, EventArgs e)
    {
        using (dataclassDataContext Data = new dataclassDataContext())
        {
            int sugid = Convert.ToInt32(Page.Request.QueryString["text"]);
            Table Mytable = new Table();
            Mytable = Data.Tables.SingleOrDefault(Table => Table.suggestionid == sugid);
            if (flag == 0)
            {
                int x = Mytable.likes;
                x += 1;
                Mytable.likes = x;
                Mytable.like_list += LoginClass.CheckLogin + ",";

            }
            else
            {
                Mytable.likes -= 1;
                int len = Mytable.like_list.Length;
                int i = 0;
                string ll = Mytable.like_list;
                char[] list = ll.ToCharArray();
                string newstring = null;
                string key = LoginClass.CheckLogin;
                string temp = null;

                while (i < len)
                {
                    while (list[i] != ',')
                    {
                        temp = temp + list[i].ToString();
                        i++;
                    }
                    if (temp != key)
                    {
                        newstring = newstring + temp + ",";
                    }
                    temp = null;
                    i++;
                }
                Mytable.like_list = newstring;
            }
            Data.SubmitChanges();
            //int sugid = Convert.ToInt32(Page.Request.QueryString["text"]);
            Page.Response.Redirect("viewsuggestion.aspx?text="+sugid);
        }
    }
}
