<%@ Page Language="C#" AutoEventWireup="true" CodeFile="mysugdetail.aspx.cs" Inherits="mysugdetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>View Suggestion</title>
    <link href="CSS/mysugdetail.css" rel="stylesheet" />
</head>
<body style="background-image: url('Images/jets.png'); background-size: 100% 100%;">
    <form id="form1" runat="server">
        <div id="heading" class="heading">
            <img src="Images/hal-logo.png" class="auto-style1" />&nbsp;&nbsp; HINDUSTAN AERONAUTICS LIMITED
        </div>
        <div class="menu">
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
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="dataclassDataContext" EntityTypeName="" TableName="Tables">
        </asp:LinqDataSource>
        <div style="width: 67%; float: left;">
            <center>
                <br />
                <a align="center" class="halsug">HAL Suggestions Portal</a>            
            </center>
        </div>
        <div style="width: 15%; float: right;">
            <br />
            <asp:Label ID="welcomeuser" runat="server" class="textonimage" Text="Label"></asp:Label>
        </div>
        <div class="content">
            <br />
            <div>
                <div style="width: 60%; float: left;">
                    <center>
                        <a class="textonimage">Subject of Suggestion: </a><br />
                        <asp:Label ID="labelsubject" runat="server" class="suggestorbox" TextMode="MultiLine" Text="label"></asp:Label>
                        <br /><br />
                    </center>
                </div>
                <center>
                    <div style="width: 20%; float: left;">
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<a class="textonimage">Department: </a><br />
                        <asp:Label ID="labeldepartment" runat="server" TextMode="MultiLine" class="suggestorbox" Text="label"></asp:Label>    
                        <br /><br />
                    </div>
                </center>
                <div>
                    <center>
                        <div style="width: 60%;">
                            <center>
                            <a class="textonimage">Suggestion: </a><br />
                                </center>
                        </div>
                        <div>                     
                            <asp:TextBox ID="labelsuggestionbox" class="suggestionbox" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
                            <br /><br />
                        </div>
                    </center>
                </div>
                <div style="width: 50%; float: left;">
                    <center>
                        <asp:Label ID="admin1" runat="server" class="textonimage" Text="Admin1note" Visible="true"></asp:Label> <br />
                        <asp:Label ID="admin1note" runat="server" class="suggestorbox" Text="Label" Visible="true"></asp:Label>
                    </center>
                </div>
                <div style="width: 40%; float: left;">
                    <center>
                        <asp:Label ID="admin2" runat="server" class="textonimage" Text="Admin2note" Visible="true"></asp:Label> <br />
                        <asp:Label ID="admin2note" runat="server" class="suggestorbox" Text="Labe2" Visible="true"></asp:Label>
                    </center>
                </div>
            </div>
            <br />
            <br />
            <div style="width: 100%;">
                <center>
                    <div style="width: 40%;">
                        <asp:Label ID="admin3" runat="server" class="textonimage" Text="Admin3note" Visible="true"></asp:Label> <br />
                        <asp:Label ID="admin3note" runat="server" class="suggestorbox" Text="Labe3" Visible="true"></asp:Label><br /><br />
                    </div>
                    <div style="width: 60%;">
                        <div style="width: 50%; float: left;">    
                            <asp:Label ID="status" runat="server" class="textonimage" Text="Status" Visible="true"></asp:Label><br />
                            <asp:Label ID="labelstatus" runat="server" class="suggestorbox" Text="Status"></asp:Label>
                        </div>
                        <div style="width: 50%; float: right;">
                            <asp:Label ID="likes" runat="server" class="textonimage" Text="Likes" Visible="true"></asp:Label><br />
                            <asp:Label ID="labelnumlikes" runat="server" class="suggestorbox" Text="Status"></asp:Label>
                        </div>
                    </div>
                </center>
                <br />
            </div>
            <br /><br />
        </div>
    </form>
</body>
</html>
