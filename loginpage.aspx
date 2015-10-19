<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginpage.aspx.cs" Inherits="loginpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HAL-Suggestions</title>
    <link href="CSS/loginpage.css" rel="stylesheet" />
</head>
<body style="background-image: url('Images/jets.png');background-size: 100% 100%;">
    <form id="form1" runat="server">
        <div id="heading" class="heading">
            <img src="Images/hal-logo.png" class="auto-style1" />&nbsp;&nbsp; HINDUSTAN AERONAUTICS LIMITED
        </div>
        <br />
        <h1 align="center"><a class="textonimage" style="font-size:45px"> HAL Suggestions Portal</a></h1>
        <br />
        <center>
            <div class="content">
                <br /><br />
                <span class="textonimage">Login below :</span><br /><br />
                <div id="inputs">
                    <a class="textonimage">Username:</a>
                    <asp:TextBox ID="TextUsername" class="box" required="required" runat="server"></asp:TextBox> 
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="Username is incorrect." Visible="False"></asp:Label>
                    <br />
                    <a class="textonimage">Password:</a>&nbsp;
                    <asp:TextBox ID="TextPassword"  type="password" class="box" required="required" runat="server"></asp:TextBox>
                    <br />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label2" runat="server" ForeColor="Red" Text="Password is incorrect." Visible="False"></asp:Label>
                    <h2 style="font-size: 10px"></h2>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <a href="forgetpassword.aspx" style="text-decoration: none"><font class="textonimage1">Forgot Password? click Here</font></a>
                    <br />
                    <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="dataclassDataContext" EntityTypeName="" OrderBy="username" TableName="logins">
                    </asp:LinqDataSource>
                    <br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" width="100px" OnClick="ButtonSubmit_Click"/>&nbsp;
                    <asp:Button ID="ButtonReset" runat="server" Text="Reset" width="100px" OnClick="ButtonReset_Click" />
                    <br />
                </div>
                <br />
                <h3 style="font-size: 10px"></h3>
                <a class="textonimage1">New Users are requested to Signup </a>
                <a href="register.aspx" style="text-decoration: none"><font class="here">HERE</font></a>
                <br /><br /><br /> 
            </div>   
        <center/>
    </form>
</body>
</html>

