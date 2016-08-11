<%@ Page Title="" Language="C#" MasterPageFile="~/WebAdmin.Master" AutoEventWireup="true" CodeBehind="WebAdminHR.aspx.cs" Inherits="AspProject.Admin.WebAdminHR" %>
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
                <asp:Label ID="Label1" runat="server" Text="Create HR"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style2">UserName<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Please Enter Valid Username</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
         <td style="text-align:right" class="auto-style2">Password<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Please Enter Valid Password</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style2">Confirm Password<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtConfirm" runat="server" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtConfirm" ErrorMessage="CompareValidator" ForeColor="Red" ControlToCompare="txtPassword">Please Enter Same Password</asp:CompareValidator>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style2">Email Id<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmailid" ErrorMessage="RegularExpressionValidator" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Enter Valid Emailid</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Create HR" OnClick="Button1_Click"/>
            &nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="View HR"></asp:Label>
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
