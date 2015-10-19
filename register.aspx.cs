using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class register : System.Web.UI.Page
{
    public string uname;
    protected void Page_Load(object sender, EventArgs e)
    {
        string checkuname = Textusername.Text;
        using (dataclassDataContext Data = new dataclassDataContext())
        {
            login check = Data.logins.SingleOrDefault(l => l.uid == checkuname);
            if (check != null)
            {
                uname = null;
                Label1.Visible = true;
            }
            else 
            {
                uname = "check";
                Label1.Visible = false;
            }
        }
            
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        if (uname != null)
        {
            using (dataclassDataContext Data = new dataclassDataContext())
            {
                login newrow = new login();
                string userid = Textusername.Text;
                newrow.uid = userid;
                newrow.username = Textname.Text;
                newrow.password = Textpassword.Text;
                newrow.security_question = TextBoxsecurityquestion.Text;
                newrow.security_answer = TextBoxsecurityanswer.Text;
                newrow.address = TextBoxaddress.Text;
                newrow.contact_no = TextBoxnumber.Text;
                newrow.email_id = Textemail.Text;
                Data.logins.InsertOnSubmit(newrow);
                Data.SubmitChanges();

                LoginClass.CheckLogin = userid;
                LoginClass.UserType = 0;
                LoginClass.name = Textname.Text;
                Response.Redirect("home.aspx");
            }
        }
        else
            Label1.Visible = true;
    }

    protected void ButtonReset_Click(object sender, EventArgs e)
    {
        Textname.Text = null;
        Textemail.Text = null;
        Textusername.Text = null;
        Textpassword.Text = null;
        Textconfirmpassword.Text = null;
        TextBoxsecurityquestion.Text = null;
        TextBoxsecurityanswer.Text = null;
        TextBoxaddress.Text = null;
        TextBoxnumber.Text = null;
        Label1.Visible = false;
    }
}