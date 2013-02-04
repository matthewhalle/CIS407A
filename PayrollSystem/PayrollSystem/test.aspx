<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="PayrollSystem.test" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <asp:Label ID="lblOne" runat="server" Text="Say this "></asp:Label>
    
    <asp:TextBox ID="TextBox1" runat="server">Hello!</asp:TextBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="# of Times: "></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
    </asp:DropDownList>

    <br/>
    <asp:Button ID="Button1" runat="server" Text="Speak To ME!" 
        onclick="Button1_Click" />
    
    
    <br />
    
    
</asp:Content>
