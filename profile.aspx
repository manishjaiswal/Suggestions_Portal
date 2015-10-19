<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Homepage</title>
    <link href="CSS/profile.css" rel="stylesheet" />
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
                <asp:Button ID="userprofile" runat="server" cssClass="menubutton" Text="PROFILE" OnClick="profile_Click" UseSubmitBehavior="False"></asp:Button>    
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
        <div style="width: 67%; float: left">
            <center>
                <br />
                <a class="halsug">Profile</a>            
            </center>
        </div>
        <div style="width: 15%; float: right;">
            <br />
            <asp:Label ID="welcomeuser" runat="server" class="coloured" Text="Label"></asp:Label>
        </div>
        <div class="content">
            <div style="width: 90%; float: right;">
                <br /><br />
                <a class="textonimage">Name: </a>&nbsp;
                <asp:Label ID="labelname" runat="server" class="suggestorbox" TextMode="MultiLine" Text="label"></asp:Label>
                <br /><br />
                <a class="textonimage">Email Id: </a>&nbsp;
                <asp:Label ID="labelemailid" runat="server" class="suggestorbox" TextMode="MultiLine" Text="label"></asp:Label>
                <br /><br />
                <a class="textonimage">Username: </a>&nbsp;
                <asp:Label ID="labelusername" runat="server" class="suggestorbox" TextMode="MultiLine" Text="label"></asp:Label>
                <br /><br />
                <a class="textonimage">Address: </a>&nbsp;
                <asp:Label ID="labeladdress" runat="server" class="suggestorbox" TextMode="MultiLine" Text="label"></asp:Label>
                <br /><br />
                <a class="textonimage">Contact Numaber: </a>&nbsp;
                <asp:Label ID="labelnumber" runat="server" class="suggestorbox" TextMode="MultiLine" Text="label"></asp:Label>
                <br /><br /><br />
            </div>
        </div>
    </form>
</body>
</html>
