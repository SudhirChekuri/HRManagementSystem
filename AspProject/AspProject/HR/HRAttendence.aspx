<%@ Page Title="" Language="C#" MasterPageFile="~/HRMaster.Master" AutoEventWireup="true" CodeBehind="HRAttendence.aspx.cs" Inherits="AspProject.HR.HRAttendence" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 353px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="MId" HeaderText="Manager Id" />
                        <asp:BoundField DataField="UserName" HeaderText="UserName" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server"  AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Employee Id" />
                        <asp:BoundField DataField="UserName" HeaderText="UserName" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style3">
                Employee Id</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style3">
&nbsp;
                Manager Id</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style3">Sickleaves<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
             <td style="text-align:right" class="auto-style3">Privilizedleaves<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
                       <td style="text-align:right" class="auto-style3">From Date<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" Height="19px" ImageUrl="~/Images/Calendar.png" OnClick="ImageButton1_Click" />
                <br />
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr>
                        <td style="text-align:right" class="auto-style3">To Date<font color="red">*</font> </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageButton2" runat="server" Height="19px" ImageUrl="~/Images/Calendar.png" OnClick="ImageButton2_Click" Width="32px" />
                <br />
                <asp:Calendar ID="Calendar2" runat="server" OnSelectionChanged="Calendar2_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" CssClass="btn" OnClick="Button1_Click" Text="Create Leave" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Label ID="lblCreateleave" runat="server" Text="."></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

