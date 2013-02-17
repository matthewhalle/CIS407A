<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="PayrollSystem.login" %>
login: <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox><br />
password: <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox><br />
<asp:Button ID="cmdLogIn" runat="server" text="Login" onclick="cmdLogIn_Click" 
    style="height: 26px" />
<asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>