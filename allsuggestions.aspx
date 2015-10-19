﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="allsuggestions.aspx.cs" Inherits="allsuggestions" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>All Suggestions</title>
    <link href="CSS/allsuggestions.css" rel="stylesheet" />
</head>
<body style="background-image: url('Images/jets.png'); background-size: 100% 100%; background-repeat: no-repeat;">
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
                <asp:Button ID="allsuggestion" runat="server" cssClass="menubutton" Text="ALL SUGGESTIONS" OnClick="allsuggestions_Click"></asp:Button>
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
                <a class="halsug">All Suggestions</a> 
                <br /><br />           
            </center>
        </div>
        <div style="width: 15%; float: right;">
            <br />
            <asp:Label ID="welcomeuser" runat="server" class="textonimage" Text="Label"></asp:Label>
        </div>
        <div class="content">
            <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="dataclassDataContext" EntityTypeName="" TableName="Tables" OrderBy="date_time desc">
            </asp:LinqDataSource>
            <asp:GridView ID="gv" runat="server" AutoGenerateColumns="False" DataKeyNames="suggestionid" DataSourceID="LinqDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowCommand="gv_RowCommand" AllowPaging="True" AllowSorting="True" Width="1100px" PageSize="8">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="date_time" HeaderText="DATE" SortExpression="date_time" DataFormatString="{0:d}">
                        <ControlStyle Width="90px" />
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="90px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="name" HeaderText="NAME" SortExpression="name" >
                    <ControlStyle Width="160px" />
                    <HeaderStyle HorizontalAlign="Left" />
                    <ItemStyle Width="160px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="department" HeaderText="DEPARTMENT" SortExpression="department">
                        <ControlStyle Width="150px" />
                        <HeaderStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="subject" HeaderText="SUBJECT" SortExpression="subject">
                        <ControlStyle Width="190px" />
                        <HeaderStyle HorizontalAlign="Left" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Left" VerticalAlign="Middle" Width="190px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="suggestion_temp" HeaderText="SUGGESTION" SortExpression="suggestion_temp">
                        <HeaderStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="likes" HeaderText="LIKES">
                        <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:ButtonField ButtonType="Button" CommandName="Onclickb" Text="Details" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>

</html>
