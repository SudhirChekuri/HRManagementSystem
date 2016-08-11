<%@ Page Title="" Language="C#" MasterPageFile="~/HRMaster.Master" AutoEventWireup="true" CodeBehind="HRPayslips.aspx.cs" Inherits="AspProject.HR.HRPayslips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 302px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style3">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                    <Columns>
                        <asp:BoundField DataField="MId" HeaderText="MId" />
                        <asp:BoundField DataField="UserName" HeaderText="UserName" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView2_RowCommand" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
                    <Columns>
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        <asp:BoundField DataField="UserName" HeaderText="UserName" />
                        <asp:CommandField ShowSelectButton="True" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:GridView ID="GridView3" runat="server">
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
           <td style="text-align:right" class="auto-style3">Manager Id<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtMId" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style3">Employee Id<font color="red">*</font></td>
            <td>
                <asp:TextBox ID="txtEmpid" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
           <td style="text-align:right" class="auto-style3">Year<font color="red">*</font></td>
            <td>
                <asp:DropDownList ID="ddlYear" runat="server">
                    <asp:ListItem>2000</asp:ListItem>
                    <asp:ListItem>2001</asp:ListItem>
                    <asp:ListItem>2002</asp:ListItem>
                    <asp:ListItem>2003</asp:ListItem>
                    <asp:ListItem>2004</asp:ListItem>
                    <asp:ListItem>2005</asp:ListItem>
                    <asp:ListItem>2006</asp:ListItem>
                    <asp:ListItem>2007</asp:ListItem>
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                    <asp:ListItem>2012</asp:ListItem>
                    <asp:ListItem>2013</asp:ListItem>
                    <asp:ListItem>2014</asp:ListItem>
                    <asp:ListItem>2015</asp:ListItem>
                    <asp:ListItem>2016</asp:ListItem>
                    <asp:ListItem>2017</asp:ListItem>
                    <asp:ListItem>2018</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td style="text-align:right" class="auto-style3">Month<font color="red">*</font></td>
            <td>
                <asp:DropDownList ID="ddlMonth" runat="server">
                    <asp:ListItem>Jan</asp:ListItem>
                    <asp:ListItem>Feb</asp:ListItem>
                    <asp:ListItem>March</asp:ListItem>
                    <asp:ListItem>Apr</asp:ListItem>
                    <asp:ListItem>May</asp:ListItem>
                    <asp:ListItem>June</asp:ListItem>
                    <asp:ListItem>July</asp:ListItem>
                    <asp:ListItem>Aug</asp:ListItem>
                    <asp:ListItem>Sept</asp:ListItem>
                    <asp:ListItem>Oct</asp:ListItem>
                    <asp:ListItem>Nov</asp:ListItem>
                    <asp:ListItem>Dec</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
&nbsp;<asp:Button ID="btnUpload" runat="server" CssClass="btn" OnClick="btnUpload_Click" Text="Upload" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td>
                <asp:Label ID="Label1" runat="server">.</asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
