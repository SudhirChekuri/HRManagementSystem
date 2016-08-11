<%@ Page Title="" Language="C#" MasterPageFile="~/WebAdmin.Master" AutoEventWireup="true" CodeBehind="WebAdminEmployee.aspx.cs" Inherits="AspProject.Admin.WebAdminEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" CssClass="btn" Text="View Employees" Width="309px" OnClick="Button1_Click" />
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="GrdViewemp" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Employee Id" />
                    <asp:BoundField DataField="UserName" HeaderText="Employee Name" />
                    <asp:BoundField DataField="EmailId" HeaderText="Email Id" />
                    <asp:BoundField DataField="Password" HeaderText="Password" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:BoundField DataField="CreatedTime" HeaderText="Created Time" />
                    <asp:BoundField DataField="MId" HeaderText="Manager Id" />
                </Columns>
            </asp:GridView>
        </td>
        <td>
            &nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button2" runat="server" CssClass="btn" Text="Not Approved Employees" Width="307px" OnClick="Button2_Click" />
            <asp:GridView ID="GrdNotAproved" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Employee Id" />
                    <asp:BoundField DataField="UserName" HeaderText="Employee Name" />
                    <asp:BoundField DataField="EmailId" HeaderText="Email Id" />
                    <asp:BoundField DataField="Password" HeaderText="Password" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:BoundField DataField="CreatedTime" HeaderText="Created Time" />
                    <asp:BoundField DataField="MId" HeaderText="Manager Id" />
                </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
