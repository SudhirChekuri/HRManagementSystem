<%@ Page Title="" Language="C#" MasterPageFile="~/AdminHome.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="AspProject.Admin.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style3 {
            width: 359px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
             <td style="text-align:right" class="auto-style3">AdminType<font color="red"></font></td>
            <td>
                <asp:DropDownList ID="ddlAdmin" runat="server">
                    <asp:ListItem>WebAdmin</asp:ListItem>
                    <asp:ListItem>HR</asp:ListItem>
                    <asp:ListItem>Manager</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style3">UserName<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style3">Password<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="BtnLogin" runat="server" CssClass="btn" Text="Login" OnClick="BtnLogin_Click" />
            &nbsp;<asp:Label ID="Label1" runat="server" Text="." ForeColor="#FF5050"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
