<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="AspProject.User.UserLogin" %>
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
            <td style="text-align:right" class="auto-style2">UserName<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ControlToValidate="txtUsername" ErrorMessage="Enter Valid Username" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style2">Password<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="Invalid Password" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                 </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" CssClass="btn" runat="server" Text="Login" OnClick="Button1_Click" />
            &nbsp;&nbsp;
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/User/Register.aspx">Register</asp:HyperLink>
                <asp:Label ID="Label1" runat="server" Text="." ForeColor="Red"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
