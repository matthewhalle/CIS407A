<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="PayrollSystem.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
<asp:Label ID="Label1" runat="server" Text="Login: " CssClass="lefttextbox"></asp:Label><asp:TextBox ID="txtUserName" runat="server" CssClass="righttextbox" ></asp:TextBox><br />
<asp:Label ID="Label2" runat="server" Text="Password: " CssClass="lefttextbox"></asp:Label> <asp:TextBox ID="txtPassword" runat="server" CssClass="righttextbox"></asp:TextBox><br />
<asp:Label ID="Label3" runat="server" Text="First: " CssClass="lefttextbox"></asp:Label><asp:TextBox ID="txtFirstName" runat="server" CssClass="righttextbox"></asp:TextBox><br />
<asp:Label ID="Label4" runat="server" Text="Last: " CssClass="lefttextbox"></asp:Label><asp:TextBox ID="txtLastName" runat="server" CssClass="righttextbox"></asp:TextBox><br />
<asp:Label ID="Label5" runat="server" Text="Email: " CssClass="lefttextbox"></asp:Label><asp:TextBox ID="txtEmail" runat="server" CssClass="righttextbox"></asp:TextBox><br />
<asp:Label ID="Label6" runat="server" Text="Level: " CssClass="lefttextbox"></asp:Label><asp:TextBox ID="txtLevel" runat="server" CssClass="righttextbox"></asp:TextBox><br />
<asp:Label ID="Label7" runat="server" Text="Photo: " CssClass="lefttextbox"></asp:Label><asp:FileUpload ID="photoUpload" runat="server" CssClass="righttextbox"  />
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="File Types jpg jpeg png gif" ValidationExpression="(.*?)\.(jpg|jpeg|png|gif)$" ControlToValidate="photoUpload"></asp:RegularExpressionValidator>
    <br />
        

<asp:Button ID="cmdAddUser" runat="server" text="Add User" onclick="cmdAddUser_Click" CssClass="button" Width="170px" />

<asp:Label ID="lblError" runat="server" Visible="false" CssClass="error"></asp:Label><br/>

</asp:Content>
