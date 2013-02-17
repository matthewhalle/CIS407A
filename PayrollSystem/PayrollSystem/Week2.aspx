<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Week2.aspx.cs" Inherits="PayrollSystem.Week2" %>
<%@ Register TagPrefix="uc1" Namespace="PayrollSystem" Assembly="PayrollSystem" %>
<%@ Register src="login.ascx" tagname="login" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
     <style type="text/css">
        .style1
        {
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
       
    <div class="style1">
        <strong>
        <font color="blue" face="Comic Sans MS" size="4">Cool</font><font 
            color="#ff6600" face="Comic Sans MS" size="4">Biz</font><font 
            face="Comic Sans MS" size="4"><span class="Apple-converted-space">&nbsp;</span><font 
            color="#993366">Productions</font>, Inc.</font></strong><asp:Panel 
            ID="pnlInput" runat="server" Height="250px" HorizontalAlign="Center">
            <asp:Label ID="Label1" runat="server" Text="First Name: " width="72px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Last Name: " width="72px"></asp:Label>
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Pay Rate: " width="72px"></asp:Label>
            <asp:TextBox ID="txtPayRate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Start Date: " width="72px"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="End Date: " Width="72px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="btnSubmit_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" 
                onclick="btnCancel_Click" />
        </asp:Panel>
        <asp:Panel ID="pnlOutput" runat="server">
            <asp:Label ID="Label6" runat="server" Text="Information to submit">
                
            </asp:Label>
            <br />
            <asp:TextBox ID="txtVerifiedInfo"
                runat="server" Width="400px" Height="80px" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="btnRedo" runat="server" Text="Redo" onclick="btnRedo_Click" />
            <br />
            
        </asp:Panel>
    </div>

 

  
    
</asp:Content>
