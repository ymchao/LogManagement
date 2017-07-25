<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="account.aspx.cs" Inherits="account" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">

    <table style="border: thin solid #507CD1; left: 240px; top: 180px; position: absolute;width: 20%; height: 220px; text-align: center;">
        <tr>
            <td class="auto-style12" colspan="2">修改密码</td>
        </tr>
        <tr>
            <td class="text">初始密码：</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text">新密码：</td>
            <td class="auto-style25">
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text">确认密码：</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server"  Font-Names="华文细黑" ForeColor="#DA2594" Font-Size="Large"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" BackColor="#507CD1" BorderStyle="None" Font-Names="华文细黑" ForeColor="White" Text="确认修改" Font-Size="Medium" OnClick="Button1_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

