<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Week3.aspx.cs" Inherits="PayrollSystem.Week3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    DataKeyNames="UserTrackerID" DataSourceID="SqlDataSource1" AllowPaging="True" 
        AllowSorting="True" Height="314px" HorizontalAlign="Center" Width="917px">
        <Columns>
            <asp:BoundField DataField="UserTrackerID" HeaderText="UserTrackerID" 
                ReadOnly="True" SortExpression="UserTrackerID" />
            <asp:BoundField DataField="TrackKey" HeaderText="TrackKey" 
                SortExpression="TrackKey" />
            <asp:BoundField DataField="value" HeaderText="value" SortExpression="value" />
            <asp:BoundField DataField="trackwhen" HeaderText="trackwhen" 
                SortExpression="trackwhen" />
        </Columns>
        
    </asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:Week3Tracker %>" 
    DeleteCommand="DELETE FROM [HalleTracker] WHERE [UserTrackerID] = @UserTrackerID" 
    InsertCommand="INSERT INTO [HalleTracker] ([UserTrackerID], [TrackKey], [value], [trackwhen]) VALUES (@UserTrackerID, @TrackKey, @value, @trackwhen)" 
    SelectCommand="SELECT * FROM [HalleTracker]" 
    
        UpdateCommand="UPDATE [HalleTracker] SET [TrackKey] = @TrackKey, [value] = @value, [trackwhen] = @trackwhen WHERE [UserTrackerID] = @UserTrackerID">
    <DeleteParameters>
        <asp:Parameter Name="UserTrackerID" Type="Object" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="UserTrackerID" Type="Object" />
        <asp:Parameter Name="TrackKey" Type="String" />
        <asp:Parameter Name="value" Type="String" />
        <asp:Parameter Name="trackwhen" Type="DateTime" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="TrackKey" Type="String" />
        <asp:Parameter Name="value" Type="String" />
        <asp:Parameter Name="trackwhen" Type="DateTime" />
        <asp:Parameter Name="UserTrackerID" Type="Object" />
    </UpdateParameters>
</asp:SqlDataSource>
    <asp:Button ID="btnClear" runat="server" Text="Clear" 
        onclick="btnClear_Click" />
</asp:Content>
