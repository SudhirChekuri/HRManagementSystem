<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="AspProject.User.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 23px;
    }
        .auto-style3 {
            height: 23px;
            width: 33%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td style="text-align:right" class="auto-style3">Employee Id<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtEmployeeid" runat="server"></asp:TextBox>
        &nbsp;
            </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">UserName<font color="red">*</font></td>
        <td class="auto-style2">
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Email Id<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Manager Id<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtManagerid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Manager Name<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtManagername" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>
</asp:Content>
