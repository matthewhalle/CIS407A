<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="login.ascx.cs" Inherits="PayrollSystem.login" %>
<div >Login: </div>
<asp:TextBox ID="txtUserName" runat="server" ></asp:TextBox><br />

<div>Password: </div>
 <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" ></asp:TextBox><br />
<asp:Button ID="cmdLogIn" runat="server" text="Login" onclick="cmdLogIn_Click" 
    style="height: 26px" />
<asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>