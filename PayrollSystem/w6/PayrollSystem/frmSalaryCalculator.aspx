<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmSalaryCalculator.aspx.cs" Inherits="PayrollSystem.frmSalaryCalculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Annual Hours"></asp:Label>
        <asp:TextBox ID="txtAnnualHours" runat="server"></asp:TextBox>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Rate"></asp:Label>
    <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="Calculate Salary" />
    <br />
    <asp:Label ID="lblSalary" runat="server" Text="$"></asp:Label>
    </form>
</body>
</html>
