<%@ Page Title="" Language="C#" MasterPageFile="~/UserMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="AspProject.User.Register" %>
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
             <td style="text-align:right" class="auto-style2">UserName<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUsername" ErrorMessage="Enter Valid Username" ForeColor="#FF5050"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style2">EmailId<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtEmailid" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtEmailid" ErrorMessage="Please Enter EmailId" ForeColor="#FF5050"></asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="retxtEmailId" runat="server" 
        ControlToValidate="txtEmailId" Display="None" ErrorMessage="Enter valid mail id" SetFocusOnError="true"
        ValidationGroup="Validate1" 
        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="#FF5050"></asp:RegularExpressionValidator>
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
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="txtConfirm" ErrorMessage="Password do not match" ControlToCompare="txtPassword" ForeColor="#FF5050"></asp:CompareValidator>
            </td>
        </tr>
        <td style="text-align:right" class="auto-style2">ManagerId<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtMid" runat="server"></asp:TextBox>
        </td>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="btn" Text="Submit" OnClick="Button1_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
