<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Week1.aspx.cs" Inherits="PayrollSystem.Week11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
    <asp:Label ID="Label1" runat="server" Text="Annual Hours"></asp:Label>
    <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
    </div>
    <asp:Label ID="Label2" runat="server" Text="Rate"></asp:Label>
    <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Calculate Salary" 
    onclick="Button1_Click" />
    <br />
    <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
   
    

</asp:Content>
