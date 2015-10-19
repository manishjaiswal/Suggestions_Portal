<%@ Page Language="C#" AutoEventWireup="true" CodeFile="approvalpage.aspx.cs" Inherits="approvalpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Approval Page</title>
    <link href="CSS/approvalpage.css" rel="stylesheet" />
</head>
<body style="background-image: url('Images/jets.png');background-size: 100% 100%;">
     <script type="text/javascript" >
         function popup1() {
             alert("Suggestion has been approved!");
         }
         function popup2() {
             alert("Suggestion has been rejected!");
         }
    </script>
    <form id="form1" runat="server">
        <div id="heading" class="heading">
            <img src="Images/hal-logo.png" class="auto-style1" />&nbsp;&nbsp; HINDUSTAN AERONAUTICS LIMITED
        </div>
        <div class="menu" >
            <center>
                <asp:Button ID="home" runat="server" cssClass="menubutton" Text="HOME" OnClick="home_Click" ></asp:Button>
                <br />
                <asp:Button ID="mysuggestions" runat="server" cssClass="menubutton" Text="MY SUGGESTIONS" OnClick="mysuggestions_Click"></asp:Button>
                <br />
                <asp:Button ID="profile" runat="server" cssClass="menubutton" Text="PROFILE" OnClick="profile_Click"></asp:Button>    
                <br />    
                <asp:Button ID="allsuggestions" runat="server" cssClass="menubutton" Text="ALL SUGGESTIONS" OnClick="allsuggestions_Click"></asp:Button>
                <br />
                <asp:Button ID="Changepassword" runat="server" cssClass="menubutton" Text="CHANGE PASSWORD" UseSubmitBehavior="False" OnClick="changepassword_click" ></asp:Button>
                <br />    
                <asp:Button ID="ButtonLogout" runat="server" cssClass="menubutton" Text="Log Out" OnClick="ButtonLogout_Click"></asp:Button>
                <br />
                <asp:Button ID="ButtonApproval" runat="server" cssClass="menubutton" Text="Approval" OnClick="ButtonApproval_Click" Visible="False"></asp:Button>
                <asp:Button ID="ButtonAdminHistory" runat="server" cssClass="menubutton" Text="History" Visible="False" OnClick="ButtonAdminHistory_Click"></asp:Button>
            </center>
        </div>
        <div style="width: 67%; float: left;">
            <center>
                <br />
                <a class="halsug">HAL Suggestions Portal</a>
            </center>        
        </div>
        <div style="width: 15%; float: right;">
            <br />
            <asp:Label ID="welcomeuser" runat="server" class="textonimage" Text="Label"></asp:Label>
        </div>
        <div class="content" style="width: 65%;">        
            <br />
            <div>
                <div style="width: 60%; float: left;">
                    <center>
                        <a class="textonimage">Subject of Suggestion: </a><br />
                        <asp:Label ID="labelsubject" runat="server" TextMode="MultiLine" Class="suggestionsubject"/>
                    </center>
                </div>
                <div style="width: 40%; float: left;">
                    <center>
                        <a class="textonimage">Suggestor: </a><br />
                        <asp:Label ID="labelsuggestor" runat="server" TextMode="MultiLine" Class="suggestionsubject"/><br /><br />
                    </center>
                </div>
            </div>
            <center>
            <div>
                    <center>
                        <div style="width: 60%;">
                            <center>
                            <a class="textonimage">Suggestion: </a><br />
                                </center>
                        </div>
                        <div>                     
                            <asp:TextBox ID="labelsuggestion" class="suggestionbox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                            
                        </div>
                    </center>
                </div>
                <div>
                    <br />
                    <asp:Label ID="likes" runat="server" class="textonimage" Text="Likes" Visible="true"></asp:Label><br />
                    <asp:Label ID="labelnumlikes" runat="server" class="suggestorbox" Text="Status"></asp:Label>
                </div>
                <center />
            <center>
                <br />
                <a class="textonimage">Admin note: </a><br />
                <asp:Textbox ID="Textboxadminnote" runat="server" TextMode="MultiLine" Class="adminnote"/>
                <br /><br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Buttonapprove" runat="server" Text="Approve" OnClick="Buttonapprove_Click" OnClientClick="popup1()"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Buttonreject" runat="server" Text="Reject" OnClick="Buttonreject_Click" OnClientClick="popup2()"></asp:Button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br /> <br />
            <asp:Label ID="admin1" runat="server" class="textonimage" Text="admin1note" Visible="False"></asp:Label> <br />
            <asp:Label ID="admin1note" runat="server" Text="Label" Visible="False"></asp:Label> <br /> <br />
            <asp:Label ID="admin2" runat="server" CssClass="textonimage" Text="admin2note" Visible="False"></asp:Label> <br />
            <asp:Label ID="admin2note" runat="server" Text="Label" Visible="False"></asp:Label>
            </center>
                <br />
        </div>
    </form>
</body>
</html>
