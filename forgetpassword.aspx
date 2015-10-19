<%@ Page Language="C#" AutoEventWireup="true" CodeFile="forgetpassword.aspx.cs" Inherits="forgetpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Forget Password</title>
    <link href="CSS/forgetpassword.css" rel="stylesheet" />
</head>
<body style="background-image: url('Images/jets.png'); background-size: 100% 100%;">
    <form id="form1" runat="server">
        <div id="heading" class="heading">
            <img src="Images/hal-logo.png" class="auto-style1" />&nbsp;&nbsp; HINDUSTAN AERONAUTICS LIMITED
        </div>
        <div>
            <center>
                <br /><br />
                <a align="center" class="halsug">HAL Suggestions Portal</a>            
            </center>
        </div>
        <br />
        <div>
            <center>
                <div style="width: 60%;background-color:rgb(255, 255, 255);">
                    <br /><br />
                    <a class="textonimage">Forgot your Password!!</a>
                    <br /><br />
                    <a class="textonimage">To Retrieve your password enter answer to your security question</a>
                    <br />
                    <br />
                    <a style="font-size: 15px;color: #0033CC; font-weight: 700">Enter your username :</a>
                    <asp:TextBox ID="Textusername" class="boxemail" required="required" runat="server"></asp:TextBox>
                    <asp:Label ID="Labelincorrectname" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
                    <br />
                    <br />
                    <asp:Button ID="Buttonsubmit1" runat="server" Text="Submit" OnClick="Buttonsubmit1_Click"></asp:Button><br />
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Security Question : " style="font-size: 15px;color: #0033CC; font-weight: 700" Visible="False"></asp:Label>
                    <asp:Label ID="Labelquestion" runat="server" Text="Label" Visible="False"></asp:Label>
                    <br /><br />
                    <asp:Label ID="Label2" runat="server" Text="Answer : " style="font-size: 15px;color: #0033CC; font-weight: 700" Visible="False"></asp:Label>
                    <asp:TextBox ID="Textanswer" class="boxemail" required="required" runat="server" Visible="False"></asp:TextBox>
                    <br />
                    <br />
                    <asp:Button ID="Buttonsubmit2" runat="server" Text="Submit" OnClick="Buttonsubmit2_Click" Visible="False"  />
                    <br />
                     <br />
                      <asp:Label ID="Labelpasswordtext" runat="server" Text="Your Password is:" style="font-size: 15px;color: #0033CC; font-weight: 700" Visible="False"></asp:Label>
                     <br />
                      <asp:Label ID="Labelpassword" runat="server" Text="Label" Font-Bold="True" ForeColor="Red" Visible="False"></asp:Label>
                     <br /><br />
                      <asp:Button ID="Buttonredirect" runat="server" Text="Click to Login" OnClick="Buttonredirect_Click" Visible="False" Width="100px"></asp:Button>
                     </center>
            </div>
        </div>
    </form>
</body>
</html>
