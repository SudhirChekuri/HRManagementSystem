<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="ManagerLeaves.aspx.cs" Inherits="AspProject.Managers.ManagerLeaves" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
        .auto-style3 {
            width: 593px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label1" runat="server" Text="Leave Approvals"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtManagerid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Employee Id" />
                    <asp:BoundField DataField="Fromdate" HeaderText="From Date" />
                    <asp:BoundField DataField="Todate" HeaderText="To Date" />
                    <asp:BoundField DataField="Status" HeaderText="Status" />
                    <asp:ButtonField HeaderText="Approvals" Text="Approve" />
                </Columns>
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
