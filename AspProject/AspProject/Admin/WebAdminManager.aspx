<%@ Page Title="" Language="C#" MasterPageFile="~/WebAdmin.Master" AutoEventWireup="true" CodeBehind="WebAdminManager.aspx.cs" Inherits="AspProject.Admin.WebAdminManager" %>
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
                <asp:Label ID="Label1" runat="server" Text="Create Manager"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style2">UserName<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Enter Valid Username" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style2">Password<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Enter Valid Password" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style2">Confirm Password<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtConfirm" ErrorMessage="Enter Same Password" ForeColor="Red" ControlToCompare="txtPassword"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style2">Email Id<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailid" ErrorMessage="Enter Valid Emailid" ForeColor="#FF5050" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Create Manager" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="View Manager"></asp:Label>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
