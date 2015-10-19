<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="userpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Homepage</title>
    <link href="CSS/home.css" rel="stylesheet" />
</head>
<body style="background-image: url('Images/jets.png');background-size: 100% 100%;">
    
    <form id="form1" runat="server">
        <div id="heading" class="heading">
            <img src="Images/hal-logo.png" class="auto-style1" />&nbsp;&nbsp; HINDUSTAN AERONAUTICS LIMITED
        </div>

        <div class="menu" >
            <center>
                <asp:Button ID="home" runat="server" cssClass="menubutton" Text="HOME" OnClick="home_Click" UseSubmitBehavior="False" ></asp:Button>
                <br />
                <asp:Button ID="mysuggestions" runat="server" cssClass="menubutton" Text="MY SUGGESTIONS" OnClick="mysuggestions_Click" UseSubmitBehavior="False"></asp:Button>
                <br />
                <asp:Button ID="profile" runat="server" cssClass="menubutton" Text="PROFILE" OnClick="profile_Click" UseSubmitBehavior="False"></asp:Button>    
                <br />    
                <asp:Button ID="allsuggestions" runat="server" cssClass="menubutton" Text="ALL SUGGESTIONS" OnClick="allsuggestions_Click" UseSubmitBehavior="False"></asp:Button>
                <br />
                <asp:Button ID="Changepassword" runat="server" cssClass="menubutton" Text="CHANGE PASSWORD" UseSubmitBehavior="False" OnClick="changepassword_click" ></asp:Button>
                <br />    
                <asp:Button ID="ButtonLogout" runat="server" cssClass="menubutton" Text="Log Out" OnClick="ButtonLogout_Click" UseSubmitBehavior="False"></asp:Button>
                <br />
                <asp:Button ID="ButtonApproval" runat="server" cssClass="menubutton" Text="Approval" OnClick="ButtonApproval_Click" Visible="False" UseSubmitBehavior="False"></asp:Button>
                <asp:Button ID="ButtonAdminHistory" runat="server" cssClass="menubutton" Text="History" Visible="False" OnClick="ButtonAdminHistory_Click" UseSubmitBehavior="False"></asp:Button>

            </center>
        </div>
        <div class="content" style="width: 67%; float: left;">
            <h1 align="center">Welcome to HAL Suggestions Portal</h1>            
        </div>
        <div style="width: 15%; float: right;">
            <br />
            <asp:Label ID="welcomeuser" runat="server" class="coloured" Text="Label"></asp:Label>
        </div>
        <div class="content">
            <center>
                <br /><a class="textonimage">Choose Department: 
                <asp:DropDownList ID="DropDowndept" runat="server">
                    <asp:ListItem>HR Department</asp:ListItem>
                    <asp:ListItem>Sheet-Metal Department</asp:ListItem>
                    <asp:ListItem>IT Department</asp:ListItem>
                    <asp:ListItem>Welding Department</asp:ListItem>
                </asp:DropDownList>
                </a>
                &nbsp;<br /><br />
                <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="dataclassDataContext" EntityTypeName="" TableName="Tables">
                </asp:LinqDataSource>
                <br />
                <a class="textonimage">Subject of Suggestion: </a><br />
                 <asp:TextBox ID="TextBoxSubject" runat="server" required="required" TextMode="MultiLine" cssClass="suggestionsubject"/>
                <br />
                <asp:Label ID="Labelerror" runat="server" ForeColor="Red" Text="Subject should be less than 50 words" Visible="False"></asp:Label>
                <br /><br />
                <a class="textonimage">Give your Suggestion here: </a><br />
                    <asp:TextBox ID="TextBoxSuggestion" runat="server" required="required" TextMode="MultiLine" Class="suggestionbox"/>
                    <br />
                    <asp:Button ID="ButtonSubmit" runat="server" style="width: 100px;" Text="Submit" OnClick="ButtonSubmit_Click"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Buttonreset" runat="server" Text="Reset" style="width: 100px;" OnClick="Buttonreset_Click" />
            </center>
        </div>
    </form>
</body>
</html>
