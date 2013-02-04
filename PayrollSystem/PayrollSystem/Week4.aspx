<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Week4.aspx.cs" Inherits="PayrollSystem.week4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            height: 21px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>trackerid</td>
            <td>key</td>
            <td>value</td>
            <td>when</td>
            <td># of Results</td>
        </tr>
         <tr>
            <td><asp:TextBox ID="txtTrackerID" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtKey" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtValue" runat="server"></asp:TextBox></td>
            <td><asp:TextBox ID="txtWhen" runat="server"></asp:TextBox></td>
            <td><asp:DropDownList ID="drpResults" runat="server">
                 <asp:ListItem Value="null">All</asp:ListItem>
                 <asp:ListItem>5</asp:ListItem>
                 <asp:ListItem Value="25"></asp:ListItem>
                 <asp:ListItem Value="50"></asp:ListItem>
                 <asp:ListItem Value="100"></asp:ListItem>
                 <asp:ListItem Value="500"></asp:ListItem>
                 <asp:ListItem Value="1000"></asp:ListItem>
             </asp:DropDownList></td>
            <td><asp:Button ID="cmdSearch" runat="server" text="Search" OnClick="cmdSearch_OnClick"  /></td>
        </tr>
    <asp:Repeater ID="rptDisplay" runat="server">
        <ItemTemplate>
            <tr>
                <td><%# DataBinder.Eval(Container.DataItem, "UserTrackerID") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "trackkey") %></td>
                <td colspan="2" ><%# DataBinder.Eval(Container.DataItem, "value") %></td>
                <td><%# DataBinder.Eval(Container.DataItem, "trackwhen") %></td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
        </table>    
</asp:Content>
