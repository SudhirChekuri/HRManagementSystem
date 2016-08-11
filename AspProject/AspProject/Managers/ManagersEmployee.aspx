<%@ Page Title="" Language="C#" MasterPageFile="~/Manager.Master" AutoEventWireup="true" CodeBehind="ManagersEmployee.aspx.cs" Inherits="AspProject.Managers.ManagersEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 48px;
        }
        .auto-style3 {
            height: 48px;
            width: 75%;
        }
        .auto-style4 {
            width: 75%;
        }
        .auto-style5 {
            width: 75%;
            height: 137px;
        }
        .auto-style6 {
            height: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td style="text-align:right" class="auto-style3">Manager Id<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
                </td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
            <td class="auto-style2"></td>
        </tr>
        <tr>
            <td class="auto-style4">Approval Pending</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand">
                    <Columns>
                        <asp:BoundField HeaderText="Employee Id" DataField="Id" />
                        <asp:BoundField HeaderText="Employee Name" DataField="UserName" />
                        <asp:BoundField HeaderText="Email Id" DataField="EmailId" />
                        <asp:BoundField HeaderText="Status" DataField="Status" />
                        <asp:ButtonField HeaderText="Approvals" Text="Approved" />
                    </Columns>
                </asp:GridView>
            </td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
