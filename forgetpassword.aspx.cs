using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class forgetpassword : System.Web.UI.Page
{
    public static string uname,answer,password;
    
    protected void Page_Load(object sender, EventArgs e)
    {
         
    }

    protected void Buttonsubmit1_Click(object sender, EventArgs e)
    {
        uname = Textusername.Text;
        using (dataclassDataContext Data = new dataclassDataContext())
            {
                if (uname != null)
                {
                    login check = Data.logins.SingleOrDefault(l => l.uid == uname);
                    if (check != null)
                    {
                        Labelincorrectname.Visible = false;
                        Labelquestion.Text = check.security_question;
                        answer = check.security_answer;
                        password = check.password;
                        Labelquestion.Visible = true;
                        Label1.Visible = true;
                        Label2.Visible = true;
                        Textanswer.Visible = true;
                        Buttonsubmit2.Visible = true;
                        Buttonsubmit1.Visible = false;
                    }
                    else {
                        Labelincorrectname.Text = "Username is incorrect";
                        Labelincorrectname.Visible = true;
                    }
                }
                else {
                    Response.Redirect("forgetpassword.aspx");

                }
                    
        }

    }
    protected void Buttonsubmit2_Click(object sender, EventArgs e)
    {

        if (Textanswer.Text == answer)
        {
            Labelpasswordtext.Text = "Your Password is:";
            Labelpassword.Visible = true;
            Labelpassword.Text = password;
            Labelpasswordtext.Visible = true;
            Buttonredirect.Visible = true;
        }
        else
        {
            Labelpassword.Visible = false;
            Labelpasswordtext.Text = "Your security answer is incorrect";
            Labelpasswordtext.Visible = true;
            Buttonredirect.Visible = false;
        }
    }
    protected void Buttonredirect_Click(object sender, EventArgs e)
    {
        Response.Redirect("loginpage.aspx");
    }
}