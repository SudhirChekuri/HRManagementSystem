<%@ Page Title="" Language="C#" MasterPageFile="~/UserHome.Master" AutoEventWireup="true" CodeBehind="UserLeaves.aspx.cs" Inherits="AspProject.User.UserLeaves" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
        .auto-style2 {
            width: 312px;
        }
        .auto-style3 {
            width: 416px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label4" runat="server" Text="Leaves Information"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Employee Id<font color="red">*</font></td>
        <td><asp:TextBox ID="txtEmployeeid" runat="server"></asp:TextBox>
        &nbsp;
            </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">From Date<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtFromdate" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">To Date<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtTodate" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Sick Leaves<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtSickleaves" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Previlized Leaves<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtPrevilizedleaves" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="text-align:right" class="auto-style3">Manager Id<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtManagerid" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label2" runat="server" Text="Apply For Leave"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
         <td style="text-align:right" class="auto-style3">From Date<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtFrmdate" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="imageFrm" runat="server" Height="16px" ImageUrl="~/Images/Calendar.png" Width="25px" OnClick="imageFrm_Click" />
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        </td>
    </tr>
    <tr>
 <td style="text-align:right" class="auto-style3">To Date<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtTdate" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImagebtnTo" runat="server" Height="20px" ImageUrl="~/Images/Calendar.png" OnClick="ImagebtnTo_Click" />
            <br />
            <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
        </td>
    </tr>
    <tr>
         <td style="text-align:right" class="auto-style3">Comments<font color="red">*</font></td>
        <td>
            <asp:TextBox ID="txtCmments" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Button ID="Button1" runat="server" Text="Send Request to Manager" OnClick="Button1_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:Label ID="Label3" runat="server" Text="Leaves with Status"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style3">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
